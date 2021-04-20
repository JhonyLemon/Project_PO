using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PO_Project
{
    class PhotoData
    {
        public PhotoData(string photoId, string location)
        {
            PhotoID = photoId;
            Location = location;
            if(location!="")
            Photo = Image.FromFile(location);
        }

        public string PhotoID { get; set; }
        public string Location { get; set; }
        public Image Photo { get; set; }
    }
}
