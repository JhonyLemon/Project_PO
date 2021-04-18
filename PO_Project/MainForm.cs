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
        List<IElement> elements = new List<IElement>();
        DataReader Reader = new DataReader();
        DataWriter Writer = new DataWriter();
        public MainForm()
        {
            InitializeComponent();
            elements = Reader.ReadElements();
            

        }

        private void Add_Button_Click(object sender, EventArgs e)
        {

            elements.Add(Writer.AddElement(Writer.FromStringToElement("Film,Nazwafilmu,Action,,,,,,")));
        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {
         
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            elements.RemoveAt(0);
            Writer.Update(elements);
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
