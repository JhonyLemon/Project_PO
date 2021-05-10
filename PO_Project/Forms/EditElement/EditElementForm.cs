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
    public partial class EditElementForm : Form, IObserver
    {
        List<Element> elements;
        Dictionary<int, string> Names= new Dictionary<int, string>();
        Element element;
        SearchBy search;
        public EditElementForm()
        {
            InitializeComponent();
        }
        public EditElementForm(List<Element> elements)
        {
            InitializeComponent();
            foreach(Element element in elements)
            {
                Names.Add(element.ID, element.ExtraAttributes["Nazwa"]);
            }
            this.EditElement_ComboBox.SelectionChangeCommitted += EditElement_ComboBox_SelectionChangeCommitted;
            this.elements = elements;
            search = new SearchBy(elements);
            EditElement_ComboBox.DataSource = new BindingSource(Names, null);
            EditElement_ComboBox.DisplayMember = "Value";
            EditElement_ComboBox.ValueMember = "Key";
        }
        public EditElementForm(List<Element> elements,Element eleme)
        {
            InitializeComponent();
            this.element = eleme;
            foreach (Element element in elements)
            {
                Names.Add(element.ID, element.ExtraAttributes["Nazwa"]);
            }
            this.EditElement_ComboBox.SelectionChangeCommitted += EditElement_ComboBox_SelectionChangeCommitted;
            this.elements = elements;
            search = new SearchBy(elements);
            EditElement_ComboBox.DataSource = new BindingSource(Names, null);
            EditElement_ComboBox.DisplayMember = "Value";
            EditElement_ComboBox.ValueMember = "Key";
            EditElement_ComboBox.SelectedValue = element.ID;
            EditElement_ComboBox_SelectionChangeCommitted(this, null);
        }

        private void EditElement_ComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foreach (ListViewItem listViewitems in EditElement_ListView.Items)
                EditElement_ListView.Items.Remove(listViewitems);

            element = search.FindByID(EditElement_ComboBox.SelectedValue.ToString());

              foreach (KeyValuePair<string,string> pair in element.ExtraAttributes)
                 EditElement_ListView.Items.Add(new ListViewItem(new string[] { pair.Key,pair.Value }));
                EditElement_ImageBox.Image = element.Image;

        }

        private void EditElement_Edit_Button_Click(object sender, EventArgs e)
        {

            if (EditElement_ComboBox.SelectedItem != null)
            {
                EditElementDialogForm editElementForm = new EditElementDialogForm(element);//stworzenie nowego formularza typu AddElement z przekazywana referencja na liste studentow
                editElementForm.ShowDialog(this);// wyswietlenie go jako okno dialogowe
                editElementForm.Dispose();//zwolnienie pamieci
                Update();
            }
            (Owner as MainForm).Update();
        }

        private void EditElement_Cancel_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        public new void Update()
        {
            EditElement_ListView.Items.Clear();
            foreach (KeyValuePair<string, string> pair in element.ExtraAttributes)
                EditElement_ListView.Items.Add(new ListViewItem(new string[] { pair.Key, pair.Value }));
            EditElement_ImageBox.Image = element.Image;
        }

        private void EditElement_Add_Button_Click(object sender, EventArgs e)
        {
            AddAttributeDialog addAttributeDialog = new AddAttributeDialog(element.ExtraAttributes);//stworzenie nowego formularza typu AddElement z przekazywana referencja na liste studentow
            addAttributeDialog.ShowDialog(this);// wyswietlenie go jako okno dialogowe
            addAttributeDialog.Dispose();//zwolnienie pamieci
            Update();
            (Owner as MainForm).Update();
        }

        private void EditElement_Delete_Button_Click(object sender, EventArgs e)
        {
            DeleteElementDialog deleteElementDialog = new DeleteElementDialog(element.ExtraAttributes);//stworzenie nowego formularza typu AddElement z przekazywana referencja na liste studentow
            deleteElementDialog.ShowDialog(this);// wyswietlenie go jako okno dialogowe
            deleteElementDialog.Dispose();//zwolnienie pamieci
            Update();
            (Owner as MainForm).Update();
        }
    }
}
