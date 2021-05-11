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
    public partial class SearchByForm : Form
    {
        Dictionary<int, string> bindDic = new Dictionary<int, string>();//slownik uzywany do bindowania kontrolki combobox
        List<Element> elements;//lista elementow
        List<MyListViewItem> listViewItem;//lista elementow listviewitem
        public SearchByForm()
        {
            InitializeComponent();//inicjalizacja kontrolek
            bindDic.Add(0, "Szukaj przez nazwie");
            SearchByComboBox.DataSource = new BindingSource(bindDic, null);
            SearchByComboBox.DisplayMember = "Value";
            SearchByComboBox.ValueMember = "Key";
        }
        public SearchByForm(List<Element> elements, List<MyListViewItem> listViewItem)
        {
            InitializeComponent();//inicjalizacja kontrolek
            SearchByTextBoxName.Visible = false;//ukrycie kontrolek uzywanych przy szukaniu po dodatkowym atrybucie
            SearchByLabelName.Visible = false;
            this.elements = elements;//przypisanie listy elementow
            this.listViewItem = listViewItem;//przypisanie listy listviewitem
            bindDic.Add(0, "Szukaj po nazwie");//dodanie elementow do slownika
            bindDic.Add(1, "Szukaj po autorze");
            bindDic.Add(2, "Szukaj po opisie");
            bindDic.Add(3, "Szukaj po dacie");
            bindDic.Add(4, "Szukaj po typie");
            bindDic.Add(5, "Szukaj po dodatkowym atrybucie");
            SearchByComboBox.DataSource = new BindingSource(bindDic, null);//bindowanie slownika do combobox-a
            SearchByComboBox.DisplayMember = "Value";//wartosc wyswietlana jest wartoscia elementu slownika
            SearchByComboBox.ValueMember = "Key";//wartosc wybranego elementu bedzie kluczem slownika
        }

        private void SearchByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SearchByComboBox.SelectedValue.ToString()=="5")//jesli wybrano element z kluczeme "5"
            {
                SearchByTextBoxName.Visible = true;//pokaz kontrolki uzywane przy szukaniu po dodatkowym atrybucie
                SearchByLabelName.Visible = true;
            }
            else
            {
                SearchByTextBoxName.Visible = false;//ukryj kontrolki uzywane przy szukaniu po dodatkowym atrybucie
                SearchByLabelName.Visible = false;
            }
        }

        private void SearchBySearchButton_Click(object sender, EventArgs e)
        {
            if(SearchByComboBox.ValueMember!=null && SearchByTextBox.Text!="")//jesli wybrano element i pole tekstowe nie jest puste
            {
                listViewItem.Clear();//wyczyszczenie listy listviewitem
                switch((int)SearchByComboBox.SelectedValue)//sprawdzenie wybranego klucza
                {
                    case 0://szukanie po nazwie
                        {
                            foreach(Element element in elements)
                            {
                                if ((Owner as MainForm).search.FindByAttribute("Nazwa",SearchByTextBox.Text,element))//wyszukiwanie elementu po atrybucie
                                    listViewItem.Add(new MyListViewItem(element));//dodanie elementu do listy listviewitem
                            }
                            break;
                        }
                    case 1://szukanie po autorze
                        {
                            foreach (Element element in elements)
                            {
                                if ((Owner as MainForm).search.FindByAttribute("Autor",SearchByTextBox.Text, element))//wyszukiwanie elementu po atrybucie
                                    listViewItem.Add(new MyListViewItem(element));//dodanie elementu do listy listviewitem
                            }
                            break;
                        }
                    case 2://szukanie po opisie
                        {
                            foreach (Element element in elements)
                            {
                                if ((Owner as MainForm).search.FindByAttribute("Opis",SearchByTextBox.Text, element))//wyszukiwanie elementu po atrybucie
                                    listViewItem.Add(new MyListViewItem(element));//dodanie elementu do listy listviewitem
                            }
                            break;
                        }
                    case 3://szukanie po dacie
                        {
                            foreach (Element element in elements)
                            {
                                if ((Owner as MainForm).search.FindByAttribute("Data",SearchByTextBox.Text, element))//wyszukiwanie elementu po atrybucie
                                    listViewItem.Add(new MyListViewItem(element));//dodanie elementu do listy listviewitem
                            }
                            break;
                        }
                    case 4://szukanie po typie
                        {
                            foreach (Element element in elements)
                            {
                                if ((Owner as MainForm).search.FindByType(SearchByTextBox.Text, element))//wyszukiwanie elementu po atrybucie
                                    listViewItem.Add(new MyListViewItem(element));//dodanie elementu do listy listviewitem
                            }
                            break;
                        }
                    case 5://szukanie po dodatkowym atrybucie
                        {
                            if (SearchByTextBoxName.Text != "")
                            {
                                foreach (Element element in elements)
                                {
                                    if ((Owner as MainForm).search.FindByAttribute(SearchByTextBoxName.Text, SearchByTextBox.Text, element))//wyszukiwanie elementu po atrybucie
                                        listViewItem.Add(new MyListViewItem(element));//dodanie elementu do listy listviewitem
                                }
                            }
                            break;
                        }
                }
                (Owner as MainForm).Update();//odswiezenie kontrolki listview w formularzu glownym
            }
            

        }

        private void SearchByCancelButton_Click(object sender, EventArgs e)
        {
            Close();//zamkniecie formularza
        }
    }
}
