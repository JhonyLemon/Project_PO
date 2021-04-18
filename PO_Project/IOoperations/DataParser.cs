using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_Project
{
    class DataParser
    {

        protected string defaultlocation = @"C:\Users\" + Environment.UserName + @"\Documents\FilmLibrary";
        protected StringBuilder StringBuilder;
        protected IElement Element;

        public DataParser()
        {

        }

        public DataParser(IElement element)
        {
            if (element is Film)
            {
                StringBuilder = new StringBuilder(("Film" + "," + (element as Film).Name + "," + (element as Film).Category.ToString() + "," + (element as Film).Describtion + "," + (element as Film).Running_time.ToString() + "," + (element as Film).filelocation + "," + (element as Film).photo_location + "," + (element as Film).Release_date.ToString() + ","));
                Element = element;
            }
        }
        public DataParser(string element, ElementType type)
        {
            string[] vs = element.Split(',');
            switch(vs[0])
            {
                case "Film":
                    {
                        DateTime dateTime;
                        DateTime.TryParse(vs[7], out dateTime);
                        TimeSpan timeSpan;
                        TimeSpan.TryParse(vs[4], out timeSpan);
                        Category category;
                        Enum.TryParse(vs[2], out category);
                        this.Element = new Film(vs[1], category, vs[3], timeSpan, vs[5], vs[6], dateTime);
                        StringBuilder = new StringBuilder(((type.ToString()) + "," + (Element as Film).Name + "," + (Element as Film).Category.ToString() + "," + (Element as Film).Describtion + "," + (Element as Film).Running_time.ToString() + "," + (Element as Film).filelocation + "," + (Element as Film).photo_location + "," + (Element as Film).Release_date.ToString() + ","));
                        break;
                    }
                case "Book":
                    {
                        break;
                    }
                case "Music":
                    {
                        break;
                    }
            }
        }
    }
}
