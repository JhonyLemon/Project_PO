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
        Dictionary<string, string> Attributes;//slownik zwierajacy atrybuty elementu
        public AddAttributeDialog()
        {
            InitializeComponent();
        }
        public AddAttributeDialog(Dictionary<string, string> Attributes)
        {
            InitializeComponent();//inicjalizacja kontrolek
            this.Attributes = Attributes;//przypisanie slownika
        }

        private void AddAttribute_AddButton_Click(object sender, EventArgs e)
        {
            if ((!AddAttribute_NameTextBox.Text.Equals("") && !AddAttribute_ValueTextBox.Text.Equals("")))//sprawdzenie czy pola tekstowe nie sa puste
            {
                if ((!AddAttribute_NameTextBox.Text.Contains(";") && !AddAttribute_ValueTextBox.Text.Contains(";")))//sprawdzenie czy nie wpisano znaku ";"
                {
                    Attributes.Add(AddAttribute_NameTextBox.Text, AddAttribute_ValueTextBox.Text);//dodanie nowego atrybutu
                    if (Owner.Owner is MainForm)
                        (Owner.Owner as MainForm).observable.Notify();
                    Close();//zamkniecie formularza
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
            Close();//zamkniecie formularza
        }
    }
}
