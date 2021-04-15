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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }





        private void Nowa_Biblioteka_Click(object sender, EventArgs e)
        {
            AddLibrary addLibrary = new AddLibrary();
            
            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (addLibrary.ShowDialog(this) == DialogResult.OK)
            {
           
            }
            addLibrary.Dispose();
        }

        private void Otworz_Biblioteke_Click(object sender, EventArgs e)
        {

        }

        private void Dodaj_Element_Click(object sender, EventArgs e)
        {

        }

        private void Usun_Element_Click(object sender, EventArgs e)
        {

        }

        private void Edytuj_Element_Click(object sender, EventArgs e)
        {

        }

        private void Zmien_Widok_Click(object sender, EventArgs e)
        {

        }

        private void Instrukcja_Click(object sender, EventArgs e)
        {

        }
    }
}
