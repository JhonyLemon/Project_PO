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
        List<Element> elements = new List<Element>();//lista z elementami 
        Element element;//wybrany element
        DataIO fileOperations;//zmienna z klasa do operacji na plikach
        public SearchBy search;//zmienna do szukania
        List<MyListViewItem> listViewItem = new List<MyListViewItem>();
        public Observable observable = new Observable();
        /// <summary>
        /// MainForm constructor
        /// Initializes form components and read file with data
        /// </summary>
        public MainForm()
        {
            InitializeComponent();//inicjalizacja kompotentow formularza
            fileOperations = DataIO.GetInstance();//odebranie instancji klasy DataIO
            elements = fileOperations.ReadElements();//zczytanie elementow z pliku
            search = new SearchBy(elements);//inicjalizacja klasy potrzebnej do wyszukiwania danych
            foreach(Element element in elements)
            {
                listViewItem.Add(new MyListViewItem(element));//dodanie elementow do rozszerzonej klasy listviewitem
            }
            observable.Attach(this);
            Update();//zaladowanie elementow do listview
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            AddElementForm AddElement = new AddElementForm(elements);//stworzenie instancji formularza AddElementForm
            observable.Attach(AddElement);
            AddElement.ShowDialog(this);//wyswietlenie go jako okno dialogowe
             
            if (AddElement.element != null && AddElement.element.ID != 0)//jesli element zostal dodany
            {
                fileOperations.Update(elements);//uaktualnienie zawartosci pliku
                listViewItem.Add(new MyListViewItem(AddElement.element));//dodanie nowego elementu do listviewitem
            }
            Update();//zaladowanie elementow do listview
            observable.Detach(AddElement);
            AddElement.Dispose();//zwolnienie pamieci dla formularza AddElement
        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            if (PhotoList.SelectedItems.Count!=0 && elements.Count>0)//jesli wybrano element
            {
                EditElementForm editElementForm = new EditElementForm(elements,element);//stworzenie nowego formularza typu EditElementForm
                observable.Attach(editElementForm);
                editElementForm.ShowDialog(this);// wyswietlenie go jako okno dialogowe
                observable.Detach(editElementForm);
                editElementForm.Dispose();//zwolnienie pamieci
                fileOperations.Update(elements);//uaktualnienie zawartosci pliku
            }
            else if(elements.Count > 0)//jesli nie wybrano elementu
            {
                EditElementForm editElementForm = new EditElementForm(elements);//stworzenie nowego formularza typu AddElement z przekazywana referencja na liste studentow
                observable.Attach(editElementForm);
                editElementForm.ShowDialog(this);// wyswietlenie go jako okno dialogowe
                observable.Detach(editElementForm);
                editElementForm.Dispose();//zwolnienie pamieci
                fileOperations.Update(elements);//uaktualnienie zawartosci pliku
            }
            else
            {
                MessageBox.Show("Nie ma elementow do edycji", "Brak elementow", MessageBoxButtons.OK);//wyswietlenie okna z wiadomoscia bledu
            }
        }
        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (PhotoList.SelectedItems.Count == 0 && elements.Count>0)//jesli zaden element nie jest wybrany
            {
                DeleteElementForm deleteElement = new DeleteElementForm(elements);//stworzenie nowego formularza typu DeleteElementForm
                deleteElement.ShowDialog(this);// wyswietlenie go jako okno dialogowe
                foreach (MyListViewItem viewItem in listViewItem)
                {
                    if (viewItem.element == deleteElement.element1)//sprawdzenie czy element rowna sie usunietemu
                    {
                        listViewItem.Remove(viewItem);//usuniecie z listviewitem 
                        break;
                    }
                }
                foreach (MyListViewItem viewItem in listViewItem)
                {
                    viewItem.ImageKey = viewItem.element.ID.ToString();//aktualizacja ID obrazkow
                }
                fileOperations.Update(elements);//uaktualnienie zawartosci pliku
                observable.Notify();//zaladowanie elementow do listview
                deleteElement.Dispose();//zwolnienie pamieci
            }
            else if(elements.Count > 0)//jesli wybrano element
            {
                DeleteElementForm deleteElement = new DeleteElementForm(elements,element);//stworzenie nowego formularza typu AddElement z przekazywana referencja na liste studentow
                deleteElement.ShowDialog(this);// wyswietlenie go jako okno dialogowe
                foreach (MyListViewItem viewItem in listViewItem)
                {
                    if (viewItem.element == deleteElement.element1)//sprawdzenie czy element rowna sie usunietemu
                    {
                        listViewItem.Remove(viewItem);//usuniecie z listviewitem 
                        break;
                    }
                }
                foreach (MyListViewItem viewItem in listViewItem)
                {
                    viewItem.ImageKey = viewItem.element.ID.ToString();//aktualizacja ID obrazkow
                }
                fileOperations.Update(elements);//uaktualnienie zawartosci pliku
                observable.Notify();//zaladowanie elementow do listview
                deleteElement.Dispose();//zwolnienie pamieci
            }
            else
            {
                MessageBox.Show("Nie ma elementow do usuwania", "Brak elementow", MessageBoxButtons.OK);
            }
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            SearchByForm deleteElement = new SearchByForm(elements,listViewItem);//stworzenie nowego formularza typu SearchByForm
            deleteElement.ShowDialog(this);// wyswietlenie go jako okno dialogowe
            deleteElement.Dispose();//zwolnienie pamieci
        }

        private void Sort_Button_Click(object sender, EventArgs e)
        {
            SortByForm deleteElement = new SortByForm(listViewItem);//stworzenie nowego formularza typu SortByForm
            deleteElement.ShowDialog(this);// wyswietlenie go jako okno dialogowe
            deleteElement.Dispose();//zwolnienie pamieci
        }

        private void PhotoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in PhotoList.SelectedItems)
            {
                element = search.FindByID(item.ImageKey);//znalezienie zaznaczonego elementu
            }
            SelectElement(element);//aktualizacja listview z atrybutami
        }

        private void PhotoList_DoubleClick(object sender, EventArgs e)
        {
            foreach (ListViewItem item in PhotoList.SelectedItems)
            {
                element = search.FindByID(item.ImageKey);//znalezienie zaznaczonego elementu
            }
            SelectElement(element);//aktualizacja listview z atrybutami
            if (element != null && !element.ExtraAttributes["Lokacja pliku"].Equals(""))//jesli atrybut z lokacja pliku jest poprawny otwiera plik
                fileOperations.Open(element.ExtraAttributes["Lokacja pliku"]); 
        }
        public new void Update()
        {
            Details_ListView.Items.Clear();//czyszczenie listview z atrybutami
            ImageList.Images.Clear();//czyszczenie listy z obrazkami
            PhotoList.BeginUpdate();
            PhotoList.Items.Clear();//czyszczenie listview z nazwami i obrazkami
            foreach (Element element in elements)
            {
                ImageList.Images.Add(element.ID.ToString(), element.Image);//dodanie obrazkow z ID do listy obrazkow
            }
            PhotoList.Items.AddRange(listViewItem.ToArray());//dodanie listviewitem do listview z obrazkami i nazwami
            PhotoList.EndUpdate();
        }
        public void SelectElement(Element element)
        {
                Details_ListView.Items.Clear();//czyszczenie listview z atrybutami
                Details_ListView.Items.Add(new ListViewItem(new string[] { "Typ elementu", element.ElementType }));//dodanie atrybutu do listview z atrybutami
                foreach (KeyValuePair<string, string> pairs in element.ExtraAttributes)
                {
                    Details_ListView.Items.Add(new ListViewItem(new string[] { pairs.Key, pairs.Value }));//dodanie atrybutow do listview z atrybutami
                }
        }

        private void Show_All_Click(object sender, EventArgs e)
        {
            listViewItem.Clear();//wyczyszczenie listviewitem
            foreach (Element element in elements)
            {
                listViewItem.Add(new MyListViewItem(element));//dodanie elementow na nowo
            }
            Update();//zaladowanie elementow do listview
        }

        private void PhotoList_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            Element hoverElement = search.FindByID(e.Item.ImageKey);
            StringBuilder builder = new StringBuilder("Typ elementu:    " + hoverElement.ElementType + Environment.NewLine);
            foreach (KeyValuePair<string, string> pair in hoverElement.ExtraAttributes)
                builder.Append(pair.Key + ":    " + pair.Value + Environment.NewLine);
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.PhotoList, builder.ToString());
        }
    }
}
