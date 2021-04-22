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
    class SearchBy
    {
        /// <summary>
        /// List of type IElement
        /// </summary>
        protected List<Element> elements;

        /// <summary>
        /// SearchBy constructor
        /// </summary>
        public SearchBy(List<Element> elements)
        {
            this.elements = elements;
        }

        /// <summary>
        /// Method that searches for specific element type
        /// </summary>
        /// <returns>
        /// Returns a List of IElement type
        /// </returns>
        /// <param name="elementType">enum</param>
        public List<Element> FindByElementType(TypeOfElement elementType)
        {
            List<Element> foundElements = new List<Element>();
            foreach (Element element in elements)
            {
                            if (element.ElementType==elementType.ToString())
                                foundElements.Add(element); 
            }
            return foundElements;
        }

        /// <summary>
        /// Method that searches for specific name
        /// </summary>
        /// <returns>
        /// Returns a List of IElement type
        /// </returns>
        /// <param name="name">string</param>
        public List<IElement> FindByName(string name)
        {
            List<IElement> foundElements = new List<IElement>();
            foreach (IElement element in elements)
            {
                if (element.Name == name)
                {
                    foundElements.Add(element);
                }
            }
            return foundElements;
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

        public List<Element> FindByCategory(Category category)
        {
            List<Element> foundElements = new List<Element>();
            foreach (Element element in elements)
            {

            }
            return foundElements;
        }
    }
}
