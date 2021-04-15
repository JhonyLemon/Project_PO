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
    public partial class AddLibrary : Form
    {
        public AddLibrary()
        {
            InitializeComponent();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            DialogResult result = OpenFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                File_Location.Text = OpenFile.FileName;
            }
        }

        private void Create_Library_Click(object sender, EventArgs e)
        {

        }

        private void OpenFile_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
