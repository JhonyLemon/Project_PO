
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
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.Add_Button = new System.Windows.Forms.MenuItem();
            this.Edit_Button = new System.Windows.Forms.MenuItem();
            this.Delete_Button = new System.Windows.Forms.MenuItem();
            this.Search_Button = new System.Windows.Forms.MenuItem();
            this.Sort_Button = new System.Windows.Forms.MenuItem();
            this.Filter_Button = new System.Windows.Forms.MenuItem();
            this.Podwojny_Kontener = new System.Windows.Forms.SplitContainer();
            this.PhotoList = new System.Windows.Forms.ListView();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.FileLocation_Dynamic = new System.Windows.Forms.TextBox();
            this.ReleaseDate_Dynamic = new System.Windows.Forms.Label();
            this.Length_Dynamic = new System.Windows.Forms.Label();
            this.Category_Dynamic = new System.Windows.Forms.Label();
            this.Description_Dynamic = new System.Windows.Forms.Label();
            this.Author_Dynamic = new System.Windows.Forms.Label();
            this.Name_Dynamic = new System.Windows.Forms.Label();
            this.FileLocation_Static = new System.Windows.Forms.Label();
            this.ReleaseDate_Static = new System.Windows.Forms.Label();
            this.Length_Static = new System.Windows.Forms.Label();
            this.Category_Static = new System.Windows.Forms.Label();
            this.Description_Static = new System.Windows.Forms.Label();
            this.Author_Static = new System.Windows.Forms.Label();
            this.Name_Static = new System.Windows.Forms.Label();
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
            this.Filter_Button});
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
            // Filter_Button
            // 
            this.Filter_Button.Index = 3;
            this.Filter_Button.Text = "Filtruj";
            this.Filter_Button.Click += new System.EventHandler(this.Filter_Button_Click);
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
            this.Podwojny_Kontener.Panel2.Controls.Add(this.dateTimePicker1);
            this.Podwojny_Kontener.Panel2.Controls.Add(this.FileLocation_Dynamic);
            this.Podwojny_Kontener.Panel2.Controls.Add(this.ReleaseDate_Dynamic);
            this.Podwojny_Kontener.Panel2.Controls.Add(this.Length_Dynamic);
            this.Podwojny_Kontener.Panel2.Controls.Add(this.Category_Dynamic);
            this.Podwojny_Kontener.Panel2.Controls.Add(this.Description_Dynamic);
            this.Podwojny_Kontener.Panel2.Controls.Add(this.Author_Dynamic);
            this.Podwojny_Kontener.Panel2.Controls.Add(this.Name_Dynamic);
            this.Podwojny_Kontener.Panel2.Controls.Add(this.FileLocation_Static);
            this.Podwojny_Kontener.Panel2.Controls.Add(this.ReleaseDate_Static);
            this.Podwojny_Kontener.Panel2.Controls.Add(this.Length_Static);
            this.Podwojny_Kontener.Panel2.Controls.Add(this.Category_Static);
            this.Podwojny_Kontener.Panel2.Controls.Add(this.Description_Static);
            this.Podwojny_Kontener.Panel2.Controls.Add(this.Author_Static);
            this.Podwojny_Kontener.Panel2.Controls.Add(this.Name_Static);
            this.Podwojny_Kontener.Panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Podwojny_Kontener.Panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Podwojny_Kontener.Panel2MinSize = 50;
            this.Podwojny_Kontener.Size = new System.Drawing.Size(800, 450);
            this.Podwojny_Kontener.SplitterDistance = 250;
            this.Podwojny_Kontener.TabIndex = 1;
            // 
            // PhotoList
            // 
            this.PhotoList.BackColor = System.Drawing.Color.DarkRed;
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
            this.PhotoList.SelectedIndexChanged += new System.EventHandler(this.PhotoList_SelectedIndexChanged);
            // 
            // ImageList
            // 
            this.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ImageList.ImageSize = new System.Drawing.Size(150, 200);
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(343, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(115, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // FileLocation_Dynamic
            // 
            this.FileLocation_Dynamic.Location = new System.Drawing.Point(197, 142);
            this.FileLocation_Dynamic.Name = "FileLocation_Dynamic";
            this.FileLocation_Dynamic.ReadOnly = true;
            this.FileLocation_Dynamic.Size = new System.Drawing.Size(100, 20);
            this.FileLocation_Dynamic.TabIndex = 15;
            this.FileLocation_Dynamic.TabStop = false;
            // 
            // ReleaseDate_Dynamic
            // 
            this.ReleaseDate_Dynamic.AutoSize = true;
            this.ReleaseDate_Dynamic.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ReleaseDate_Dynamic.Location = new System.Drawing.Point(193, 118);
            this.ReleaseDate_Dynamic.Name = "ReleaseDate_Dynamic";
            this.ReleaseDate_Dynamic.Size = new System.Drawing.Size(15, 22);
            this.ReleaseDate_Dynamic.TabIndex = 13;
            this.ReleaseDate_Dynamic.Text = ".";
            // 
            // Length_Dynamic
            // 
            this.Length_Dynamic.AutoSize = true;
            this.Length_Dynamic.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Length_Dynamic.Location = new System.Drawing.Point(193, 96);
            this.Length_Dynamic.Name = "Length_Dynamic";
            this.Length_Dynamic.Size = new System.Drawing.Size(15, 22);
            this.Length_Dynamic.TabIndex = 12;
            this.Length_Dynamic.Text = ".";
            // 
            // Category_Dynamic
            // 
            this.Category_Dynamic.AutoSize = true;
            this.Category_Dynamic.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Category_Dynamic.Location = new System.Drawing.Point(193, 74);
            this.Category_Dynamic.Name = "Category_Dynamic";
            this.Category_Dynamic.Size = new System.Drawing.Size(15, 22);
            this.Category_Dynamic.TabIndex = 11;
            this.Category_Dynamic.Text = ".";
            // 
            // Description_Dynamic
            // 
            this.Description_Dynamic.AutoSize = true;
            this.Description_Dynamic.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Description_Dynamic.Location = new System.Drawing.Point(193, 52);
            this.Description_Dynamic.Name = "Description_Dynamic";
            this.Description_Dynamic.Size = new System.Drawing.Size(15, 22);
            this.Description_Dynamic.TabIndex = 10;
            this.Description_Dynamic.Text = ".";
            // 
            // Author_Dynamic
            // 
            this.Author_Dynamic.AutoSize = true;
            this.Author_Dynamic.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Author_Dynamic.Location = new System.Drawing.Point(193, 30);
            this.Author_Dynamic.Name = "Author_Dynamic";
            this.Author_Dynamic.Size = new System.Drawing.Size(15, 22);
            this.Author_Dynamic.TabIndex = 9;
            this.Author_Dynamic.Text = ".";
            // 
            // Name_Dynamic
            // 
            this.Name_Dynamic.AutoSize = true;
            this.Name_Dynamic.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name_Dynamic.Location = new System.Drawing.Point(193, 8);
            this.Name_Dynamic.Name = "Name_Dynamic";
            this.Name_Dynamic.Size = new System.Drawing.Size(15, 22);
            this.Name_Dynamic.TabIndex = 8;
            this.Name_Dynamic.Text = ".";
            // 
            // FileLocation_Static
            // 
            this.FileLocation_Static.AutoSize = true;
            this.FileLocation_Static.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FileLocation_Static.Location = new System.Drawing.Point(7, 140);
            this.FileLocation_Static.Name = "FileLocation_Static";
            this.FileLocation_Static.Size = new System.Drawing.Size(157, 22);
            this.FileLocation_Static.TabIndex = 6;
            this.FileLocation_Static.Text = "Lokalizacja pliku:";
            // 
            // ReleaseDate_Static
            // 
            this.ReleaseDate_Static.AutoSize = true;
            this.ReleaseDate_Static.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ReleaseDate_Static.Location = new System.Drawing.Point(7, 118);
            this.ReleaseDate_Static.Name = "ReleaseDate_Static";
            this.ReleaseDate_Static.Size = new System.Drawing.Size(128, 22);
            this.ReleaseDate_Static.TabIndex = 5;
            this.ReleaseDate_Static.Text = "Data wydania:";
            // 
            // Length_Static
            // 
            this.Length_Static.AutoSize = true;
            this.Length_Static.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Length_Static.Location = new System.Drawing.Point(7, 96);
            this.Length_Static.Name = "Length_Static";
            this.Length_Static.Size = new System.Drawing.Size(123, 22);
            this.Length_Static.TabIndex = 4;
            this.Length_Static.Text = "Czas trwania:";
            // 
            // Category_Static
            // 
            this.Category_Static.AutoSize = true;
            this.Category_Static.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Category_Static.Location = new System.Drawing.Point(7, 74);
            this.Category_Static.Name = "Category_Static";
            this.Category_Static.Size = new System.Drawing.Size(97, 22);
            this.Category_Static.TabIndex = 3;
            this.Category_Static.Text = "Kategoria:";
            // 
            // Description_Static
            // 
            this.Description_Static.AutoSize = true;
            this.Description_Static.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Description_Static.Location = new System.Drawing.Point(7, 52);
            this.Description_Static.Name = "Description_Static";
            this.Description_Static.Size = new System.Drawing.Size(53, 22);
            this.Description_Static.TabIndex = 2;
            this.Description_Static.Text = "Opis:";
            // 
            // Author_Static
            // 
            this.Author_Static.AutoSize = true;
            this.Author_Static.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Author_Static.Location = new System.Drawing.Point(7, 30);
            this.Author_Static.Name = "Author_Static";
            this.Author_Static.Size = new System.Drawing.Size(62, 22);
            this.Author_Static.TabIndex = 1;
            this.Author_Static.Text = "Autor:";
            // 
            // Name_Static
            // 
            this.Name_Static.AutoSize = true;
            this.Name_Static.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name_Static.Location = new System.Drawing.Point(7, 8);
            this.Name_Static.Name = "Name_Static";
            this.Name_Static.Size = new System.Drawing.Size(57, 22);
            this.Name_Static.TabIndex = 0;
            this.Name_Static.Text = "Tytuł:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Podwojny_Kontener);
            this.Menu = this.mainMenu1;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Domowa Biblioteczka";
            this.Podwojny_Kontener.Panel1.ResumeLayout(false);
            this.Podwojny_Kontener.Panel2.ResumeLayout(false);
            this.Podwojny_Kontener.Panel2.PerformLayout();
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
        private System.Windows.Forms.MenuItem Filter_Button;
        private System.Windows.Forms.ListView PhotoList;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.Label Name_Static;
        private System.Windows.Forms.Label Author_Static;
        private System.Windows.Forms.Label Description_Static;
        private System.Windows.Forms.Label Category_Static;
        private System.Windows.Forms.Label Length_Static;
        private System.Windows.Forms.Label ReleaseDate_Static;
        private System.Windows.Forms.Label ReleaseDate_Dynamic;
        private System.Windows.Forms.Label Length_Dynamic;
        private System.Windows.Forms.Label Category_Dynamic;
        private System.Windows.Forms.Label Description_Dynamic;
        private System.Windows.Forms.Label Author_Dynamic;
        private System.Windows.Forms.Label Name_Dynamic;
        private System.Windows.Forms.Label FileLocation_Static;
        private System.Windows.Forms.TextBox FileLocation_Dynamic;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

