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
        Element element;
        DataIO fileOperations;
        public SearchBy search;
        List<MyListViewItem> listViewItem = new List<MyListViewItem>();
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
            foreach(Element element in elements)
            {
                listViewItem.Add(new MyListViewItem(element));    
            }
            Update();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            AddElementForm AddElement = new AddElementForm(elements);
            AddElement.ShowDialog(this);
            fileOperations.Update(elements);
            if(AddElement.element != null && AddElement.element.ID!=0)
                listViewItem.Add(new MyListViewItem(AddElement.element));
            Update();
            AddElement.Dispose();
        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            if (PhotoList.SelectedItems.Count!=0 && elements.Count>0)
            {
                EditElementForm editElementForm = new EditElementForm(elements,element);//stworzenie nowego formularza typu AddElement z przekazywana referencja na liste studentow
                editElementForm.ShowDialog(this);// wyswietlenie go jako okno dialogowe
                editElementForm.Dispose();//zwolnienie pamieci
                fileOperations.Update(elements);
            }
            else if(elements.Count > 0)
            {
                EditElementForm editElementForm = new EditElementForm(elements);//stworzenie nowego formularza typu AddElement z przekazywana referencja na liste studentow
                editElementForm.ShowDialog(this);// wyswietlenie go jako okno dialogowe
                editElementForm.Dispose();//zwolnienie pamieci
                fileOperations.Update(elements);
            }
            else
            {
                MessageBox.Show("Nie ma elementow do edycji", "Brak elementow", MessageBoxButtons.OK);
            }
        }
        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (PhotoList.SelectedItems.Count == 0 && elements.Count>0)
            {
                DeleteElementForm deleteElement = new DeleteElementForm(elements);//stworzenie nowego formularza typu AddElement z przekazywana referencja na liste studentow
                deleteElement.ShowDialog(this);// wyswietlenie go jako okno dialogowe
                foreach (MyListViewItem viewItem in listViewItem)
                {
                    if (viewItem.element == deleteElement.element1)
                    {
                        listViewItem.Remove(viewItem);
                        break;
                    }
                }
                fileOperations.Update(elements);
                Update();
                deleteElement.Dispose();//zwolnienie pamieci
            }
            else if(elements.Count > 0)
            {
                DeleteElementForm deleteElement = new DeleteElementForm(elements,element);//stworzenie nowego formularza typu AddElement z przekazywana referencja na liste studentow
                deleteElement.ShowDialog(this);// wyswietlenie go jako okno dialogowe
                foreach (MyListViewItem viewItem in listViewItem)
                {
                    if (viewItem.element == deleteElement.element1)
                    {
                        listViewItem.Remove(viewItem);
                        break;
                    }
                }
                foreach (MyListViewItem viewItem in listViewItem)
                {
                    viewItem.ImageKey = viewItem.element.ID.ToString();
                }
                    fileOperations.Update(elements);
                Update();
                deleteElement.Dispose();//zwolnienie pamieci
            }
            else
            {
                MessageBox.Show("Nie ma elementow do usuwania", "Brak elementow", MessageBoxButtons.OK);
            }
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            SearchByForm deleteElement = new SearchByForm(elements,listViewItem);//stworzenie nowego formularza typu AddElement z przekazywana referencja na liste studentow
            deleteElement.ShowDialog(this);// wyswietlenie go jako okno dialogowe
            deleteElement.Dispose();//zwolnienie pamieci
        }

        private void Sort_Button_Click(object sender, EventArgs e)
        {
            SortByForm deleteElement = new SortByForm(listViewItem);//stworzenie nowego formularza typu AddElement z przekazywana referencja na liste studentow
            deleteElement.ShowDialog(this);// wyswietlenie go jako okno dialogowe
            deleteElement.Dispose();//zwolnienie pamieci
           //Update(elements);
        }

        private void PhotoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in PhotoList.SelectedItems)
            {
                element = search.FindByID(item.ImageKey);
            }
            SelectElement(element);
        }

        private void PhotoList_DoubleClick(object sender, EventArgs e)
        {
            foreach (ListViewItem item in PhotoList.SelectedItems)
            {
                element = search.FindByID(item.ImageKey);
            }
            SelectElement(element);
            if (element != null && !element.ExtraAttributes["Lokacja pliku"].Equals(""))
                fileOperations.Open(element.ExtraAttributes["Lokacja pliku"]); 
        }
        public new void Update()
        {
            foreach (ListViewItem listViewitems in Details_ListView.Items)
                Details_ListView.Items.Remove(listViewitems);
            PhotoList.BeginUpdate();
            PhotoList.Items.Clear();
            ImageList.Images.Clear();
            foreach (Element element in elements)
            {
                ImageList.Images.Add(element.ID.ToString(), element.Image);
            }
            PhotoList.Items.AddRange(listViewItem.ToArray());
            PhotoList.EndUpdate();
        }
        public void SelectElement(Element element)
        {
            foreach (ListViewItem listViewitems in Details_ListView.Items)
                Details_ListView.Items.Remove(listViewitems);

            foreach (ListViewItem listView in PhotoList.SelectedItems)
            {
                Details_ListView.Items.Add(new ListViewItem(new string[] { "Typ elementu", element.ElementType }));
                foreach (KeyValuePair<string, string> pairs in element.ExtraAttributes)
                {
                    Details_ListView.Items.Add(new ListViewItem(new string[] { pairs.Key, pairs.Value }));
                }
            }
        }

        private void Show_All_Click(object sender, EventArgs e)
        {
            listViewItem.Clear();
            foreach (Element element in elements)
            {
                listViewItem.Add(new MyListViewItem(element));
            }
            Update();
        }
    }
}
