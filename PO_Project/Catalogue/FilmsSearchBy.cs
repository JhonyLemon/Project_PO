using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_Project
{
    class FilmsSearchBy : SearchBy
    {
        public FilmsSearchBy(List<IElement> elements) : base(elements) { }

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
