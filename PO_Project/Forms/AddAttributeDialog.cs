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
    public partial class AddAttributeDialog : Form
    {
        public string key { get; set; }
        public string value { get; set; }
        public AddAttributeDialog()
        {
            InitializeComponent();
        }

        private void AddAttribute_AddButton_Click(object sender, EventArgs e)
        {
            if ((!AddAttribute_NameTextBox.Text.Contains(";") && !AddAttribute_ValueTextBox.Text.Contains(";")) || (!AddAttribute_NameTextBox.Text.Equals("") && !AddAttribute_ValueTextBox.Text.Equals("")))
            {
                key = AddAttribute_NameTextBox.Text;
                value = AddAttribute_ValueTextBox.Text;
                Close();
            }
            else
            {
                DialogResult result;
                result = MessageBox.Show("Wprowadzono zabroniony znak \";\"", "Blad wprowadzanych danych", MessageBoxButtons.OK);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void AddAttribute_CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
