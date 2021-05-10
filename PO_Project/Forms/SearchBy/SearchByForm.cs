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
        Dictionary<int, string> bindDic = new Dictionary<int, string>();
        List<Element> elements;
        List<MyListViewItem> listViewItem;
        public SearchByForm()
        {
            InitializeComponent();
            bindDic.Add(0, "Szukaj przez nazwie");
            SearchByComboBox.DataSource = new BindingSource(bindDic, null);
            SearchByComboBox.DisplayMember = "Value";
            SearchByComboBox.ValueMember = "Key";
        }
        public SearchByForm(List<Element> elements, List<MyListViewItem> listViewItem)
        {
            InitializeComponent();
            SearchByTextBoxName.Visible = false;
            SearchByLabelName.Visible = false;
            this.elements = elements;
            this.listViewItem = listViewItem;
            bindDic.Add(0, "Szukaj po nazwie");
            bindDic.Add(1, "Szukaj po autorze");
            bindDic.Add(2, "Szukaj po opisie");
            bindDic.Add(3, "Szukaj po dacie");
            bindDic.Add(4, "Szukaj po typie");
            bindDic.Add(5, "Szukaj po dodatkowym atrybucie");
            SearchByComboBox.DataSource = new BindingSource(bindDic, null);
            SearchByComboBox.DisplayMember = "Value";
            SearchByComboBox.ValueMember = "Key";
        }

        private void SearchByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SearchByComboBox.SelectedValue.ToString()=="5")
            {
                SearchByTextBoxName.Visible = true;
                SearchByLabelName.Visible = true;
            }
            else
            {
                SearchByTextBoxName.Visible = false;
                SearchByLabelName.Visible = false;
            }
        }

        private void SearchBySearchButton_Click(object sender, EventArgs e)
        {
            if(SearchByComboBox.ValueMember!=null && SearchByTextBox.Text!="")
            {
                listViewItem.Clear();
                switch((int)SearchByComboBox.SelectedValue)
                {
                    case 0:
                        {
                            foreach(Element element in elements)
                            {
                                if ((Owner as MainForm).search.FindByAttribute("Nazwa",SearchByTextBox.Text,element))
                                    listViewItem.Add(new MyListViewItem(element));
                            }
                            break;
                        }
                    case 1:
                        {
                            foreach (Element element in elements)
                            {
                                if ((Owner as MainForm).search.FindByAttribute("Autor",SearchByTextBox.Text, element))
                                    listViewItem.Add(new MyListViewItem(element));
                            }
                            break;
                        }
                    case 2:
                        {
                            foreach (Element element in elements)
                            {
                                if ((Owner as MainForm).search.FindByAttribute("Opis",SearchByTextBox.Text, element))
                                    listViewItem.Add(new MyListViewItem(element));
                            }
                            break;
                        }
                    case 3:
                        {
                            foreach (Element element in elements)
                            {
                                if ((Owner as MainForm).search.FindByAttribute("Data",SearchByTextBox.Text, element))
                                    listViewItem.Add(new MyListViewItem(element));
                            }
                            break;
                        }
                    case 4:
                        {
                            foreach (Element element in elements)
                            {
                                if ((Owner as MainForm).search.FindByType(SearchByTextBox.Text, element))
                                    listViewItem.Add(new MyListViewItem(element));
                            }
                            break;
                        }
                    case 5:
                        {
                            if (SearchByTextBoxName.Text != "")
                            {
                                foreach (Element element in elements)
                                {
                                    if ((Owner as MainForm).search.FindByAttribute(SearchByTextBoxName.Text, SearchByTextBox.Text, element))
                                        listViewItem.Add(new MyListViewItem(element));
                                }
                            }
                            break;
                        }
                }
                (Owner as MainForm).Update();
            }
            

        }

        private void SearchByCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
