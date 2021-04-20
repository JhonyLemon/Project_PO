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
        List<IElement> elements = new List<IElement>();
        List<PhotoData> photoDatas = new List<PhotoData>();
        DataReader reader = new DataReader();
        DataWriter writer = new DataWriter();
        SearchBy search;
        /// <summary>
        /// MainForm constructor
        /// Initializes form components and read file with data
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            elements = reader.ReadElements();
            photoDatas = reader.ReadPhotoData();
            search = new SearchBy(elements);
           // elements.Add(new Film("Powrot do przeszlosci",Category.Action,"Film o potworach i wrozkach",TimeSpan.FromHours(2),"","1",DateTime.Today,"Bartek"));
           // photoDatas.Add(new PhotoData("1", "C:\\Users\\Adam\\Downloads\\powrot.jpg"));
           // writer.Update(elements);
           // writer.Update(photoDatas);
            foreach (PhotoData photoData in photoDatas)
            {
                if(photoData.Photo==null)
                {
                    IElement temp = search.FindByID(photoData.PhotoID);
                    if (temp is Film)
                    {
                        photoData.Photo = Properties.Resources.FilmImage;
                    }
                    else if (temp is Book)
                    {
                        photoData.Photo = Properties.Resources.BookImage;
                    }
                    else if (temp is Music)
                    {
                        photoData.Photo = Properties.Resources.MusicImage;
                    }
                }
                ImageList.Images.Add(photoData.PhotoID,photoData.Photo);
            }
            foreach (IElement element in elements)
            {
               var ListViewItem = PhotoList.Items.Add(element.Name, element.PhotoID);
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
         
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            elements.RemoveAt(0);
            writer.Update(elements);
            foreach (ListViewItem listView in PhotoList.SelectedItems)
            {
                elements.Remove(search.FindByID(listView.ImageKey));
            }
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
            IElement element;
            PhotoList.Select();
            foreach(ListViewItem listView in PhotoList.SelectedItems)
            {
                element = search.FindByID(listView.ImageKey);
                Name_Dynamic.Text = element.Name;
                Author_Dynamic.Text = element.Author;
                FileLocation_Dynamic.Text = element.FileLocation;
                Description_Dynamic.Text = element.Description;
                if(element is Film)
                {
                    Category_Dynamic.Text = (element as Film).Category.ToString();
                    Length_Dynamic.Text = (element as Film).Length.ToString();
                    ReleaseDate_Dynamic.Text=(element as Film).ReleaseDate.ToString();
                    FileLocation_Dynamic.Text = (element as Film).FileLocation;

                }
                else if (element is Book)
                {

                }
                else if (element is Music)
                {

                }

            }


            
        }
    }
}
