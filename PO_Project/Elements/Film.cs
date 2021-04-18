using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_Project
{
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

        public string Name { get; set; }
        public Category Category { get; set; }
        public string Describtion { get; set; }
        public TimeSpan Running_time { get; set; }
        public string filelocation { get; set; }
        public string photo_location { get; set; }
        public DateTime Release_date { get; set; }

    }
}
