using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PO_Project
{
    public class Element : IElement
    {
        public Element(string elementType, string name, string fileLocation, string photoLocation, int ID, string author, string description, Dictionary<string, string> extraAttributes)
        {
            this.ElementType = elementType;
            Name = name;
            FileLocation = fileLocation;
            PhotoLocation = photoLocation;
            this.ID = ID;
            Author = author;
            Description = description;
            ExtraAttributes = extraAttributes;
            if (photoLocation == "")
            {
                if (this.ElementType == TypeOfElement.Film.ToString())
                    Image = Properties.Resources.FilmImage;
                else if (this.ElementType == TypeOfElement.Book.ToString())
                    Image = Properties.Resources.BookImage;
                else if (this.ElementType == TypeOfElement.Music.ToString())
                    Image = Properties.Resources.MusicImage;
                else
                    Image = Properties.Resources.PhotoNotFound;
            }
            else
                Image = Image.FromFile(PhotoLocation);
        }
        public string ElementType { get; set; }
        public string Name { get; set; }
        public string FileLocation { get; set; }
        public string PhotoLocation { get; set; }
        public int ID { get; set; }
        public Image Image { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public Dictionary<string,string> ExtraAttributes { get; set; }
    }
}
