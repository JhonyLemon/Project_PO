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
        protected IElement element;
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
        public string FromElementToString(IElement element)
        {
            string s="";
            for (int i=11; i< element.GetType().ToString().Length; i++)
            {
                s += element.GetType().ToString()[i];
            }
            if (s == "Film")
            {
                stringBuilder = new StringBuilder(s + ";" + (element as Film).Name + ";" + (element as Film).Category.ToString() + ";" + (element as Film).Description + ";" + (element as Film).Length.ToString() + ";" + (element as Film).FileLocation + ";" + (element as Film).PhotoID + ";" + (element as Film).ReleaseDate.ToString() + ";" + (element as Film).Author);
            }
            else if(s=="Book")
            {
                stringBuilder = new StringBuilder(s + ";" + (element as Book).Name + ";" + (element as Book).Description + ";" + (element as Book).FileLocation + ";" + (element as Book).PhotoID + ";" + (element as Book).Author);

            }
            else if(s=="Music")
            {
                stringBuilder = new StringBuilder(s + ";" + (element as Music).Name + ";" + (element as Music).Description + ";" + (element as Music).FileLocation + ";" + (element as Music).PhotoID + ";" + (element as Music).Author);
            }
            return stringBuilder.ToString();

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
            string[] vs = s.Split(';');
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
                        element = new Film(vs[1], category, vs[3], timeSpan, vs[5], vs[6], dateTime,vs[8]);
                        break;
                    }
                case "Book":
                    {
                        element = new Book(vs[1], vs[2],vs[3],vs[4],vs[5]);
                        break;
                    }
                case "Music":
                    {
                        element = new Music(vs[1], vs[2], vs[3], vs[4], vs[5]);
                        break;
                    }
            }
            return element;
        }

        /// <summary>
        /// Method parse PhotoData to string
        /// </summary>
        /// <returns>
        /// Returns a string
        /// </returns>
        /// <param name="photo">PhotoData</param>
        public string FromPhotoDataToString(PhotoData photo)
        {
            stringBuilder = new StringBuilder(photo.PhotoID+";"+photo.Location);
            return stringBuilder.ToString();
        }
        /// <summary>
        /// Method parse string to PhotoData
        /// </summary>
        /// <returns>
        /// Returns PhotoData
        /// </returns>
        /// <param name="s">string</param>
        public PhotoData FromStringToPhotoData(string s)
        {
            string[] vs = s.Split(';');
            if (File.Exists(vs[1])==false)
            {
                vs[1] = "";
            }
            return new PhotoData(vs[0], vs[1]);
        }
    }
}
