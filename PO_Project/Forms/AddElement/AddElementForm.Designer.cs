
namespace PO_Project
{
    partial class AddElementForm
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
            this.AddElement_Type_ComboBox = new System.Windows.Forms.ComboBox();
            this.AddElement_Type_Static = new System.Windows.Forms.Label();
            this.AddElement_Name_Static = new System.Windows.Forms.Label();
            this.AddElement_Author_Static = new System.Windows.Forms.Label();
            this.AddElement_Name_TextBox = new System.Windows.Forms.TextBox();
            this.AddElement_Author_TextBox = new System.Windows.Forms.TextBox();
            this.AddElement_Description_Static = new System.Windows.Forms.Label();
            this.AddElement_Description_TextBox = new System.Windows.Forms.TextBox();
            this.Add_Element_ReleaseDate = new System.Windows.Forms.Label();
            this.AddElement_ReleaseDate_Dynamic = new System.Windows.Forms.DateTimePicker();
            this.AddElement_FileLocation_Static = new System.Windows.Forms.Label();
            this.AddElement_FileLocation_Dynamic = new System.Windows.Forms.TextBox();
            this.AddElement_FileLocation_Button = new System.Windows.Forms.Button();
            this.AddElement_PhotoLocation_Static = new System.Windows.Forms.Label();
            this.AddElement_PhotoLocation_Dynamic = new System.Windows.Forms.TextBox();
            this.AddElement_PhotoLocation_Button = new System.Windows.Forms.Button();
            this.AddElement_Add_Button = new System.Windows.Forms.Button();
            this.AddElement_Exit_Button = new System.Windows.Forms.Button();
            this.AddElement_ExtraAttributes_Label = new System.Windows.Forms.Label();
            this.AddElement_ExtraAttributes_ListView = new System.Windows.Forms.ListView();
            this.ExtraAttributeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExtraAttributeValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddElement_AddAttribute_Button = new System.Windows.Forms.Button();
            this.AddElement_Delete_Button = new System.Windows.Forms.Button();
            this.AddElement_Edit_Button = new System.Windows.Forms.Button();
            this.AddElement_FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.AddElement_Type_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddElement_Type_ComboBox
            // 
            this.AddElement_Type_ComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddElement_Type_ComboBox.FormattingEnabled = true;
            this.AddElement_Type_ComboBox.Location = new System.Drawing.Point(286, 9);
            this.AddElement_Type_ComboBox.Name = "AddElement_Type_ComboBox";
            this.AddElement_Type_ComboBox.Size = new System.Drawing.Size(115, 21);
            this.AddElement_Type_ComboBox.TabIndex = 0;
            this.AddElement_Type_ComboBox.SelectedIndexChanged += new System.EventHandler(this.AddElement_Type_ComboBox_SelectedIndexChanged);
            // 
            // AddElement_Type_Static
            // 
            this.AddElement_Type_Static.AutoSize = true;
            this.AddElement_Type_Static.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddElement_Type_Static.Location = new System.Drawing.Point(12, 9);
            this.AddElement_Type_Static.Name = "AddElement_Type_Static";
            this.AddElement_Type_Static.Size = new System.Drawing.Size(124, 22);
            this.AddElement_Type_Static.TabIndex = 1;
            this.AddElement_Type_Static.Text = "Typ elementu:";
            // 
            // AddElement_Name_Static
            // 
            this.AddElement_Name_Static.AutoSize = true;
            this.AddElement_Name_Static.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddElement_Name_Static.Location = new System.Drawing.Point(16, 46);
            this.AddElement_Name_Static.Name = "AddElement_Name_Static";
            this.AddElement_Name_Static.Size = new System.Drawing.Size(57, 22);
            this.AddElement_Name_Static.TabIndex = 2;
            this.AddElement_Name_Static.Text = "Tytuł:";
            // 
            // AddElement_Author_Static
            // 
            this.AddElement_Author_Static.AutoSize = true;
            this.AddElement_Author_Static.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddElement_Author_Static.Location = new System.Drawing.Point(16, 83);
            this.AddElement_Author_Static.Name = "AddElement_Author_Static";
            this.AddElement_Author_Static.Size = new System.Drawing.Size(62, 22);
            this.AddElement_Author_Static.TabIndex = 3;
            this.AddElement_Author_Static.Text = "Autor:";
            // 
            // AddElement_Name_TextBox
            // 
            this.AddElement_Name_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddElement_Name_TextBox.Location = new System.Drawing.Point(286, 46);
            this.AddElement_Name_TextBox.Name = "AddElement_Name_TextBox";
            this.AddElement_Name_TextBox.Size = new System.Drawing.Size(115, 20);
            this.AddElement_Name_TextBox.TabIndex = 4;
            // 
            // AddElement_Author_TextBox
            // 
            this.AddElement_Author_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddElement_Author_TextBox.Location = new System.Drawing.Point(286, 83);
            this.AddElement_Author_TextBox.Name = "AddElement_Author_TextBox";
            this.AddElement_Author_TextBox.Size = new System.Drawing.Size(115, 20);
            this.AddElement_Author_TextBox.TabIndex = 5;
            // 
            // AddElement_Description_Static
            // 
            this.AddElement_Description_Static.AutoSize = true;
            this.AddElement_Description_Static.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddElement_Description_Static.Location = new System.Drawing.Point(12, 239);
            this.AddElement_Description_Static.Name = "AddElement_Description_Static";
            this.AddElement_Description_Static.Size = new System.Drawing.Size(53, 22);
            this.AddElement_Description_Static.TabIndex = 8;
            this.AddElement_Description_Static.Text = "Opis:";
            // 
            // AddElement_Description_TextBox
            // 
            this.AddElement_Description_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddElement_Description_TextBox.Location = new System.Drawing.Point(286, 239);
            this.AddElement_Description_TextBox.Multiline = true;
            this.AddElement_Description_TextBox.Name = "AddElement_Description_TextBox";
            this.AddElement_Description_TextBox.Size = new System.Drawing.Size(256, 39);
            this.AddElement_Description_TextBox.TabIndex = 9;
            // 
            // Add_Element_ReleaseDate
            // 
            this.Add_Element_ReleaseDate.AutoSize = true;
            this.Add_Element_ReleaseDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Add_Element_ReleaseDate.Location = new System.Drawing.Point(12, 121);
            this.Add_Element_ReleaseDate.Name = "Add_Element_ReleaseDate";
            this.Add_Element_ReleaseDate.Size = new System.Drawing.Size(128, 22);
            this.Add_Element_ReleaseDate.TabIndex = 12;
            this.Add_Element_ReleaseDate.Text = "Data wydania:";
            // 
            // AddElement_ReleaseDate_Dynamic
            // 
            this.AddElement_ReleaseDate_Dynamic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddElement_ReleaseDate_Dynamic.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AddElement_ReleaseDate_Dynamic.Location = new System.Drawing.Point(286, 123);
            this.AddElement_ReleaseDate_Dynamic.Name = "AddElement_ReleaseDate_Dynamic";
            this.AddElement_ReleaseDate_Dynamic.Size = new System.Drawing.Size(115, 20);
            this.AddElement_ReleaseDate_Dynamic.TabIndex = 13;
            this.AddElement_ReleaseDate_Dynamic.Value = new System.DateTime(2021, 5, 8, 0, 0, 0, 0);
            // 
            // AddElement_FileLocation_Static
            // 
            this.AddElement_FileLocation_Static.AutoSize = true;
            this.AddElement_FileLocation_Static.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddElement_FileLocation_Static.Location = new System.Drawing.Point(12, 160);
            this.AddElement_FileLocation_Static.Name = "AddElement_FileLocation_Static";
            this.AddElement_FileLocation_Static.Size = new System.Drawing.Size(157, 22);
            this.AddElement_FileLocation_Static.TabIndex = 14;
            this.AddElement_FileLocation_Static.Text = "Lokalizacja pliku:";
            // 
            // AddElement_FileLocation_Dynamic
            // 
            this.AddElement_FileLocation_Dynamic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddElement_FileLocation_Dynamic.Location = new System.Drawing.Point(286, 163);
            this.AddElement_FileLocation_Dynamic.Name = "AddElement_FileLocation_Dynamic";
            this.AddElement_FileLocation_Dynamic.Size = new System.Drawing.Size(115, 20);
            this.AddElement_FileLocation_Dynamic.TabIndex = 15;
            // 
            // AddElement_FileLocation_Button
            // 
            this.AddElement_FileLocation_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddElement_FileLocation_Button.Location = new System.Drawing.Point(407, 163);
            this.AddElement_FileLocation_Button.Name = "AddElement_FileLocation_Button";
            this.AddElement_FileLocation_Button.Size = new System.Drawing.Size(26, 20);
            this.AddElement_FileLocation_Button.TabIndex = 16;
            this.AddElement_FileLocation_Button.Text = "...";
            this.AddElement_FileLocation_Button.UseVisualStyleBackColor = true;
            this.AddElement_FileLocation_Button.Click += new System.EventHandler(this.AddElement_FileLocation_Button_Click);
            // 
            // AddElement_PhotoLocation_Static
            // 
            this.AddElement_PhotoLocation_Static.AutoSize = true;
            this.AddElement_PhotoLocation_Static.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddElement_PhotoLocation_Static.Location = new System.Drawing.Point(12, 202);
            this.AddElement_PhotoLocation_Static.Name = "AddElement_PhotoLocation_Static";
            this.AddElement_PhotoLocation_Static.Size = new System.Drawing.Size(240, 22);
            this.AddElement_PhotoLocation_Static.TabIndex = 17;
            this.AddElement_PhotoLocation_Static.Text = "Lokalizacja zdjęcia okładki:";
            // 
            // AddElement_PhotoLocation_Dynamic
            // 
            this.AddElement_PhotoLocation_Dynamic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddElement_PhotoLocation_Dynamic.Location = new System.Drawing.Point(286, 205);
            this.AddElement_PhotoLocation_Dynamic.Name = "AddElement_PhotoLocation_Dynamic";
            this.AddElement_PhotoLocation_Dynamic.Size = new System.Drawing.Size(115, 20);
            this.AddElement_PhotoLocation_Dynamic.TabIndex = 18;
            // 
            // AddElement_PhotoLocation_Button
            // 
            this.AddElement_PhotoLocation_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddElement_PhotoLocation_Button.Location = new System.Drawing.Point(407, 205);
            this.AddElement_PhotoLocation_Button.Name = "AddElement_PhotoLocation_Button";
            this.AddElement_PhotoLocation_Button.Size = new System.Drawing.Size(26, 20);
            this.AddElement_PhotoLocation_Button.TabIndex = 19;
            this.AddElement_PhotoLocation_Button.Text = "...";
            this.AddElement_PhotoLocation_Button.UseVisualStyleBackColor = true;
            this.AddElement_PhotoLocation_Button.Click += new System.EventHandler(this.AddElement_PhotoLocation_Button_Click);
            // 
            // AddElement_Add_Button
            // 
            this.AddElement_Add_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddElement_Add_Button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddElement_Add_Button.Location = new System.Drawing.Point(12, 561);
            this.AddElement_Add_Button.Name = "AddElement_Add_Button";
            this.AddElement_Add_Button.Size = new System.Drawing.Size(240, 38);
            this.AddElement_Add_Button.TabIndex = 20;
            this.AddElement_Add_Button.Text = "Dodaj element";
            this.AddElement_Add_Button.UseVisualStyleBackColor = true;
            this.AddElement_Add_Button.Click += new System.EventHandler(this.AddElement_Add_Button_Click);
            // 
            // AddElement_Exit_Button
            // 
            this.AddElement_Exit_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddElement_Exit_Button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddElement_Exit_Button.Location = new System.Drawing.Point(286, 561);
            this.AddElement_Exit_Button.Name = "AddElement_Exit_Button";
            this.AddElement_Exit_Button.Size = new System.Drawing.Size(256, 38);
            this.AddElement_Exit_Button.TabIndex = 21;
            this.AddElement_Exit_Button.Text = "Anuluj";
            this.AddElement_Exit_Button.UseVisualStyleBackColor = true;
            this.AddElement_Exit_Button.Click += new System.EventHandler(this.AddElement_Exit_Button_Click);
            // 
            // AddElement_ExtraAttributes_Label
            // 
            this.AddElement_ExtraAttributes_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddElement_ExtraAttributes_Label.AutoSize = true;
            this.AddElement_ExtraAttributes_Label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddElement_ExtraAttributes_Label.Location = new System.Drawing.Point(12, 292);
            this.AddElement_ExtraAttributes_Label.Name = "AddElement_ExtraAttributes_Label";
            this.AddElement_ExtraAttributes_Label.Size = new System.Drawing.Size(509, 22);
            this.AddElement_ExtraAttributes_Label.TabIndex = 23;
            this.AddElement_ExtraAttributes_Label.Text = "Dodatkowe atrybuty ktorymi można opisać wybrany element:";
            // 
            // AddElement_ExtraAttributes_ListView
            // 
            this.AddElement_ExtraAttributes_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddElement_ExtraAttributes_ListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddElement_ExtraAttributes_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ExtraAttributeName,
            this.ExtraAttributeValue});
            this.AddElement_ExtraAttributes_ListView.GridLines = true;
            this.AddElement_ExtraAttributes_ListView.HideSelection = false;
            this.AddElement_ExtraAttributes_ListView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.AddElement_ExtraAttributes_ListView.LabelWrap = false;
            this.AddElement_ExtraAttributes_ListView.Location = new System.Drawing.Point(12, 317);
            this.AddElement_ExtraAttributes_ListView.MultiSelect = false;
            this.AddElement_ExtraAttributes_ListView.Name = "AddElement_ExtraAttributes_ListView";
            this.AddElement_ExtraAttributes_ListView.Size = new System.Drawing.Size(530, 193);
            this.AddElement_ExtraAttributes_ListView.TabIndex = 24;
            this.AddElement_ExtraAttributes_ListView.UseCompatibleStateImageBehavior = false;
            this.AddElement_ExtraAttributes_ListView.View = System.Windows.Forms.View.Details;
            // 
            // ExtraAttributeName
            // 
            this.ExtraAttributeName.Text = "Nazwa dodatkowych atrybutów";
            this.ExtraAttributeName.Width = 167;
            // 
            // ExtraAttributeValue
            // 
            this.ExtraAttributeValue.Text = "Wartość";
            this.ExtraAttributeValue.Width = 363;
            // 
            // AddElement_AddAttribute_Button
            // 
            this.AddElement_AddAttribute_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddElement_AddAttribute_Button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddElement_AddAttribute_Button.Location = new System.Drawing.Point(12, 516);
            this.AddElement_AddAttribute_Button.Name = "AddElement_AddAttribute_Button";
            this.AddElement_AddAttribute_Button.Size = new System.Drawing.Size(145, 38);
            this.AddElement_AddAttribute_Button.TabIndex = 25;
            this.AddElement_AddAttribute_Button.Text = "Dodaj atrybut";
            this.AddElement_AddAttribute_Button.UseVisualStyleBackColor = true;
            this.AddElement_AddAttribute_Button.Click += new System.EventHandler(this.AddElement_AddAttribute_Button_Click);
            // 
            // AddElement_Delete_Button
            // 
            this.AddElement_Delete_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddElement_Delete_Button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddElement_Delete_Button.Location = new System.Drawing.Point(397, 516);
            this.AddElement_Delete_Button.Name = "AddElement_Delete_Button";
            this.AddElement_Delete_Button.Size = new System.Drawing.Size(145, 38);
            this.AddElement_Delete_Button.TabIndex = 26;
            this.AddElement_Delete_Button.Text = "Usuń atrybut";
            this.AddElement_Delete_Button.UseVisualStyleBackColor = true;
            this.AddElement_Delete_Button.Click += new System.EventHandler(this.AddElement_Delete_Button_Click);
            // 
            // AddElement_Edit_Button
            // 
            this.AddElement_Edit_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddElement_Edit_Button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddElement_Edit_Button.Location = new System.Drawing.Point(207, 517);
            this.AddElement_Edit_Button.Name = "AddElement_Edit_Button";
            this.AddElement_Edit_Button.Size = new System.Drawing.Size(145, 38);
            this.AddElement_Edit_Button.TabIndex = 27;
            this.AddElement_Edit_Button.Text = "Edytuj atrybut";
            this.AddElement_Edit_Button.UseVisualStyleBackColor = true;
            this.AddElement_Edit_Button.Click += new System.EventHandler(this.AddElement_Edit_Button_Click);
            // 
            // AddElement_Type_TextBox
            // 
            this.AddElement_Type_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddElement_Type_TextBox.Location = new System.Drawing.Point(408, 9);
            this.AddElement_Type_TextBox.Name = "AddElement_Type_TextBox";
            this.AddElement_Type_TextBox.Size = new System.Drawing.Size(134, 20);
            this.AddElement_Type_TextBox.TabIndex = 28;
            this.AddElement_Type_TextBox.Visible = false;
            // 
            // AddElementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(554, 611);
            this.Controls.Add(this.AddElement_Type_TextBox);
            this.Controls.Add(this.AddElement_Edit_Button);
            this.Controls.Add(this.AddElement_Delete_Button);
            this.Controls.Add(this.AddElement_AddAttribute_Button);
            this.Controls.Add(this.AddElement_ExtraAttributes_ListView);
            this.Controls.Add(this.AddElement_ExtraAttributes_Label);
            this.Controls.Add(this.AddElement_Exit_Button);
            this.Controls.Add(this.AddElement_Add_Button);
            this.Controls.Add(this.AddElement_PhotoLocation_Button);
            this.Controls.Add(this.AddElement_PhotoLocation_Dynamic);
            this.Controls.Add(this.AddElement_PhotoLocation_Static);
            this.Controls.Add(this.AddElement_FileLocation_Button);
            this.Controls.Add(this.AddElement_FileLocation_Dynamic);
            this.Controls.Add(this.AddElement_FileLocation_Static);
            this.Controls.Add(this.AddElement_ReleaseDate_Dynamic);
            this.Controls.Add(this.Add_Element_ReleaseDate);
            this.Controls.Add(this.AddElement_Description_TextBox);
            this.Controls.Add(this.AddElement_Description_Static);
            this.Controls.Add(this.AddElement_Author_TextBox);
            this.Controls.Add(this.AddElement_Name_TextBox);
            this.Controls.Add(this.AddElement_Author_Static);
            this.Controls.Add(this.AddElement_Name_Static);
            this.Controls.Add(this.AddElement_Type_Static);
            this.Controls.Add(this.AddElement_Type_ComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(570, 565);
            this.Name = "AddElementForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Dodawanie elementu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.ComboBox AddElement_Type_ComboBox;
        private System.Windows.Forms.Label AddElement_Type_Static;
        private System.Windows.Forms.Label AddElement_Name_Static;
        private System.Windows.Forms.Label AddElement_Author_Static;
        private System.Windows.Forms.TextBox AddElement_Name_TextBox;
        private System.Windows.Forms.TextBox AddElement_Author_TextBox;
        private System.Windows.Forms.Label AddElement_Description_Static;
        private System.Windows.Forms.TextBox AddElement_Description_TextBox;
        private System.Windows.Forms.Label Add_Element_ReleaseDate;
        private System.Windows.Forms.DateTimePicker AddElement_ReleaseDate_Dynamic;
        private System.Windows.Forms.Label AddElement_FileLocation_Static;
        private System.Windows.Forms.TextBox AddElement_FileLocation_Dynamic;
        private System.Windows.Forms.Button AddElement_FileLocation_Button;
        private System.Windows.Forms.Label AddElement_PhotoLocation_Static;
        private System.Windows.Forms.TextBox AddElement_PhotoLocation_Dynamic;
        private System.Windows.Forms.Button AddElement_PhotoLocation_Button;
        private System.Windows.Forms.Button AddElement_Add_Button;
        private System.Windows.Forms.Button AddElement_Exit_Button;
        private System.Windows.Forms.Label AddElement_ExtraAttributes_Label;
        private System.Windows.Forms.ListView AddElement_ExtraAttributes_ListView;
        private System.Windows.Forms.ColumnHeader ExtraAttributeName;
        private System.Windows.Forms.ColumnHeader ExtraAttributeValue;
        private System.Windows.Forms.Button AddElement_AddAttribute_Button;
        private System.Windows.Forms.Button AddElement_Delete_Button;
        private System.Windows.Forms.Button AddElement_Edit_Button;
        private System.Windows.Forms.OpenFileDialog AddElement_FileDialog;
        private System.Windows.Forms.TextBox AddElement_Type_TextBox;
    }
}