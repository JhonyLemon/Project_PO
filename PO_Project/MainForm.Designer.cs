
namespace PO_Project
{
    /// <summary>
    /// Main form class
    /// Contains declarations of controls
    /// </summary>
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.Add_Button = new System.Windows.Forms.MenuItem();
            this.Edit_Button = new System.Windows.Forms.MenuItem();
            this.Delete_Button = new System.Windows.Forms.MenuItem();
            this.Search_Button = new System.Windows.Forms.MenuItem();
            this.Sort_Button = new System.Windows.Forms.MenuItem();
            this.ShowAllButton = new System.Windows.Forms.MenuItem();
            this.Podwojny_Kontener = new System.Windows.Forms.SplitContainer();
            this.PhotoList = new System.Windows.Forms.ListView();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.Details_ListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.Podwojny_Kontener)).BeginInit();
            this.Podwojny_Kontener.Panel1.SuspendLayout();
            this.Podwojny_Kontener.Panel2.SuspendLayout();
            this.Podwojny_Kontener.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.Search_Button,
            this.Sort_Button,
            this.ShowAllButton});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Add_Button,
            this.Edit_Button,
            this.Delete_Button});
            this.menuItem1.Text = "Edycja";
            // 
            // Add_Button
            // 
            this.Add_Button.Index = 0;
            this.Add_Button.Text = "Dodaj";
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Edit_Button
            // 
            this.Edit_Button.Index = 1;
            this.Edit_Button.Text = "Edytuj";
            this.Edit_Button.Click += new System.EventHandler(this.Edit_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Index = 2;
            this.Delete_Button.Text = "Usun";
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Search_Button
            // 
            this.Search_Button.Index = 1;
            this.Search_Button.Text = "Szukaj";
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // Sort_Button
            // 
            this.Sort_Button.Index = 2;
            this.Sort_Button.Text = "Sortuj";
            this.Sort_Button.Click += new System.EventHandler(this.Sort_Button_Click);
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.Index = 3;
            this.ShowAllButton.Text = "Pokaż wszystko";
            this.ShowAllButton.Click += new System.EventHandler(this.Show_All_Click);
            // 
            // Podwojny_Kontener
            // 
            this.Podwojny_Kontener.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Podwojny_Kontener.Location = new System.Drawing.Point(0, 0);
            this.Podwojny_Kontener.Name = "Podwojny_Kontener";
            this.Podwojny_Kontener.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Podwojny_Kontener.Panel1
            // 
            this.Podwojny_Kontener.Panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.ListItem;
            this.Podwojny_Kontener.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Podwojny_Kontener.Panel1.Controls.Add(this.PhotoList);
            this.Podwojny_Kontener.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Podwojny_Kontener.Panel1MinSize = 50;
            // 
            // Podwojny_Kontener.Panel2
            // 
            this.Podwojny_Kontener.Panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.Podwojny_Kontener.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.Podwojny_Kontener.Panel2.Controls.Add(this.Details_ListView);
            this.Podwojny_Kontener.Panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Podwojny_Kontener.Panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Podwojny_Kontener.Panel2MinSize = 50;
            this.Podwojny_Kontener.Size = new System.Drawing.Size(800, 450);
            this.Podwojny_Kontener.SplitterDistance = 250;
            this.Podwojny_Kontener.TabIndex = 1;
            // 
            // PhotoList
            // 
            this.PhotoList.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PhotoList.BackgroundImageTiled = true;
            this.PhotoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhotoList.GridLines = true;
            this.PhotoList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.PhotoList.HideSelection = false;
            this.PhotoList.LargeImageList = this.ImageList;
            this.PhotoList.Location = new System.Drawing.Point(0, 0);
            this.PhotoList.Name = "PhotoList";
            this.PhotoList.Size = new System.Drawing.Size(800, 250);
            this.PhotoList.TabIndex = 0;
            this.PhotoList.UseCompatibleStateImageBehavior = false;
            this.PhotoList.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.PhotoList_ItemMouseHover);
            this.PhotoList.SelectedIndexChanged += new System.EventHandler(this.PhotoList_SelectedIndexChanged);
            this.PhotoList.DoubleClick += new System.EventHandler(this.PhotoList_DoubleClick);
            // 
            // ImageList
            // 
            this.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ImageList.ImageSize = new System.Drawing.Size(150, 200);
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Details_ListView
            // 
            this.Details_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.Details_ListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Details_ListView.GridLines = true;
            this.Details_ListView.HideSelection = false;
            this.Details_ListView.Location = new System.Drawing.Point(0, 0);
            this.Details_ListView.MultiSelect = false;
            this.Details_ListView.Name = "Details_ListView";
            this.Details_ListView.Size = new System.Drawing.Size(800, 196);
            this.Details_ListView.TabIndex = 0;
            this.Details_ListView.UseCompatibleStateImageBehavior = false;
            this.Details_ListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nazwa atrybutu";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Wartość";
            this.columnHeader2.Width = 676;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Podwojny_Kontener);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "MainForm";
            this.Text = "Domowa Biblioteczka";
            this.Podwojny_Kontener.Panel1.ResumeLayout(false);
            this.Podwojny_Kontener.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Podwojny_Kontener)).EndInit();
            this.Podwojny_Kontener.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem Search_Button;
        private System.Windows.Forms.SplitContainer Podwojny_Kontener;
        private System.Windows.Forms.MenuItem Add_Button;
        private System.Windows.Forms.MenuItem Edit_Button;
        private System.Windows.Forms.MenuItem Delete_Button;
        private System.Windows.Forms.MenuItem Sort_Button;
        private System.Windows.Forms.ListView PhotoList;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.ListView Details_ListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.MenuItem ShowAllButton;
    }
}

