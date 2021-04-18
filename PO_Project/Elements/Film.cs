using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_Project
{
    /// <summary>
    /// Film class
    /// Contains properties of film element
    /// </summary>
    class Film : IElement
    {
        public Film(string name, Category category, string describtion, TimeSpan running_time, string filelocation, string photo_location, DateTime release_date)
        {
            Name = name;
            Category = category;
            Describtion = describtion;
            Running_time = running_time;
            this.filelocation = filelocation;
            this.photo_location = photo_location;
            Release_date = release_date;
        }

        /// <value>Gets or Sets name of the film.</value>
        public string Name { get; set; }
        /// <value>Gets or Sets the film category.</value>
        public Category Category { get; set; }
        /// <value>Gets or Sets describtion of the film.</value>
        public string Describtion { get; set; }
        /// <value>Gets or Sets film lenght.</value>
        public TimeSpan Running_time { get; set; }
        /// <value>Gets or Sets the film location.</value>
        public string filelocation { get; set; }
        /// <value>Gets or Sets the phto/cover location.</value>
        public string photo_location { get; set; }
        /// <value>Gets or Sets the release date of the film.</value>
        public DateTime Release_date { get; set; }

    }
}
