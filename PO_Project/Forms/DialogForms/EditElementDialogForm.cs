using System;
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
    public partial class EditElementDialogForm : Form
    {
        Element element;//wybrany element
        public EditElementDialogForm(Element element)
        {
            InitializeComponent();//inicjalizacja kontrolek
            this.element = element;//przypisanie elementu
             EditElementDialog_ComboBox.BeginUpdate();
            foreach(KeyValuePair<string,string> pairs in element.ExtraAttributes)
                EditElementDialog_ComboBox.Items.Add(pairs.Key);//dodanie elementow do kontrolki combobox
             EditElementDialog_ComboBox.EndUpdate();
        }

        private void EditElementDialog_ConfirmButton_Click(object sender, EventArgs e)
        {
            if(EditElementDialog_ComboBox.SelectedItem!=null)//jesli wybrano element
            {
                if (!EditElementDialog_TextBox.Text.Contains(";"))//jesli wpisana wartosc nie zawiera znaku ";"
                {
                    if (!EditElementDialog_TextBox.Text.Equals(""))//jesli pole tekstowe nie jest puste
                    {
                        element.ExtraAttributes[EditElementDialog_Name_TextBox.Text] = EditElementDialog_TextBox.Text;//zmiana wartosci atrybutu
                        EditElementDialog_Name_TextBox.Text = "Nazwa atrybutu";//reset etykiety
                        if((string)EditElementDialog_ComboBox.SelectedItem=="Lokacja zdjecia")
                            element.AddImage(EditElementDialog_TextBox.Text);//zmiana obrazka
                        EditElementDialog_TextBox.ResetText();//reset pola tekstowego
                    }
                    else
                    {
                        MessageBox.Show("Wartosc nie moze byc pusta", "Blad wprowadzanych danych", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Wprowadzono zabroniony znak", "Blad wprowadzanych danych", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Najpierw wybierz atrybut ktory chcesz edytowac", "Blad wprowadzanych danych", MessageBoxButtons.OK);
            }
            if (Owner is EditElementForm)//wywolanie odswiezenia kontrolek listview w formularzach rodzica
                (Owner as EditElementForm).Update();
            else if(Owner is AddElementForm)
                (Owner as AddElementForm).Update();
        }

        private void EditElementDialog_FinishButton_Click(object sender, EventArgs e)
        {
            Close();//zamkniecie formularza
        }
        private void EditElementDialog_ComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            EditElementDialog_FileSelectButton.Visible = false;//wylaczenie widocznonsci przycisku do wyboru pliku
            EditElementDialog_Name_TextBox.Text = (string)EditElementDialog_ComboBox.SelectedItem;//wpisanie wartosci wybranego elementu do etykiety
            EditElementDialog_TextBox.Text = element.ExtraAttributes[(string)EditElementDialog_ComboBox.SelectedItem];//wpisanie wartosci wybranego elementu do pola tekstowego
            if (EditElementDialog_ComboBox.SelectedItem.Equals((string)"Lokacja zdjecia") || EditElementDialog_ComboBox.SelectedItem.Equals((string)"Lokacja pliku"))//jesli wybrano lokacje pliku lub zdjecia to pokaz guzik
            {
                EditElementDialog_FileSelectButton.Visible = true;//wlaczenie widocznosci guzika do wyboru pliku
            }
        }

        private void EditElementDialog_FileSelectButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();//pokazanie okna dialogowego do wyboru pliku
            EditElementDialog_TextBox.Text = openFileDialog1.FileName;//wpisanie lokacji pliku do pola tekstowego
            openFileDialog1.Dispose();//zwolnienie pamieci
        }
    }
}
