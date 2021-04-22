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
        public DeleteElementForm()
        {

        }

        public DeleteElementForm(List<Element> Elements)
        {
            InitializeComponent();
            this.elements = Elements;
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = elements;
            DeleteElement_ComboBox.DataSource = bindingSource1.DataSource;
            DeleteElement_ComboBox.DisplayMember = "Name";
            DeleteElement_ComboBox.ValueMember = "Name";
            DeleteElement_ComboBox.SelectionChangeCommitted += DeleteElement_ComboBox_SelectionChangeCommitted;


            
        }

        private void DeleteElement_ComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foreach (ListViewItem listViewitems in DeleteElement_ListView.Items)
                DeleteElement_ListView.Items.Remove(listViewitems);
            Element element = (Element)DeleteElement_ComboBox.SelectedItem;
            DeleteElement_ListView.Items.Add(new ListViewItem(new string[] { "Name", element.Name }));
            DeleteElement_ListView.Items.Add(new ListViewItem(new string[] { "Autor", element.Author }));
            DeleteElement_ListView.Items.Add(new ListViewItem(new string[] { "Opis", element.Description }));
            DeleteElement_ListView.Items.Add(new ListViewItem(new string[] { "Lokalizacja pliku", element.FileLocation }));
            foreach (KeyValuePair<string, string> pairs in element.ExtraAttributes)
            {
                DeleteElement_ListView.Items.Add(new ListViewItem(new string[] { pairs.Key, pairs.Value }));
            }
            DeleteElement_ImageBox.Image = element.Image;

        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteElement_ListView.Select();
        }


        private void DeleteElement_Cancel_Button_Click(object sender, EventArgs e)
        {

        }

        private void DeleteElement_Delete_Button_Click(object sender, EventArgs e)
        {
            elements.Remove((Element)DeleteElement_ComboBox.SelectedItem);
            Close();
            DataIO dataIO = DataIO.GetInstance();
            dataIO.Update(elements);
        }
    }
}
