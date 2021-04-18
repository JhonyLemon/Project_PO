using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_Project
{
    /// <summary>
    /// Derived class from base class SearchBy
    /// Contains methods that can be used on Film type elements of the list
    /// </summary>
    /// <remarks>
    /// This class can search by: category
    /// </remarks>
    class FilmsSearchBy : SearchBy
    {
        /// <summary>
        /// FilmSeatchBy constructor
        /// </summary>
        public FilmsSearchBy(List<IElement> elements) : base(elements) { }


        /// <summary>
        /// Method that searches for specific element category
        /// </summary>
        /// <returns>
        /// Returns a List of IElement type
        /// </returns>
        /// <param name="category">enum</param>
        public List<IElement> FindByCategory(Category category)
        {
            List<IElement> foundElements = new List<IElement>();
            foreach (IElement element in elements)
            {
                if ((element as Film).Category == category)
                    foundElements.Add(element);
            }
            return foundElements;
        }
    }
}
