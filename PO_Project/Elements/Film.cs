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
        public Film(string name, Category category, string describtion, TimeSpan running_time, string filelocation, string photo_location, DateTime release_date,string Author)
        {
            Name = name;
            Category = category;
            Description = describtion;
            Length = running_time;
            this.FileLocation = filelocation;
            this.PhotoID = photo_location;
            ReleaseDate = release_date;
            this.Author = Author;
        }

        /// <value>Gets or Sets name of the film.</value>
        public string Name { get; set; }
        /// <value>Gets or Sets the film category.</value>
        public Category Category { get; set; }
        /// <value>Gets or Sets describtion of the film.</value>
        public string Description { get; set; }
        /// <value>Gets or Sets film lenght.</value>
        public TimeSpan Length { get; set; }
        /// <value>Gets or Sets the film location.</value>
        public string FileLocation { get; set; }
        /// <value>Gets or Sets the phto/cover ID.</value>
        public string PhotoID { get; set; }
        /// <value>Gets or Sets the release date of the film.</value>
        public DateTime ReleaseDate { get; set; }
        /// <value>Gets or Sets the Author of the film.</value>
        public string Author { get; set; }
    }
}
