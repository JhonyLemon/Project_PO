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
    public partial class AddElementForm : Form,IObserver
    {
        List<Element> elements;
        Element element;
        int ID;
        Dictionary<string, string> Attributes = new Dictionary<string, string>();
        public AddElementForm()
        {
            InitializeComponent();
            AddElement_Type_ComboBox.DataSource = Enum.GetValues(typeof(TypeOfElement));

        }
        public AddElementForm(List<Element> elements)
        {
            InitializeComponent();
            this.elements = elements;
            AddElement_Type_ComboBox.DataSource = Enum.GetValues(typeof(TypeOfElement));
            ID = elements.Count+1;
            element = new Element("", ID, Attributes);
        }

        private void AddElement_FileLocation_Button_Click(object sender, EventArgs e)
        {
            AddElement_FileDialog.ShowDialog();
            AddElement_FileLocation_Dynamic.Text = AddElement_FileDialog.FileName;
            AddElement_FileDialog.Dispose();
        }

        private void AddElement_PhotoLocation_Button_Click(object sender, EventArgs e)
        {
            AddElement_FileDialog.ShowDialog();
            AddElement_PhotoLocation_Dynamic.Text = AddElement_FileDialog.FileName;
            AddElement_FileDialog.Dispose();
        }

        private void AddElement_ExtraAttributes_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddElement_ExtraAttributes_ListView.Select();
        }


        private void AddmElement_Exit_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddElement_Delete_Button_Click(object sender, EventArgs e)
        {

            DeleteElementDialog deleteElementDialog = new DeleteElementDialog(element.ExtraAttributes);//stworzenie nowego formularza typu AddElement z przekazywana referencja na liste studentow
            deleteElementDialog.ShowDialog(this);// wyswietlenie go jako okno dialogowe
            deleteElementDialog.Dispose();//zwolnienie pamieci
            Update(elements);
        }

        private void AddElement_Edit_Button_Click(object sender, EventArgs e)
        {
            EditElementDialogForm addAttribute = new EditElementDialogForm(element);//stworzenie nowego formularza typu AddElement z przekazywana referencja na liste studentow
            addAttribute.ShowDialog(this);// wyswietlenie go jako okno dialogowe
            addAttribute.Dispose();//zwolnienie pamieci
            Update(elements);
        }

        private void AddElement_AddAttribute_Button_Click(object sender, EventArgs e)
        {
            AddAttributeDialog addAttribute = new AddAttributeDialog(Attributes);//stworzenie nowego formularza typu AddElement z przekazywana referencja na liste studentow
            addAttribute.ShowDialog(this);// wyswietlenie go jako okno dialogowe
            addAttribute.Dispose();//zwolnienie pamieci
            Update(elements);
        }

        private void AddElement_Add_Button_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> keys = new Dictionary<string, string>();
            keys.Add("Nazwa",AddElement_Name_TextBox.Text);
            keys.Add("Autor", AddElement_Author_TextBox.Text);
            keys.Add("Opis", AddElement_Description_TextBox.Text);
            keys.Add("Lokacja pliku", AddElement_FileLocation_Dynamic.Text);
            keys.Add("Lokacja zdjecia", AddElement_PhotoLocation_Dynamic.Text);
            keys.Add("Data Wydania", AddElement_ReleaseDate_Dynamic.Text);
            foreach (KeyValuePair<string, string> pair in Attributes)
                keys.Add(pair.Key, pair.Value);
            elements.Add(new Element(AddElement_Type_ComboBox.SelectedItem.ToString(), ID, keys));
            Close();
        }
        public void Update(List<Element> elements)
        {
            AddElement_ExtraAttributes_ListView.Items.Clear();
            foreach (KeyValuePair<string, string> pair in Attributes)
            {
                AddElement_ExtraAttributes_ListView.Items.Add(new ListViewItem(new string[] { pair.Key, pair.Value }));
            }
            
        }
    }
}
