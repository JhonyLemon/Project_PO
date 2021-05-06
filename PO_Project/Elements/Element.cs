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
            //ExtraAttributes.Add("Nazwa", name);
            //ExtraAttributes.Add("Autor", author);
            //ExtraAttributes.Add("Opis", description);
            //ExtraAttributes.Add("Lokacja pliku", fileLocation);
            //ExtraAttributes.Add("Lokacja zdjecia", photoLocation);
            //foreach (KeyValuePair<string, string> pair in extraAttributes)
            //    ExtraAttributes.Add(pair.Key, pair.Value);
            if (ExtraAttributes.ContainsKey("Lokacja zdjecia"))
                {
                if (ExtraAttributes["Lokacja zdjecia"] == "")
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
                    Image = Image.FromFile(ExtraAttributes["Lokacja zdjecia"]);
            }
        }
        public string ElementType { get; set; }
        public int ID { get; set; }
        public Image Image { get; set; }
        public Dictionary<string,string> ExtraAttributes { get; set; }


    }
}
