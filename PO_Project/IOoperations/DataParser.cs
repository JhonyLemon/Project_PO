using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_Project
{
    /// <summary>
    /// Base class DataParser
    /// Contains methods that can be used to convert: IElement to string,string to IElement
    /// </summary>
    /// <remarks>
    /// This class changes variable type
    /// </remarks>
    class DataParser
    {
        protected IElement Element;
        protected string defaultlocation = @"C:\Users\" + Environment.UserName + @"\Documents\FilmLibrary";
        protected StringBuilder StringBuilder;

        public DataParser()
        {

        }

        /// <summary>
        /// Method parse IElement to string
        /// </summary>
        /// <returns>
        /// Returns a string
        /// </returns>
        /// <param name="element">IElement</param>
        public string FromElementToString(IElement element)
        {
            string s="";
            for (int i=11; i< element.GetType().ToString().Length; i++)
            {
                s += element.GetType().ToString()[i];
            }
            StringBuilder = new StringBuilder( s+ "," + (element as Film).Name + "," + (element as Film).Category.ToString() + "," + (element as Film).Description + "," + (element as Film).Running_time.ToString() + "," + (element as Film).filelocation + "," + (element as Film).photo_location + "," + (element as Film).Release_date.ToString() + ",") ;
                return StringBuilder.ToString();

        }
        /// <summary>
        /// Method parse string to IElement
        /// </summary>
        /// <returns>
        /// Returns IElement
        /// </returns>
        /// <param name="s">string</param>
        public IElement FromStringToElement(string s)
        {
            string[] vs = s.Split(',');
            switch (vs[0])
            {
                case "Film":
                    {
                        DateTime dateTime;
                        DateTime.TryParse(vs[7], out dateTime);
                        TimeSpan timeSpan;
                        TimeSpan.TryParse(vs[4], out timeSpan);
                        Category category;
                        Enum.TryParse(vs[2], out category);
                        Element = new Film(vs[1], category, vs[3], timeSpan, vs[5], vs[6], dateTime);
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
            return Element;
        }
    }
}
