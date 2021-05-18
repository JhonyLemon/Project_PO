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
    public partial class AddElementForm : Form, IObserver
    {
        List<Element> elements;//lista elementow
        public Element element;//nowo tworzony element
        int ID = 0;//id nowo dodawanego elementu
        Dictionary<string, string> Attributes = new Dictionary<string, string>();//slownik na atrybuty elementu
        public AddElementForm()
        {
            InitializeComponent();
            AddElement_Type_ComboBox.DataSource = Enum.GetValues(typeof(TypeOfElement));
        }
        public AddElementForm(List<Element> elements)
        {
            InitializeComponent();
            this.elements = elements;//przypisanie podawanego argumentu
            AddElement_Type_ComboBox.Items.Add("Film");//dodanie elementow do kontrolki combobox
            AddElement_Type_ComboBox.Items.Add("Muzyka");
            AddElement_Type_ComboBox.Items.Add("Ksiazka");
            AddElement_Type_ComboBox.Items.Add("Nowy element");
            element = new Element("", ID, Attributes);//inicjalizacja elementu
            AddElement_FileLocation_Dynamic.LostFocus += AddElement_FileLocation_Dynamic_LostFocus;//stworzenie nowego zdarzenia gdy pole tekstowe traci focus
            AddElement_ReleaseDate_Dynamic.Value = DateTime.Now.Date;//ustawnienie zawartosci daty na obecna date
        }

        private void AddElement_FileLocation_Button_Click(object sender, EventArgs e)
        {
            AddElement_FileDialog.ShowDialog();//otworzenie okna dialogowego z wybieraniem pliku
            AddElement_FileLocation_Dynamic.Text = AddElement_FileDialog.FileName;//przepisanie sciezki do pliku
            AddElement_FileDialog.Dispose();//zwolnienie pamieci
            AddElement_FileDialog.FileName = "";//czyszczenie sciezki
            AddElement_FileLocation_Dynamic_LostFocus(this, null);//wywolanie zdarzenia 
        }

        private void AddElement_PhotoLocation_Button_Click(object sender, EventArgs e)
        {
            AddElement_FileDialog.ShowDialog();//otworzenie okna dialogowego z wybieraniem pliku
            AddElement_PhotoLocation_Dynamic.Text = AddElement_FileDialog.FileName;//przepisanie sciezki do pliku
            AddElement_FileDialog.Dispose();//zwolnienie pamieci
            AddElement_FileDialog.FileName = "";//czyszczenie sciezki
        }

        private void AddElement_Exit_Button_Click(object sender, EventArgs e)
        {
            element = null;//ustawnienie elementu na null
            Close();//zamkniecie formularza
        }

        private void AddElement_Delete_Button_Click(object sender, EventArgs e)
        {
            if (Attributes.Count != 0)
            {
                DeleteElementDialog deleteElementDialog = new DeleteElementDialog(element.ExtraAttributes);//stworzenie nowego formularza typu deleteElementDialog
                deleteElementDialog.ShowDialog(this);// wyswietlenie go jako okno dialogowe
                deleteElementDialog.Dispose();//zwolnienie pamieci
            }
        }

        private void AddElement_Edit_Button_Click(object sender, EventArgs e)
        {
            if (Attributes.Count !=0)
            {
                EditElementDialogForm addAttribute = new EditElementDialogForm(element);//stworzenie nowego formularza typu addAttribute
                addAttribute.ShowDialog(this);// wyswietlenie go jako okno dialogowe
                addAttribute.Dispose();//zwolnienie pamieci
            }
        }

        private void AddElement_AddAttribute_Button_Click(object sender, EventArgs e)
        {
            AddAttributeDialog addAttribute = new AddAttributeDialog(Attributes);//stworzenie nowego formularza typu addAttribute
            addAttribute.ShowDialog(this);// wyswietlenie go jako okno dialogowe
            addAttribute.Dispose();//zwolnienie pamieci
        }

        private void AddElement_Add_Button_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if (AddElement_Name_TextBox.Text.Contains(";"))//sprawdzanie czy podana wartosc nie zawiera znaku ";"
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
                ID = elements.Count + 1;//ustawienie ID
                Dictionary<string, string> keys = new Dictionary<string, string>();//stworzenie nowego slownika
                keys.Add("Nazwa", AddElement_Name_TextBox.Text);//dodanie atrybutow
                keys.Add("Autor", AddElement_Author_TextBox.Text);
                keys.Add("Opis", AddElement_Description_TextBox.Text);
                keys.Add("Lokacja pliku", AddElement_FileLocation_Dynamic.Text);
                keys.Add("Lokacja zdjecia", AddElement_PhotoLocation_Dynamic.Text);
                keys.Add("Data Wydania", AddElement_ReleaseDate_Dynamic.Text);
                foreach (KeyValuePair<string, string> pair in Attributes)
                    keys.Add(pair.Key, pair.Value);//dodanie dodatkowych atrybutow
                if (AddElement_Type_ComboBox.SelectedItem.ToString() != "Nowy element")//jesli dodajemy predefiniowany element
                {
                    element.ID = ID;//przypisanie ID
                    element.ElementType = AddElement_Type_ComboBox.SelectedItem.ToString();//przypisanie typu elementu
                    element.ExtraAttributes = keys;//wpisanie slownika
                    element.AddImage(element.ExtraAttributes["Lokacja zdjecia"]);//dodanie obrazu
                    elements.Add(element);//dodawanie elementu do listy
                }
                else//jesli dodajemy nowy typ elementu
                {
                    element.ID = ID;//przypisanie ID
                    element.ElementType = AddElement_Type_TextBox.Text;//przypisanie typu elementu
                    element.ExtraAttributes = keys;//wpisanie slownika
                    element.AddImage(element.ExtraAttributes["Lokacja zdjecia"]);//dodanie obrazu
                    elements.Add(element);//dodawanie elementu do listy
                }
                (Owner as MainForm).observable.Notify();
                Close();//zamkniecie formularza
            }
            else
            {
                MessageBox.Show("Podane dane sa bledne", "Blad wprowadzanych danych", MessageBoxButtons.OK);
            }
        }
        public new  void Update()
        {
            AddElement_ExtraAttributes_ListView.Items.Clear();//usuniecie elementow z listview
            foreach (KeyValuePair<string, string> pair in Attributes)
            {
                AddElement_ExtraAttributes_ListView.Items.Add(new ListViewItem(new string[] { pair.Key, pair.Value }));//wpisanie elementow do listview
            }

        }

        private void AddElement_Type_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddElement_Type_TextBox.Visible = false;
            if (AddElement_Type_ComboBox.SelectedItem.ToString() == "Nowy element")//jesli wybrano "Nowy element"
            {
                AddElement_Type_TextBox.Visible = true;//pokaz textbox
            }
        }
        private void AddElement_FileLocation_Dynamic_LostFocus(object sender, EventArgs e)
        {
            if( File.Exists(AddElement_FileLocation_Dynamic.Text))//jesli plik istnieje
            {
                FileInfo fileInfo = new FileInfo(AddElement_FileLocation_Dynamic.Text);//wczytanie informacji o pliku
                if(AddElement_Name_TextBox.Text=="")//jesli pole tekstowe jest puste
                    AddElement_Name_TextBox.Text = fileInfo.Name;//wpisz nazwe pliku
                if (AddElement_ReleaseDate_Dynamic.Value == DateTime.Now.Date)//jesli data jest ustawiona na dzisiejsza
                    AddElement_ReleaseDate_Dynamic.Value = fileInfo.CreationTime.Date;//ustaw date utworzenia na ta z pliku
            }
        }

    }
}
