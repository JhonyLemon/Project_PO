using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_Project
{
    class Music : IElement
    {
        public Music(string name, string description, string filelocation, string photoID, string author)
        {
            Name = name;
            this.FileLocation = filelocation;
            PhotoID = photoID;
            Description = description;
            Author = author;
        }

        /// <value>Gets or Sets name of the film.</value>
        public string Name { get; set; }
        /// <value>Gets or Sets the film location.</value>
        public string FileLocation { get; set; }
        public string PhotoID { get; set; }
        /// <value>Gets or Sets describtion of the film.</value>
        public string Description { get; set; }
        /// <value>Gets or Sets the Author of the film.</value>
        public string Author { get; set; }
    }
}
