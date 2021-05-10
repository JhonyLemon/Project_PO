using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PO_Project
{
    public class MyListViewItem :ListViewItem, IEquatable<MyListViewItem>, IComparable<MyListViewItem>
    {
        public Element element;
        public MyListViewItem(Element element)
        {
            this.element = element;
            this.ImageKey = this.element.ID.ToString();
            this.Text = this.element.ExtraAttributes["Nazwa"];
        }
        public int CompareTo(MyListViewItem other)
        {
            if (other == null)
                return 1;

            else
                return this.element.ID.CompareTo(other.element.ID);
        }

        public bool Equals(MyListViewItem other)
        {
            if (other == null)
                return false;
            return (this.element.ID.Equals(other.element.ID));
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            MyListViewItem objAsPart = obj as MyListViewItem;
            if (objAsPart == null) 
                return false;
            else 
                return Equals(objAsPart);
        }
        public int SortByNameAscending(string name1, string name2)
        {

            return name1.CompareTo(name2);
        }

        public override int GetHashCode()
        {
            return element.ID;
        }
    }
}
