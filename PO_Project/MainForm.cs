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
    public partial class MainForm : Form, IObserver
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
            Update(elements);

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
            fileOperations.Update(elements);
            PhotoList.Items.Clear();
            foreach (Element element in elements)
            {
                ImageList.Images.Add(element.ID.ToString(), element.Image);
            }
            foreach (Element element in elements)
            {
                var ListViewItem = PhotoList.Items.Add(element.ExtraAttributes["Nazwa"], element.ID.ToString());
            }
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
            fileOperations.Update(elements);
            Update(elements);
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
            Element element=null;
            SelectElement(element);
        }

        private void PhotoList_DoubleClick(object sender, EventArgs e)
        {
            Element element=null;
            SelectElement(element);
            if (element != null && !element.ExtraAttributes["Lokacja pliku"].Equals(""))
                fileOperations.Open(element.ExtraAttributes["Lokacja pliku"]);

        }
        public void Update(List<Element> elements)
        {
            PhotoList.Items.Clear();
            ImageList.Images.Clear();
            foreach (Element element in elements)
            {
                ImageList.Images.Add(element.ID.ToString(), element.Image);
            }
            foreach (Element element in elements)
            {
                var ListViewItem = PhotoList.Items.Add(element.ExtraAttributes["Nazwa"], element.ID.ToString());
            }
        }
        public void SelectElement(Element element)
        {
            PhotoList.Select();
            foreach (ListViewItem listViewitems in Details_ListView.Items)
                Details_ListView.Items.Remove(listViewitems);

            foreach (ListViewItem listView in PhotoList.SelectedItems)
            {
                element = search.FindByID(listView.ImageKey);
                foreach (KeyValuePair<string, string> pairs in element.ExtraAttributes)
                {
                    Details_ListView.Items.Add(new ListViewItem(new string[] { pairs.Key, pairs.Value }));
                }
            }
        }
    }
}
