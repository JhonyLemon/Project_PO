using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_Project
{
    /// <summary>
    /// Base class
    /// Contains methods that can be used on any elements of the list
    /// </summary>
    /// <remarks>
    /// This class can search by: name, type
    /// </remarks>
    public class SearchBy
    {
        /// <summary>
        /// List of type IElement
        /// </summary>
        protected List<Element> elements;
        private Element foundElements;

        /// <summary>
        /// SearchBy constructor
        /// </summary>
        public SearchBy(List<Element> elements)
        {
            this.elements = elements;
        }

        /// <summary>
        /// Method that searches for specific name
        /// </summary>
        /// <returns>
        /// Returns a List of IElement type
        /// </returns>
        /// <param name="name">string</param>
        public bool FindByAttribute(string name,string value ,Element element)
        {
            string s="";
            if(element.ExtraAttributes.TryGetValue(name,out s) && s.Contains(value))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Method that searches for specific ID
        /// </summary>
        /// <returns>
        /// Returns a List of IElement type
        /// </returns>
        /// <param name="ID">string</param>
        public Element FindByID(string ID)
        {
            foreach (Element element in elements)
            {
                        if(element.ID==Int32.Parse(ID))
                        return element;
            }
            return null;
        }

        public bool FindByType(string Type, Element element)
        {
            if (element.ElementType == Type)
                return true;
            return false;
        }
    }
}
