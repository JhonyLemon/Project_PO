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
        Dictionary<string, string> Attributes;
        public AddAttributeDialog()
        {
            InitializeComponent();
        }
        public AddAttributeDialog(Dictionary<string, string> Attributes)
        {
            InitializeComponent();
            this.Attributes = Attributes;
        }

        private void AddAttribute_AddButton_Click(object sender, EventArgs e)
        {
            if ((!AddAttribute_NameTextBox.Text.Equals("") && !AddAttribute_ValueTextBox.Text.Equals("")))
            {
                if ((!AddAttribute_NameTextBox.Text.Contains(";") && !AddAttribute_ValueTextBox.Text.Contains(";")))
                {
                    Attributes.Add(AddAttribute_NameTextBox.Text, AddAttribute_ValueTextBox.Text);
                    Close();
                }
                else
                {
                    MessageBox.Show("Wprowadzono zabroniony znak ", "Blad wprowadzanych danych", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Wprowadz wartosc ", "Blad wprowadzanych danych", MessageBoxButtons.OK);
            }
        }

        private void AddAttribute_CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
