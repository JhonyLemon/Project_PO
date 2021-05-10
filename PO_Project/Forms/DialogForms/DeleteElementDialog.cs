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
        Dictionary<string, string> Attributes;
        public DeleteElementDialog()
        {
            InitializeComponent();
        }
        public DeleteElementDialog(Dictionary<string,string> Attributes)
        {
            InitializeComponent();
            this.Attributes = Attributes;
            //DeleteElementDIalog_ComboBox.DataSource = new BindingSource(Attributes, null);
            foreach(KeyValuePair<string,string> pair in Attributes)
            {
                switch(pair.Key)
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
                            DeleteElementDIalog_ComboBox.Items.Add(pair.Key);
                            break;
                        }
                }
            }
            //DeleteElementDIalog_ComboBox.DisplayMember = "Key";
            //DeleteElementDIalog_ComboBox.ValueMember = "Value";
            DeleteElementDialog_TextBox.ResetText();
            DeleteElementDIalog_ComboBox.Text = "";
        }
        private void DeleteElementDialog_Delete_Button_Click(object sender, EventArgs e)
        {
            if (DeleteElementDIalog_ComboBox.SelectedItem != null)
            {
                Attributes.Remove((string)DeleteElementDIalog_ComboBox.SelectedItem);
                Close();
            }
        }

        private void DeleteElementDialog_Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteElementDIalog_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteElementDialog_TextBox.ResetText();
            DeleteElementDialog_TextBox.Text = Attributes[(string)DeleteElementDIalog_ComboBox.SelectedItem];
        }
    }
}
