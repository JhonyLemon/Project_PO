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
            if(EditElementDialog_ComboBox.SelectedItem!=null)
            {
                if (!EditElementDialog_TextBox.Text.Contains(";"))
                {
                    if (!EditElementDialog_TextBox.Text.Equals(""))
                    {
                        element.ExtraAttributes[EditElementDialog_Name_TextBox.Text] = EditElementDialog_TextBox.Text;
                        EditElementDialog_Name_TextBox.Text = "Nazwa atrybutu";
                        if (EditElementDialog_ComboBox.SelectedItem.Equals("Lokacja zdjecia"))
                            element.Image = Image.FromFile(element.ExtraAttributes[(string)EditElementDialog_ComboBox.SelectedItem]);
                        EditElementDialog_TextBox.ResetText();
                    }
                    else
                    {
                        MessageBox.Show("Wartosc nie moze byc pusta", "Blad wprowadzanych danych", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Wprowadzono zabroniony znak", "Blad wprowadzanych danych", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Najpierw wybierz atrybut ktory chcesz edytowac", "Blad wprowadzanych danych", MessageBoxButtons.OK);
            }    
        }

        private void EditElementDialog_FinishButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void EditElementDialog_ComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            EditElementDialog_FileSelectButton.Visible = false;
            EditElementDialog_Name_TextBox.Text = (string)EditElementDialog_ComboBox.SelectedItem;
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
