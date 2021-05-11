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
    public partial class EditElementForm : Form, IObserver
    {
        List<Element> elements;//lista elementow
        Dictionary<int, string> Names= new Dictionary<int, string>();//slownik uzywany do bindowania comboboxa
        Element element;//wybrany element
        SearchBy search;//zmienna do wyszukiwania
        public EditElementForm()
        {
            InitializeComponent();
        }
        public EditElementForm(List<Element> elements)
        {
            InitializeComponent();//inicjalizacja kontrolek
            foreach(Element element in elements)
            {
                Names.Add(element.ID, element.ExtraAttributes["Nazwa"]);//dodanie elementow do slownika
            }
            this.EditElement_ComboBox.SelectionChangeCommitted += EditElement_ComboBox_SelectionChangeCommitted;//stworzenie nowego zdarzenia
            this.elements = elements;//wpisanie podanego argumentu do zmiennej
            search = new SearchBy(elements);//inicjalizacja wyszukiwania
            EditElement_ComboBox.DataSource = new BindingSource(Names, null);//bindowanie slownika do kontrolki combobox
            EditElement_ComboBox.DisplayMember = "Value";//wartosc wyswietlana jest wartoscia elementu slownika
            EditElement_ComboBox.ValueMember = "Key";//wartosc wybranego elementu bedzie kluczem slownika
            EditElement_ComboBox_SelectionChangeCommitted(this, null);//wywolanie zdarzenia
        }
        public EditElementForm(List<Element> elements,Element eleme)
        {
            InitializeComponent();//inicjalizacja konrolek
            this.element = eleme;//wpisanie wybranego elementu
            foreach (Element element in elements)
            {
                Names.Add(element.ID, element.ExtraAttributes["Nazwa"]);//dodanie elementow do slownika
            }
            this.EditElement_ComboBox.SelectionChangeCommitted += EditElement_ComboBox_SelectionChangeCommitted;//stworzenie nowego zdarzenia
            this.elements = elements;//wpisanie podanego argumentu do zmiennej
            search = new SearchBy(elements);//inicjalizacja wyszukiwania
            EditElement_ComboBox.DataSource = new BindingSource(Names, null);//bindowanie slownika do kontrolki combobox
            EditElement_ComboBox.DisplayMember = "Value";//wartosc wyswietlana jest wartoscia elementu slownika
            EditElement_ComboBox.ValueMember = "Key";//wartosc wybranego elementu bedzie kluczem slownika
            EditElement_ComboBox.SelectedValue = element.ID;//ustawienie wybranego elementu
            EditElement_ComboBox_SelectionChangeCommitted(this, null);//wywolanie zdarzenia
        }

        private void EditElement_ComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            EditElement_ListView.Items.Clear();//usuniecie elementow z listview

            element = search.FindByID(EditElement_ComboBox.SelectedValue.ToString());//wyszukanie wybranego elementu

              foreach (KeyValuePair<string,string> pair in element.ExtraAttributes)
                 EditElement_ListView.Items.Add(new ListViewItem(new string[] { pair.Key,pair.Value }));//dodanie elementow do listview
                EditElement_ImageBox.Image = element.Image;//ustawienie obrazka

        }

        private void EditElement_Edit_Button_Click(object sender, EventArgs e)
        {

            if (EditElement_ComboBox.SelectedItem != null)
            {
                EditElementDialogForm editElementForm = new EditElementDialogForm(element);//stworzenie nowego formularza typu  EditElementDialogForm
                editElementForm.ShowDialog(this);// wyswietlenie go jako okno dialogowe
                editElementForm.Dispose();//zwolnienie pamieci
                Update();//aktualizacja listview
            }
            (Owner as MainForm).Update();//aktualizacja listview w formluarzu glownym
        }

        private void EditElement_Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();//zamkniecie formularza
        }

        public new void Update()
        {
            EditElement_ListView.Items.Clear();//wyczyszczenie elementow listview
            foreach (KeyValuePair<string, string> pair in element.ExtraAttributes)
                EditElement_ListView.Items.Add(new ListViewItem(new string[] { pair.Key, pair.Value }));//dodanie elementow do listview
            EditElement_ImageBox.Image = element.Image;//ustawienie obrazka
        }

        private void EditElement_Add_Button_Click(object sender, EventArgs e)
        {
            if (element.ExtraAttributes.Count > 0)//jesli ilosc atrybutow jest wieksza od zera
            {
                AddAttributeDialog addAttributeDialog = new AddAttributeDialog(element.ExtraAttributes);//stworzenie nowego formularza typu AddAttributeDialog
                addAttributeDialog.ShowDialog(this);// wyswietlenie go jako okno dialogowe
                addAttributeDialog.Dispose();//zwolnienie pamieci
                Update();//aktualizacja listview
                (Owner as MainForm).Update();//aktualizacja listview w formluarzu glownym
            }
        }

        private void EditElement_Delete_Button_Click(object sender, EventArgs e)
        {
            if (element.ExtraAttributes.Count != 0)//jesli ilosc atrybutow jest wieksza od zera
            {
                DeleteElementDialog deleteElementDialog = new DeleteElementDialog(element.ExtraAttributes);//stworzenie nowego formularza typu DeleteElementDialog
                deleteElementDialog.ShowDialog(this);// wyswietlenie go jako okno dialogowe
                deleteElementDialog.Dispose();//zwolnienie pamieci
                Update();//aktualizacja listview
                (Owner as MainForm).Update();//aktualizacja listview w formluarzu glownym
            }
        }
    }
}
