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
        protected List<IElement> elements;

        /// <summary>
        /// SearchBy constructor
        /// </summary>
        public SearchBy(List<IElement> elements)
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
        public List<IElement> FindByElementType(ElementType elementType)
        {
            List<IElement> foundElements = new List<IElement>();
            foreach (IElement element in elements)
            {
                switch (elementType)
                {
                    case ElementType.Film:
                        {
                            if (element is Film)
                                foundElements.Add(element);
                            break;
                        }
                }
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
    }
}
