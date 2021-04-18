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
        DataParser parser;
        List<IElement> elements = new List<IElement>();
        public MainForm()
        {
            InitializeComponent();
            parser = new DataReader();
            elements = ((parser as DataReader).ReadElements());
            

        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
             
            parser = new DataWriter("Film,NazwaFilmu,,,,,,,,,,,,,,",ElementType.Film);
            elements.Add((parser as DataWriter).AddElement());
        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {

        }

        private void Search_Button_Click(object sender, EventArgs e)
        {

        }

        private void Sort_Button_Click(object sender, EventArgs e)
        {

        }

        private void Filter_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
