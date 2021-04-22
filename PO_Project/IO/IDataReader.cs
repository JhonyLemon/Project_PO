using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_Project
{
    /// <summary>
    /// IDataReader interface
    /// Contains methods used by class DataReader
    /// </summary>
    interface IDataReader
    {
        /// <summary>
        /// Read file
        /// </summary>
        List<Element> ReadElements();

    }
}
