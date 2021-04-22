using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_Project
{
    /// <summary>
    /// IDataWriter interface
    /// Contains methods used by class DataWriter
    /// </summary>
    interface IDataWriter
    {
        /// <summary>
        /// Loads changes into file
        /// </summary>
        bool Update(List<Element> element);
        /// <summary>
        /// Add new element at the end of the file
        /// </summary>
        Element AddElement(Element element);
    }
}
