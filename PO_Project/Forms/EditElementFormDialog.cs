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
    public partial class EditElementFormDialog : Form
    {
        public string key;
        public string value;
        public EditElementFormDialog()
        {
            InitializeComponent();
        }
        public EditElementFormDialog(string key, string value)
        {
            InitializeComponent();
            this.key = key;
            this.value = value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if ((!textBox1.Text.Contains(";") && !textBox2.Text.Contains(";")) || (!textBox1.Text.Equals("") && !textBox2.Text.Equals("")))
                {
                    key = textBox1.Text;
                    value = textBox2.Text;
                    Close();
                }
                else
                {
                    DialogResult result;
                    result = MessageBox.Show("Wprowadzono zabroniony znak ", "Blad wprowadzanych danych", MessageBoxButtons.OK);
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
