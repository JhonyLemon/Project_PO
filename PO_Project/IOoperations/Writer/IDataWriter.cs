using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_Project
{
    interface IDataWriter
    {
        List<IElement> EditElement();
        List<IElement> DeleteElement();
        IElement AddElement();
    }
}
