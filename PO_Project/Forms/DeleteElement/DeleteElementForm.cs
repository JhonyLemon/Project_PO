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
        Dictionary<int, string> Names = new Dictionary<int, string>();
        List<Element> elements;
        SearchBy search;
        public DeleteElementForm()
        {

        }

        public DeleteElementForm(List<Element> elements)
        {
            InitializeComponent();
            search = new SearchBy(elements);
            foreach (Element element in elements)
            {
                Names.Add(element.ID, element.ExtraAttributes["Nazwa"]);
            }
            this.elements = elements;
            search = new SearchBy(elements);
            DeleteElement_ComboBox.DataSource = new BindingSource(Names, null);
            DeleteElement_ComboBox.DisplayMember = "Value";
            DeleteElement_ComboBox.ValueMember = "Key";

        }

        private void DeleteElement_ComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foreach (ListViewItem listViewitems in DeleteElement_ListView.Items)
                DeleteElement_ListView.Items.Remove(listViewitems);

            Element element = search.FindByID(DeleteElement_ComboBox.SelectedValue.ToString());

            foreach (KeyValuePair<string, string> pair in element.ExtraAttributes)
                DeleteElement_ListView.Items.Add(new ListViewItem(new string[] { pair.Key, pair.Value }));
            DeleteElement_ImageBox.Image = element.Image;
        }

        private void DeleteElement_Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteElement_Delete_Button_Click(object sender, EventArgs e)
        {
            int i = 1;
            elements.Remove(search.FindByID(DeleteElement_ComboBox.SelectedValue.ToString()));
            foreach(Element element in elements)
            {
                element.ID = i++;
            }
            Close();
        }
    }
}
