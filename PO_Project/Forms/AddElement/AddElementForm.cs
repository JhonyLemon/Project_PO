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
    public partial class AddElementForm : Form
    {
        List<Element> elements;
        int ID;
        Dictionary<string, string> Attributes = new Dictionary<string, string>();
        public AddElementForm()
        {
            InitializeComponent();
            AddElement_Type_ComboBox.DataSource = Enum.GetValues(typeof(TypeOfElement));

        }
        public AddElementForm(List<Element> elements)
        {
            InitializeComponent();
            this.elements = elements;
            AddElement_Type_ComboBox.DataSource = Enum.GetValues(typeof(TypeOfElement));

        }

        private void AddElement_FileLocation_Button_Click(object sender, EventArgs e)
        {
            AddElement_FileDialog.ShowDialog();
            AddElement_FileLocation_Dynamic.Text = AddElement_FileDialog.FileName;
            AddElement_FileDialog.Dispose();
        }

        private void AddElement_PhotoLocation_Button_Click(object sender, EventArgs e)
        {
            AddElement_FileDialog.ShowDialog();
            AddElement_PhotoLocation_Dynamic.Text = AddElement_FileDialog.FileName;
            AddElement_FileDialog.Dispose();
        }

        private void AddElement_ExtraAttributes_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddElement_ExtraAttributes_ListView.Select();
        }


        private void AddmElement_Exit_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddElement_Delete_Button_Click(object sender, EventArgs e)
        {

            foreach(ListViewItem item in AddElement_ExtraAttributes_ListView.SelectedItems)
            {
                AddElement_ExtraAttributes_ListView.Items.Remove(item);
            }
        }

        private void AddElement_Edit_Button_Click(object sender, EventArgs e)
        {

        }

        private void AddElement_AddAttribute_Button_Click(object sender, EventArgs e)
        {
            AddAttributeDialog addAttribute = new AddAttributeDialog();//stworzenie nowego formularza typu AddElement z przekazywana referencja na liste studentow
            addAttribute.ShowDialog(this);// wyswietlenie go jako okno dialogowe
            Attributes.Add(addAttribute.key, addAttribute.value);
            addAttribute.Dispose();//zwolnienie pamieci
        }

        private void AddElement_Add_Button_Click(object sender, EventArgs e)
        {
            elements.Add(new Element((string)AddElement_Type_ComboBox.SelectedItem, ID, Attributes));
            Close();
        }
    }
}
