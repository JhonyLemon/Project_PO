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
    public partial class EditElementForm : Form
    {
        List<Element> elements;
        SearchBy search;
        public EditElementForm()
        {
            InitializeComponent();
        }
        public EditElementForm(List<Element> elements)
        {
            InitializeComponent();
            this.EditElement_ComboBox.SelectionChangeCommitted += EditElement_ComboBox_SelectionChangeCommitted;
            this.elements = elements;
            search = new SearchBy(elements);
            EditElement_ComboBox.BeginUpdate();
            foreach (Element element in elements)
                EditElement_ComboBox.Items.Add(element.ExtraAttributes["Nazwa"]);
            EditElement_ComboBox.EndUpdate();

        }

        private void EditElement_ComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foreach (ListViewItem listViewitems in EditElement_ListView.Items)
                EditElement_ListView.Items.Remove(listViewitems);

            Element element = search.FindByName((string)EditElement_ComboBox.SelectedItem);

              foreach (KeyValuePair<string,string> pair in element.ExtraAttributes)
                 EditElement_ListView.Items.Add(new ListViewItem(new string[] { pair.Key,pair.Value }));
            // EditElement_ListView.Items.Add(new ListViewItem(new string[] { "Autor", element.Author }));
            // EditElement_ListView.Items.Add(new ListViewItem(new string[] { "Opis", element.Description }));
            // EditElement_ListView.Items.Add(new ListViewItem(new string[] { "Lokalizacja pliku", element.FileLocation }));
            // foreach (KeyValuePair<string, string> pairs in element.ExtraAttributes)
            // {
            //  EditElement_ListView.Items.Add(new ListViewItem(new string[] { pairs.Key, pairs.Value }));
            // }
                EditElement_ImageBox.Image = element.Image;

        }

        private void EditElement_Edit_Button_Click(object sender, EventArgs e)
        {

            if (EditElement_ComboBox.SelectedItem != null)
            {
                EditElementDialogForm editElementForm = new EditElementDialogForm(search.FindByName((string)EditElement_ComboBox.SelectedItem));//stworzenie nowego formularza typu AddElement z przekazywana referencja na liste studentow
                editElementForm.ShowDialog(this);// wyswietlenie go jako okno dialogowe
                editElementForm.Dispose();//zwolnienie pamieci
                foreach (ListViewItem listViewitems in EditElement_ListView.Items)
                    EditElement_ListView.Items.Remove(listViewitems);

                Element element = search.FindByName((string)EditElement_ComboBox.SelectedItem);

                foreach (KeyValuePair<string, string> pair in element.ExtraAttributes)
                    EditElement_ListView.Items.Add(new ListViewItem(new string[] { pair.Key, pair.Value }));
                EditElement_ImageBox.Image = element.Image;
            }
        }

        private void EditElement_Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
