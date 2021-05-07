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
        public SearchByForm()
        {
            InitializeComponent();
            bindDic.Add(0, "Szukaj przez Nazwe");
            SearchByComboBox.DataSource = new BindingSource(bindDic, null);
            SearchByComboBox.DisplayMember = "Value";
            SearchByComboBox.ValueMember = "Key";
        }
        public SearchByForm(List<Element> elements)
        {
            InitializeComponent();
            this.elements = elements;
            bindDic.Add(0, "Szukaj przez Nazwe");
            SearchByComboBox.DataSource = new BindingSource(bindDic, null);
            SearchByComboBox.DisplayMember = "Value";
            SearchByComboBox.ValueMember = "Key";
        }

        private void SearchByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchBySearchButton_Click(object sender, EventArgs e)
        {
            if(SearchByComboBox.ValueMember!=null && SearchByTextBox.Text!="")
            {
                (Owner as MainForm).listViewItem.Clear();
                switch((int)SearchByComboBox.SelectedValue)
                {
                    case 0:
                        {
                            foreach(Element element in elements)
                            {
                                if ((Owner as MainForm).search.FindByName(SearchByTextBox.Text,element))
                                    (Owner as MainForm).listViewItem.Add(new MyListViewItem(element));
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
