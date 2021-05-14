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
        List<MyListViewItem> items;//lista listviewitem
        Dictionary<int, string> bindDic = new Dictionary<int, string>();//slownik uzywany do bindowania comboboxa
        public SortByForm()
        {
            InitializeComponent();//inicjalizacja kontrolek
        }
        public SortByForm(List<MyListViewItem> list)
        {
            InitializeComponent();//inicjalizacja kontrolek
            items = list;//przypisanie argumentu do zmiennej
            bindDic.Add(0, "Sortuj rosnaco po nazwie");//dodanie elementow do slownika
            bindDic.Add(1, "Sortuj malejaco po nazwie");
            bindDic.Add(2, "Sortuj po typie");
            bindDic.Add(3, "Sortuj rosnaco po autorze");
            bindDic.Add(4, "Sortuj malejaco po autorze");
            bindDic.Add(10, "Sortuj po id");
            SortByComboBox.DataSource = new BindingSource(bindDic, null);//bindowanie slownika do combobox-a
            SortByComboBox.DisplayMember = "Value";//wartosc wyswietlana jest wartoscia elementu slownika
            SortByComboBox.ValueMember = "Key";//wartosc wybranego elementu bedzie kluczem slownika
        }

        private void SortBySortButton_Click(object sender, EventArgs e)
        {
            switch ((int)SortByComboBox.SelectedValue)//sprawdzenie wybranego elementu
            {
                case 0://Sortuj rosnaco po nazwie
                    {
                        items.Sort(delegate (MyListViewItem x, MyListViewItem y)//uzycie metody Sort, zwyrazeniem lambda aby zmienic element przez ktory sortujemy
                        {
                            if (x.element.ExtraAttributes["Nazwa"] == null && y.element.ExtraAttributes["Nazwa"] == null) //jesli elementy sa nullami 
                                return 0;//zwroc zero
                            else if (x.element.ExtraAttributes["Nazwa"] == null) return -1;//jesli jeden z elementow jest nullem zwroc -1
                            else if (y.element.ExtraAttributes["Nazwa"] == null) return 1;
                            else return x.element.ExtraAttributes["Nazwa"].CompareTo(y.element.ExtraAttributes["Nazwa"]);//porownaj elementy
                        });
                        break;
                    }
                case 1://Sortuj malejaco po nazwie
                    {
                        items.Sort(delegate (MyListViewItem x, MyListViewItem y)//uzycie metody Sort, zwyrazeniem lambda aby zmienic element przez ktory sortujemy
                        {
                            if (x.element.ExtraAttributes["Nazwa"] == null && y.element.ExtraAttributes["Nazwa"] == null) //jesli elementy sa nullami
                                return 0;//zwroc zero
                            else if (x.element.ExtraAttributes["Nazwa"] == null) return -1;//jesli jeden z elementow jest nullem zwroc -1
                            else if (y.element.ExtraAttributes["Nazwa"] == null) return 1;
                            else return y.element.ExtraAttributes["Nazwa"].CompareTo(x.element.ExtraAttributes["Nazwa"]);//porownaj elementy
                        });
                        break;
                    }
                case 2://Sortuj po typie
                    {
                        items.Sort(delegate (MyListViewItem x, MyListViewItem y)//uzycie metody Sort, zwyrazeniem lambda aby zmienic element przez ktory sortujemy
                        {
                            if (x.element.ElementType == null && y.element.ElementType == null) //jesli elementy sa nullami
                                return 0;//zwroc zero
                            else if (x.element.ElementType == null) return -1;//jesli jeden z elementow jest nullem zwroc -1
                            else if (y.element.ElementType == null) return 1;
                            else return x.element.ElementType.CompareTo(y.element.ElementType);//porownaj elementy
                        });
                        break;
                    }
                case 3://Sortuj rosnaco po autorze
                    {
                        items.Sort(delegate (MyListViewItem x, MyListViewItem y)//uzycie metody Sort, zwyrazeniem lambda aby zmienic element przez ktory sortujemy
                        {
                            if (x.element.ExtraAttributes["Autor"] == null && y.element.ExtraAttributes["Autor"] == null) //jesli elementy sa nullami
                                return 0;//zwroc zero
                            else if (x.element.ExtraAttributes["Autor"] == null) return -1;//jesli jeden z elementow jest nullem zwroc -1
                            else if (y.element.ExtraAttributes["Autor"] == null) return 1;
                            else return x.element.ExtraAttributes["Autor"].CompareTo(y.element.ExtraAttributes["Autor"]);//porownaj elementy
                        });
                        break;
                    }
                case 4://Sortuj malejaco po autorze
                    {
                        items.Sort(delegate (MyListViewItem x, MyListViewItem y)//uzycie metody Sort, zwyrazeniem lambda aby zmienic element przez ktory sortujemy
                        {
                            if (x.element.ExtraAttributes["Autor"] == null && y.element.ExtraAttributes["Autor"] == null) //jesli elementy sa nullami
                                return 0;//zwroc zero
                            else if (x.element.ExtraAttributes["Autor"] == null) return -1;//jesli jeden z elementow jest nullem zwroc -1
                            else if (y.element.ExtraAttributes["Autor"] == null) return 1;
                            else return y.element.ExtraAttributes["Autor"].CompareTo(x.element.ExtraAttributes["Autor"]);//porownaj elementy
                        });
                        break;
                    }
                case 10://Sortuj po id
                    {
                        items.Sort();//sortowanie domyslne
                        break;
                    }
            }
            (Owner as MainForm).observable.Notify();//odswiezenie listview w formularzu glownym
        }

        private void SortByCancelButton_Click(object sender, EventArgs e)
        {
            Close();//zamkniecie fomrularza
        }

        private void SortByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
