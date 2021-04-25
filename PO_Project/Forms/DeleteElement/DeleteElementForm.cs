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
        List<Element> elements;
        SearchBy search;
        public DeleteElementForm()
        {

        }

        public DeleteElementForm(List<Element> Elements)
        {
            InitializeComponent();
            this.elements = Elements;
            search = new SearchBy(elements);
            DeleteElement_ComboBox.BeginUpdate();
            foreach (Element element in elements)
                DeleteElement_ComboBox.Items.Add(element.ExtraAttributes["Nazwa"]);
            DeleteElement_ComboBox.EndUpdate();

        }

        private void DeleteElement_ComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foreach (ListViewItem listViewitems in DeleteElement_ListView.Items)
                DeleteElement_ListView.Items.Remove(listViewitems);

            Element element = search.FindByName((string)DeleteElement_ComboBox.SelectedItem);

            foreach (KeyValuePair<string, string> pair in element.ExtraAttributes)
                DeleteElement_ListView.Items.Add(new ListViewItem(new string[] { pair.Key, pair.Value }));
            DeleteElement_ImageBox.Image = element.Image;
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteElement_ListView.Select();
        }


        private void DeleteElement_Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteElement_Delete_Button_Click(object sender, EventArgs e)
        {
            elements.Remove(search.FindByName((string)DeleteElement_ComboBox.SelectedItem));
            Close();
        }
    }
}
