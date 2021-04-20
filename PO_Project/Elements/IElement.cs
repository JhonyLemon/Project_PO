using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_Project
{
    /// <summary>
    /// Element interface
    /// Contains properties used by element
    /// </summary>
    interface IElement
    {
        /// <value>Gets or Sets name of the element.</value>
        string Name { get; set; }
        /// <value>Gets or Sets file location of the element.</value>
        string FileLocation { get; set; }
        /// <value>Gets or Sets photo location of the element.</value>
        string PhotoID { get; set; }
        /// <value>Gets or Sets author of the element.</value>
        string Author { get; set; }
        /// <value>Gets or Sets description of the element.</value>
        string Description { get; set; }

    }
}
