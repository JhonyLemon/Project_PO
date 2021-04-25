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


        int ID { get; set; }

        Dictionary<string, string> ExtraAttributes { get; set; }


    }
}
