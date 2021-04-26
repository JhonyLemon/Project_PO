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
    public partial class EditElementDialogForm : Form
    {
        Element element;
        public EditElementDialogForm(Element element)
        {
            InitializeComponent();
            this.element = element;
             EditElementDialog_ComboBox.BeginUpdate();
            foreach(KeyValuePair<string,string> pairs in element.ExtraAttributes)
                EditElementDialog_ComboBox.Items.Add(pairs.Key);
             EditElementDialog_ComboBox.EndUpdate();
        }

        private void EditElementDialog_ConfirmButton_Click(object sender, EventArgs e)
        {

            EditElementDialog_Label.Text = "Nazwa atrybutu:";
            element.ExtraAttributes[(string)EditElementDialog_ComboBox.SelectedItem] = EditElementDialog_TextBox.Text;
            if(EditElementDialog_ComboBox.SelectedItem.Equals("Lokacja zdjecia"))
                element.Image = Image.FromFile(element.ExtraAttributes[(string)EditElementDialog_ComboBox.SelectedItem]);
            EditElementDialog_TextBox.ResetText();
        }

        private void EditElementDialog_FinishButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void EditElementDialog_ComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            EditElementDialog_FileSelectButton.Visible = false;
            EditElementDialog_Label.Text = (string)EditElementDialog_ComboBox.SelectedItem + ":";
            EditElementDialog_TextBox.Text = element.ExtraAttributes[(string)EditElementDialog_ComboBox.SelectedItem];
            if (EditElementDialog_ComboBox.SelectedItem.Equals((string)"Lokacja zdjecia") || EditElementDialog_ComboBox.SelectedItem.Equals((string)"Lokacja pliku"))
            {
                EditElementDialog_FileSelectButton.Visible = true;
            }
        }

        private void EditElementDialog_FileSelectButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            EditElementDialog_TextBox.Text = openFileDialog1.FileName;
            openFileDialog1.Dispose();
        }
    }
}
