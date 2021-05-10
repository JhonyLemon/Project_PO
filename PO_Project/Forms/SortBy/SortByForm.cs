using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PO_Project
{
    public partial class SortByForm : Form
    {
        List<MyListViewItem> items;
        Dictionary<int, string> bindDic = new Dictionary<int, string>();
        public SortByForm()
        {
            InitializeComponent();
        }
        public SortByForm(List<MyListViewItem> list)
        {
            InitializeComponent();
            items = list;
            bindDic.Add(0, "Sortuj rosnaco po nazwie");
            bindDic.Add(1, "Sortuj malejaco po nazwie");
            bindDic.Add(2, "Sortuj po typie");
            bindDic.Add(3, "Sortuj rosnaco po autorze");
            bindDic.Add(4, "Sortuj malejaco po autorze");
            bindDic.Add(10, "Sortuj po id");
            SortByComboBox.DataSource = new BindingSource(bindDic, null);
            SortByComboBox.DisplayMember = "Value";
            SortByComboBox.ValueMember = "Key";
        }

        private void SortBySortButton_Click(object sender, EventArgs e)
        {
            switch ((int)SortByComboBox.SelectedValue)
            {
                case 0:
                    {
                        items.Sort(delegate (MyListViewItem x, MyListViewItem y)
                        {
                            if (x.element.ExtraAttributes["Nazwa"] == null && y.element.ExtraAttributes["Nazwa"] == null) return 0;
                            else if (x.element.ExtraAttributes["Nazwa"] == null) return -1;
                            else if (y.element.ExtraAttributes["Nazwa"] == null) return 1;
                            else return x.element.ExtraAttributes["Nazwa"].CompareTo(y.element.ExtraAttributes["Nazwa"]);
                        });
                        break;
                    }
                case 1:
                    {
                        items.Sort(delegate (MyListViewItem x, MyListViewItem y)
                        {
                            if (x.element.ExtraAttributes["Nazwa"] == null && y.element.ExtraAttributes["Nazwa"] == null) return 0;
                            else if (x.element.ExtraAttributes["Nazwa"] == null) return -1;
                            else if (y.element.ExtraAttributes["Nazwa"] == null) return 1;
                            else return y.element.ExtraAttributes["Nazwa"].CompareTo(x.element.ExtraAttributes["Nazwa"]);
                        });
                        break;
                    }
                case 2:
                    {
                        items.Sort(delegate (MyListViewItem x, MyListViewItem y)
                        {
                            if (x.element.ElementType == null && y.element.ElementType == null) return 0;
                            else if (x.element.ElementType == null) return -1;
                            else if (y.element.ElementType == null) return 1;
                            else return x.element.ElementType.CompareTo(y.element.ElementType);
                        });
                        break;
                    }
                case 3:
                    {
                        items.Sort(delegate (MyListViewItem x, MyListViewItem y)
                        {
                            if (x.element.ExtraAttributes["Autor"] == null && y.element.ExtraAttributes["Autor"] == null) return 0;
                            else if (x.element.ExtraAttributes["Autor"] == null) return -1;
                            else if (y.element.ExtraAttributes["Autor"] == null) return 1;
                            else return x.element.ExtraAttributes["Autor"].CompareTo(y.element.ExtraAttributes["Autor"]);
                        });
                        break;
                    }
                case 4:
                    {
                        items.Sort(delegate (MyListViewItem x, MyListViewItem y)
                        {
                            if (x.element.ExtraAttributes["Autor"] == null && y.element.ExtraAttributes["Autor"] == null) return 0;
                            else if (x.element.ExtraAttributes["Autor"] == null) return -1;
                            else if (y.element.ExtraAttributes["Autor"] == null) return 1;
                            else return y.element.ExtraAttributes["Autor"].CompareTo(x.element.ExtraAttributes["Autor"]);
                        });
                        break;
                    }
                case 10:
                    {
                        items.Sort();
                        break;
                    }
            }
            (Owner as MainForm).Update();
            //Close();
        }

        private void SortByCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SortByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
