using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PO_Project
{
    public partial class DeleteElementForm : Form
    {
        Dictionary<int, string> Names = new Dictionary<int, string>();//slownik uzywany do bindowania do combobox-a
        List<Element> elements;//lista elementow
        public Element element1;//wybrany element
        SearchBy search;//do wyszukiwania
        public DeleteElementForm()
        {

        }

        public DeleteElementForm(List<Element> elements)
        {
            InitializeComponent();//inicjalizacja kontrolek
            search = new SearchBy(elements);//inicjalizacja zmiennej do wyszukiwania
            foreach (Element element in elements)
            {
                Names.Add(element.ID, element.ExtraAttributes["Nazwa"]);//dodanie elemetnow do slownika Names
            }
            this.elements = elements;//wpisanie listy elementow
            DeleteElement_ComboBox.DataSource = new BindingSource(Names, null);//przypisanie slownika do combobox-a
            DeleteElement_ComboBox.DisplayMember = "Value";//wyswietlana wartosc bedzie wartoscia slownika
            DeleteElement_ComboBox.ValueMember = "Key";//wartosc wybranego elementu bedzie kluczem tablicy

        }
        public DeleteElementForm(List<Element> elements,Element eleme)
        {
            InitializeComponent();//inicjalizacja kontrolek
            search = new SearchBy(elements);//inicjalizacja zmiennej do wyszukiwania
            foreach (Element element in elements)
            {
                Names.Add(element.ID, element.ExtraAttributes["Nazwa"]);//dodanie elemetnow do slownika Names
            }
            this.elements = elements;//wpisanie listy elementow
            DeleteElement_ComboBox.DataSource = new BindingSource(Names, null);//przypisanie slownika do combobox-a
            DeleteElement_ComboBox.DisplayMember = "Value";//wyswietlana wartosc bedzie wartoscia slownika
            DeleteElement_ComboBox.ValueMember = "Key";//wartosc wybranego elementu bedzie kluczem tablicy
            DeleteElement_ComboBox.SelectedValue = eleme.ID;//zmiana wybranego elementu
            DeleteElement_ComboBox_SelectionChangeCommitted(this, null);//wywolanie zdarzenia
        }

        private void DeleteElement_ComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DeleteElement_ListView.Items.Clear();//usuniecie elementow z listview
            Element element = search.FindByID(DeleteElement_ComboBox.SelectedValue.ToString());//znalezienie elementu
            foreach (KeyValuePair<string, string> pair in element.ExtraAttributes)
                DeleteElement_ListView.Items.Add(new ListViewItem(new string[] { pair.Key, pair.Value }));//dodanie elementow do slownika
            DeleteElement_ImageBox.Image = element.Image;//ustawnienie kontrolki z obrazkiem
        }

        private void DeleteElement_Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();//zamkniecie formularza
        }

        private void DeleteElement_Delete_Button_Click(object sender, EventArgs e)
        {
            if (DeleteElement_ComboBox.SelectedValue != null)//sprawdzenie czy zaznaczono element
            {
                int i = 1;
                element1 = search.FindByID(DeleteElement_ComboBox.SelectedValue.ToString());//znalezienie wybranego elementu
                elements.Remove(element1);//usuniecie go z listy elementow
                foreach (Element element in elements)
                {
                    element.ID = i++;//zmiana ID
                }
                Close();//zamkniecie formularza
            }
        }
    }
}
