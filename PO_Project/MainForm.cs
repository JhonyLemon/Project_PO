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
    /// <summary>
    /// Main form class
    /// Handles controls events
    /// </summary>
    public partial class MainForm : Form
    {
        List<Element> elements = new List<Element>();
        DataIO fileOperations;
        SearchBy search;
        /// <summary>
        /// MainForm constructor
        /// Initializes form components and read file with data
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            fileOperations = DataIO.GetInstance();
            elements = fileOperations.ReadElements();
            search = new SearchBy(elements);
           // elements.Add(new Film("Powrot do przeszlosci",Category.Action,"Film o potworach i wrozkach",TimeSpan.FromHours(2),"","1",DateTime.Today,"Bartek"));
           // photoDatas.Add(new PhotoData("1", "C:\\Users\\Adam\\Downloads\\powrot.jpg"));
           // writer.Update(elements);
           // writer.Update(photoDatas);
            foreach (Element element in elements)
            {
                ImageList.Images.Add(element.ID.ToString(),element.Image);
            }
            foreach (Element element in elements)
            {
                var ListViewItem = PhotoList.Items.Add(element.Name, element.ID.ToString());
            }

        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            AddElementForm AddElement = new AddElementForm();
            AddElement.ShowDialog(this);
            AddElement.Dispose();
        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            EditElementForm editElementForm = new EditElementForm(elements);//stworzenie nowego formularza typu AddElement z przekazywana referencja na liste studentow
            editElementForm.ShowDialog(this);// wyswietlenie go jako okno dialogowe
            editElementForm.Dispose();//zwolnienie pamieci
            Receiver receiver = new Receiver(this,elements);
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {

            DeleteElementForm deleteElement = new DeleteElementForm(elements);//stworzenie nowego formularza typu AddElement z przekazywana referencja na liste studentow
            deleteElement.ShowDialog(this);// wyswietlenie go jako okno dialogowe
            deleteElement.Dispose();//zwolnienie pamieci
            //elements.RemoveAt(0);
            //fileOperations.Update(elements);
            //foreach (ListViewItem listView in PhotoList.SelectedItems)
            //{
            //    elements.Remove(search.FindByID(listView.ImageKey));
            //}
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            SearchBy searchBy = new SearchBy(elements);
        }

        private void Sort_Button_Click(object sender, EventArgs e)
        {

        }

        private void Filter_Button_Click(object sender, EventArgs e)
        {

        }

        private void PhotoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Element element;
            PhotoList.Select();
            foreach (ListViewItem listViewitems in Details_ListView.Items)
                Details_ListView.Items.Remove(listViewitems);

            foreach (ListViewItem listView in PhotoList.SelectedItems)
            {
                element = search.FindByID(listView.ImageKey);
                Details_ListView.Items.Add(new ListViewItem(new string[] { "Name", element.Name }));
                Details_ListView.Items.Add(new ListViewItem(new string[] { "Autor", element.Author }));
                Details_ListView.Items.Add(new ListViewItem(new string[] { "Opis", element.Description }));
                Details_ListView.Items.Add(new ListViewItem(new string[] { "Lokalizacja pliku", element.FileLocation }));
                foreach (KeyValuePair<string,string>pairs in element.ExtraAttributes)
                {
                    Details_ListView.Items.Add(new ListViewItem(new string[] { pairs.Key,pairs.Value }));
                }


            }


            
        }
    }
}
