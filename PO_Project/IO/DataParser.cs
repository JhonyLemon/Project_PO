using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
        protected Element element;
        protected string defaultlocation = @"C:\Users\" + Environment.UserName + @"\Documents\FilmLibrary";
        protected StringBuilder stringBuilder;

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
        public string FromElementToString(Element element)
        {
                stringBuilder = new StringBuilder(element.ElementType + ";" + element.Name + ";" + element.FileLocation + ";" + element.PhotoLocation + ";" + element.ID.ToString() + ";"+ element.Author + ";" + element.Description + ";" + element.ExtraAttributes.ToString());
            return stringBuilder.ToString();

        }
        /// <summary>
        /// Method parse string to IElement
        /// </summary>
        /// <returns>
        /// Returns IElement
        /// </returns>
        /// <param name="s">string</param>
        public Element FromStringToElement(string s)
        {
            string[] vs = s.Split(';');
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            // DateTime dateTime;
            // DateTime.TryParse(vs[7], out dateTime);
            // TimeSpan timeSpan;
            // TimeSpan.TryParse(vs[4], out timeSpan);
            // Category category;
            // Enum.TryParse(vs[2], out category);
            int id;
            Int32.TryParse(vs[4], out id);
            for(int i=7; i<vs.Length; i++)
            {
                if ((i + 1) < vs.Length)
                {
                    pairs.Add(vs[i], vs[i + 1]);
                }
            }
                        element = new Element(vs[0],vs[1],vs[2],vs[3],id,vs[5],vs[6],pairs);
            return element;
        }

    }
}
