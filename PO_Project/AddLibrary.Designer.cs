
namespace PO_Project
{
    partial class AddLibrary
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
            this.TypeList = new System.Windows.Forms.ComboBox();
            this.LibraryType = new System.Windows.Forms.Label();
            this.File_Location = new System.Windows.Forms.TextBox();
            this.Localisation = new System.Windows.Forms.Label();
            this.Browse = new System.Windows.Forms.Button();
            this.Create_Library = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // TypeList
            // 
            this.TypeList.FormattingEnabled = true;
            this.TypeList.Items.AddRange(new object[] {
            "Films",
            "Games",
            "Books",
            "Music"});
            this.TypeList.Location = new System.Drawing.Point(15, 25);
            this.TypeList.Name = "TypeList";
            this.TypeList.Size = new System.Drawing.Size(121, 21);
            this.TypeList.TabIndex = 0;
            // 
            // LibraryType
            // 
            this.LibraryType.AutoSize = true;
            this.LibraryType.Location = new System.Drawing.Point(12, 9);
            this.LibraryType.Name = "LibraryType";
            this.LibraryType.Size = new System.Drawing.Size(70, 13);
            this.LibraryType.TabIndex = 1;
            this.LibraryType.Text = "Typ Biblioteki";
            // 
            // File_Location
            // 
            this.File_Location.Location = new System.Drawing.Point(15, 65);
            this.File_Location.Name = "File_Location";
            this.File_Location.Size = new System.Drawing.Size(121, 20);
            this.File_Location.TabIndex = 2;
            // 
            // Localisation
            // 
            this.Localisation.AutoSize = true;
            this.Localisation.Location = new System.Drawing.Point(12, 49);
            this.Localisation.Name = "Localisation";
            this.Localisation.Size = new System.Drawing.Size(163, 13);
            this.Localisation.TabIndex = 3;
            this.Localisation.Text = "Wybierz Lokalizacje dla Biblioteki";
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(15, 91);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 4;
            this.Browse.Text = "Wybierz";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // Create_Library
            // 
            this.Create_Library.Location = new System.Drawing.Point(15, 133);
            this.Create_Library.Name = "Create_Library";
            this.Create_Library.Size = new System.Drawing.Size(161, 23);
            this.Create_Library.TabIndex = 5;
            this.Create_Library.Text = "Utworz biblioteke";
            this.Create_Library.UseVisualStyleBackColor = true;
            this.Create_Library.Click += new System.EventHandler(this.Create_Library_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "OpenFile";
            this.OpenFile.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFile_FileOk);
            // 
            // AddLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 175);
            this.Controls.Add(this.Create_Library);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.Localisation);
            this.Controls.Add(this.File_Location);
            this.Controls.Add(this.LibraryType);
            this.Controls.Add(this.TypeList);
            this.Name = "AddLibrary";
            this.Text = "Utworz biblioteke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TypeList;
        private System.Windows.Forms.Label LibraryType;
        private System.Windows.Forms.TextBox File_Location;
        private System.Windows.Forms.Label Localisation;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Button Create_Library;
        private System.Windows.Forms.OpenFileDialog OpenFile;
    }
}