using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_Project
{
    class SearchBy
    {
        protected List<IElement> elements;

        public SearchBy(List<IElement> elements)
        {
            this.elements = elements;
        }
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
