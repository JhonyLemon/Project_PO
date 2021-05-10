﻿using System;
using System.IO;
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
    public partial class AddElementForm : Form, IObserver
    {
        List<Element> elements;
        public Element element;
        int ID = 0;
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
            AddElement_Type_ComboBox.Items.Add("Film");
            AddElement_Type_ComboBox.Items.Add("Muzyka");
            AddElement_Type_ComboBox.Items.Add("Ksiazka");
            AddElement_Type_ComboBox.Items.Add("Nowy element");
            element = new Element("", ID, Attributes);
            AddElement_FileLocation_Dynamic.LostFocus += AddElement_FileLocation_Dynamic_LostFocus;
            AddElement_ReleaseDate_Dynamic.Value = DateTime.Now.Date;
        }

        private void AddElement_FileLocation_Button_Click(object sender, EventArgs e)
        {
            AddElement_FileDialog.ShowDialog();
            AddElement_FileLocation_Dynamic.Text = AddElement_FileDialog.FileName;
            AddElement_FileDialog.Dispose();
            AddElement_FileLocation_Dynamic_LostFocus(this, null);
        }

        private void AddElement_PhotoLocation_Button_Click(object sender, EventArgs e)
        {
            AddElement_FileDialog.ShowDialog();
            AddElement_PhotoLocation_Dynamic.Text = AddElement_FileDialog.FileName;
            AddElement_FileDialog.Dispose();
        }

        private void AddElement_Exit_Button_Click(object sender, EventArgs e)
        {
            element = null;
            Close();
        }

        private void AddElement_Delete_Button_Click(object sender, EventArgs e)
        {
            if (Attributes.Count != 0)
            {
                DeleteElementDialog deleteElementDialog = new DeleteElementDialog(element.ExtraAttributes);//stworzenie nowego formularza typu AddElement z przekazywana referencja na liste studentow
                deleteElementDialog.ShowDialog(this);// wyswietlenie go jako okno dialogowe
                deleteElementDialog.Dispose();//zwolnienie pamieci
                Update();
            }
        }

        private void AddElement_Edit_Button_Click(object sender, EventArgs e)
        {
            if (Attributes.Count !=0)
            {
                EditElementDialogForm addAttribute = new EditElementDialogForm(element);//stworzenie nowego formularza typu AddElement z przekazywana referencja na liste studentow
                addAttribute.ShowDialog(this);// wyswietlenie go jako okno dialogowe
                addAttribute.Dispose();//zwolnienie pamieci
                Update();
            }
        }

        private void AddElement_AddAttribute_Button_Click(object sender, EventArgs e)
        {
            AddAttributeDialog addAttribute = new AddAttributeDialog(Attributes);//stworzenie nowego formularza typu AddElement z przekazywana referencja na liste studentow
            addAttribute.ShowDialog(this);// wyswietlenie go jako okno dialogowe
            addAttribute.Dispose();//zwolnienie pamieci
            Update();
        }

        private void AddElement_Add_Button_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if (AddElement_Name_TextBox.Text.Contains(";"))
                flag = true;
            if (AddElement_Author_TextBox.Text.Contains(";"))
                flag = true;
            if (AddElement_Description_TextBox.Text.Contains(";"))
                flag = true;
            if (AddElement_FileLocation_Dynamic.Text.Contains(";"))
                flag = true;
            if (AddElement_PhotoLocation_Dynamic.Text.Contains(";"))
                flag = true;
            if (AddElement_ReleaseDate_Dynamic.Text == "" || AddElement_ReleaseDate_Dynamic.Text.Contains(";"))
                flag = true;
            if (AddElement_Type_ComboBox.SelectedItem == null)
                flag = true;



            if (flag == false)
            {
                ID = elements.Count + 1;
                Dictionary<string, string> keys = new Dictionary<string, string>();
                keys.Add("Nazwa", AddElement_Name_TextBox.Text);
                keys.Add("Autor", AddElement_Author_TextBox.Text);
                keys.Add("Opis", AddElement_Description_TextBox.Text);
                keys.Add("Lokacja pliku", AddElement_FileLocation_Dynamic.Text);
                keys.Add("Lokacja zdjecia", AddElement_PhotoLocation_Dynamic.Text);
                keys.Add("Data Wydania", AddElement_ReleaseDate_Dynamic.Text);
                foreach (KeyValuePair<string, string> pair in Attributes)
                    keys.Add(pair.Key, pair.Value);
                if (AddElement_Type_ComboBox.SelectedItem.ToString() != "Nowy element")
                {
                    //elements.Add(new Element(AddElement_Type_ComboBox.SelectedItem.ToString(), ID, keys));
                    element.ID = ID;
                    element.ElementType = AddElement_Type_ComboBox.SelectedItem.ToString();
                    element.ExtraAttributes = keys;
                    element.AddImage(element.ExtraAttributes["Lokacja zdjecia"]);
                    elements.Add(element);
                }
                else
                {
                    //elements.Add(new Element(AddElement_Type_TextBox.Text, ID, keys));
                    element.ID = ID;
                    element.ElementType = AddElement_Type_TextBox.Text;
                    element.ExtraAttributes = keys;
                    element.AddImage(element.ExtraAttributes["Lokacja zdjecia"]);
                    elements.Add(element);
                }
                Close();
            }
            else
            {
                MessageBox.Show("Podane dane sa bledne", "Blad wprowadzanych danych", MessageBoxButtons.OK);
            }
        }
        public new  void Update()
        {
            AddElement_ExtraAttributes_ListView.Items.Clear();
            foreach (KeyValuePair<string, string> pair in Attributes)
            {
                AddElement_ExtraAttributes_ListView.Items.Add(new ListViewItem(new string[] { pair.Key, pair.Value }));
            }

        }

        private void AddElement_Type_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddElement_Type_TextBox.Visible = false;
            if (AddElement_Type_ComboBox.SelectedItem.ToString() == "Nowy element")
            {
                AddElement_Type_TextBox.Visible = true;
            }
        }
        private void AddElement_FileLocation_Dynamic_LostFocus(object sender, EventArgs e)
        {
            if( File.Exists(AddElement_FileLocation_Dynamic.Text))
            {
                FileInfo fileInfo = new FileInfo(AddElement_FileLocation_Dynamic.Text);
                if(AddElement_Name_TextBox.Text=="")
                    AddElement_Name_TextBox.Text = fileInfo.Name;
                if (AddElement_ReleaseDate_Dynamic.Value == DateTime.Now.Date)
                    AddElement_ReleaseDate_Dynamic.Value = fileInfo.CreationTime.Date;
            }
        }

    }
}
