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
            DeleteElementDIalog_ComboBox.DataSource = new BindingSource(Attributes, null);
            DeleteElementDIalog_ComboBox.DisplayMember = "Key";
            DeleteElementDIalog_ComboBox.ValueMember = "Value";
            DeleteElementDialog_TextBox.ResetText();
        }
        private void DeleteElementDialog_Delete_Button_Click(object sender, EventArgs e)
        {
            Attributes.Remove(((KeyValuePair<string, string>)DeleteElementDIalog_ComboBox.SelectedItem).Key);
            Close();
        }

        private void DeleteElementDialog_Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteElementDIalog_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteElementDialog_TextBox.ResetText();
            DeleteElementDialog_TextBox.Text = DeleteElementDIalog_ComboBox.SelectedValue.ToString();
        }
    }
}
