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
    public partial class DeleteElementDialog : Form
    {
        Dictionary<string, string> Attributes;//slownika z atrybutami elementu
        public DeleteElementDialog()
        {
            InitializeComponent();
        }
        public DeleteElementDialog(Dictionary<string, string> Attributes)
        {
            InitializeComponent();//inicjalizacja kontrolek
            this.Attributes = Attributes;//przypisanie slownika
            foreach (KeyValuePair<string, string> pair in Attributes)//wpisanie elementow do kontrolki combobox
            {
                switch (pair.Key)//jesli atrybut jest domyslnym nie dodajemy go
                {
                    case "Nazwa":
                        {
                            break;
                        }
                    case "Autor":
                        {
                            break;
                        }
                    case "Opis":
                        {
                            break;
                        }
                    case "Lokacja pliku":
                        {
                            break;
                        }
                    case "Lokacja zdjecia":
                        {
                            break;
                        }
                    case "Data Wydania":
                        {
                            break;
                        }
                    default:
                        {
                            DeleteElementDIalog_ComboBox.Items.Add(pair.Key);//dodanie elementu do kontrolki
                            break;
                        }
                }
            }
            DeleteElementDialog_TextBox.ResetText();//wyczyszczenie pola tekstowego
            DeleteElementDIalog_ComboBox.Text = "";//wyczyszczenie wybranego elementu kontrolki combobox
        }
        private void DeleteElementDialog_Delete_Button_Click(object sender, EventArgs e)
        {
            if (DeleteElementDIalog_ComboBox.SelectedItem != null)//jesli jest wybrany atrybut
            {
                Attributes.Remove((string)DeleteElementDIalog_ComboBox.SelectedItem);//usuniecie atrybutu
                if (Owner.Owner is MainForm)
                    (Owner.Owner as MainForm).observable.Notify();
                Close();//zamkniecie formularza
            }
        }

        private void DeleteElementDialog_Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();//zamkniecie formularza
        }

        private void DeleteElementDIalog_ComboBox_SelectedIndexChanged(object sender, EventArgs e)//zdarzenie, zmiana zaznaczonego indexu w kontrolce combobox
        {
            DeleteElementDialog_TextBox.ResetText();//usuniecie tekstu z pola tekstowego
            DeleteElementDialog_TextBox.Text = Attributes[(string)DeleteElementDIalog_ComboBox.SelectedItem];//wpisanie wartosci atrybutu do pola tekstowego
        }
    }
}
