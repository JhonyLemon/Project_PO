using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_Project
{
    class Film : IElement
    {
        public string Name { get; set; }
        public Category Category { get; set; }
        public Dictionary<string, byte> Rating { get; set; }
        public string[] Describtion { get; set; }
        public string[] Directed_by { get; set; }
        public string[] Produced_by { get; set; }
        public string[] Written_by { get; set; }
        public TimeSpan Running_time { get; set; }
        public string filelocation { get; set; }
        public bool defaultpath { get; set; }
        public string photo_location { get; set; }
        DateTime Release_date { get; set; }

    }
}
