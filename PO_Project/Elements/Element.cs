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
        public Element(string elementType, int ID, Dictionary<string, string> extraAttributes)
        {
            this.ElementType = elementType;
            this.ID = ID;
            ExtraAttributes = extraAttributes;
            if (ExtraAttributes.ContainsKey("Lokacja zdjecia"))
            {
                if (ExtraAttributes["Lokacja zdjecia"] == "")
                {

                    if (this.ElementType == TypeOfElement.Film.ToString())
                        Image = Properties.Resources.FilmImage;
                    else if (this.ElementType == TypeOfElement.Ksiazka.ToString())
                        Image = Properties.Resources.BookImage;
                    else if (this.ElementType == TypeOfElement.Muzyka.ToString())
                        Image = Properties.Resources.MusicImage;
                    else
                        Image = Properties.Resources.PhotoNotFound;
                }
                else
                    Image = Image.FromFile(ExtraAttributes["Lokacja zdjecia"]);
            }
        }
        public string ElementType { get; set; }
        public int ID { get; set; }
        public Image Image { get; set; }
        public Dictionary<string,string> ExtraAttributes { get; set; }

        public void AddImage(string path)
        {
            if (ExtraAttributes.ContainsKey("Lokacja zdjecia"))
            {
                if (path=="")
                {

                    if (this.ElementType == TypeOfElement.Film.ToString())
                        Image = Properties.Resources.FilmImage;
                    else if (this.ElementType == TypeOfElement.Ksiazka.ToString())
                        Image = Properties.Resources.BookImage;
                    else if (this.ElementType == TypeOfElement.Muzyka.ToString())
                        Image = Properties.Resources.MusicImage;
                    else
                        Image = Properties.Resources.PhotoNotFound;
                }
                else
                    Image = Image.FromFile(path);
            }
        }


    }
}
