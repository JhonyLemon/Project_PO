
namespace PO_Project
{
    partial class EditElementForm
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
            this.EditElement_ComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EditElement_ListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EditElement_ImageBox = new System.Windows.Forms.PictureBox();
            this.EditElement_Edit_Button = new System.Windows.Forms.Button();
            this.EditElement_Cancel_Button = new System.Windows.Forms.Button();
            this.EditElement_Add_Button = new System.Windows.Forms.Button();
            this.EditElement_Delete_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EditElement_ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // EditElement_ComboBox
            // 
            this.EditElement_ComboBox.FormattingEnabled = true;
            this.EditElement_ComboBox.Location = new System.Drawing.Point(12, 43);
            this.EditElement_ComboBox.Name = "EditElement_ComboBox";
            this.EditElement_ComboBox.Size = new System.Drawing.Size(412, 21);
            this.EditElement_ComboBox.TabIndex = 0;
            this.EditElement_ComboBox.SelectionChangeCommitted += new System.EventHandler(this.EditElement_ComboBox_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybierz element:";
            // 
            // EditElement_ListView
            // 
            this.EditElement_ListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EditElement_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.EditElement_ListView.HideSelection = false;
            this.EditElement_ListView.Location = new System.Drawing.Point(12, 81);
            this.EditElement_ListView.Name = "EditElement_ListView";
            this.EditElement_ListView.Size = new System.Drawing.Size(412, 294);
            this.EditElement_ListView.TabIndex = 2;
            this.EditElement_ListView.UseCompatibleStateImageBehavior = false;
            this.EditElement_ListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nazwa atrybutu";
            this.columnHeader1.Width = 97;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Wartość";
            this.columnHeader2.Width = 309;
            // 
            // EditElement_ImageBox
            // 
            this.EditElement_ImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditElement_ImageBox.Location = new System.Drawing.Point(440, 13);
            this.EditElement_ImageBox.Name = "EditElement_ImageBox";
            this.EditElement_ImageBox.Size = new System.Drawing.Size(348, 362);
            this.EditElement_ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EditElement_ImageBox.TabIndex = 3;
            this.EditElement_ImageBox.TabStop = false;
            // 
            // EditElement_Edit_Button
            // 
            this.EditElement_Edit_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditElement_Edit_Button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditElement_Edit_Button.Location = new System.Drawing.Point(12, 381);
            this.EditElement_Edit_Button.Name = "EditElement_Edit_Button";
            this.EditElement_Edit_Button.Size = new System.Drawing.Size(150, 42);
            this.EditElement_Edit_Button.TabIndex = 4;
            this.EditElement_Edit_Button.Text = "Edytuj Element";
            this.EditElement_Edit_Button.UseVisualStyleBackColor = true;
            this.EditElement_Edit_Button.Click += new System.EventHandler(this.EditElement_Edit_Button_Click);
            // 
            // EditElement_Cancel_Button
            // 
            this.EditElement_Cancel_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditElement_Cancel_Button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditElement_Cancel_Button.Location = new System.Drawing.Point(638, 381);
            this.EditElement_Cancel_Button.Name = "EditElement_Cancel_Button";
            this.EditElement_Cancel_Button.Size = new System.Drawing.Size(150, 42);
            this.EditElement_Cancel_Button.TabIndex = 6;
            this.EditElement_Cancel_Button.Text = "Anuluj";
            this.EditElement_Cancel_Button.UseVisualStyleBackColor = true;
            this.EditElement_Cancel_Button.Click += new System.EventHandler(this.EditElement_Cancel_Button_Click);
            // 
            // EditElement_Add_Button
            // 
            this.EditElement_Add_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EditElement_Add_Button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditElement_Add_Button.Location = new System.Drawing.Point(168, 381);
            this.EditElement_Add_Button.Name = "EditElement_Add_Button";
            this.EditElement_Add_Button.Size = new System.Drawing.Size(150, 42);
            this.EditElement_Add_Button.TabIndex = 7;
            this.EditElement_Add_Button.Text = "Dodaj Atrybut";
            this.EditElement_Add_Button.UseVisualStyleBackColor = true;
            this.EditElement_Add_Button.Click += new System.EventHandler(this.EditElement_Add_Button_Click);
            // 
            // EditElement_Delete_Button
            // 
            this.EditElement_Delete_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EditElement_Delete_Button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditElement_Delete_Button.Location = new System.Drawing.Point(324, 381);
            this.EditElement_Delete_Button.Name = "EditElement_Delete_Button";
            this.EditElement_Delete_Button.Size = new System.Drawing.Size(150, 42);
            this.EditElement_Delete_Button.TabIndex = 8;
            this.EditElement_Delete_Button.Text = "Usuń Atrybut";
            this.EditElement_Delete_Button.UseVisualStyleBackColor = true;
            this.EditElement_Delete_Button.Click += new System.EventHandler(this.EditElement_Delete_Button_Click);
            // 
            // EditElementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(800, 435);
            this.Controls.Add(this.EditElement_Delete_Button);
            this.Controls.Add(this.EditElement_Add_Button);
            this.Controls.Add(this.EditElement_Cancel_Button);
            this.Controls.Add(this.EditElement_Edit_Button);
            this.Controls.Add(this.EditElement_ImageBox);
            this.Controls.Add(this.EditElement_ListView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditElement_ComboBox);
            this.MinimumSize = new System.Drawing.Size(816, 474);
            this.Name = "EditElementForm";
            this.ShowInTaskbar = false;
            this.Text = "Edutuj Element";
            ((System.ComponentModel.ISupportInitialize)(this.EditElement_ImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox EditElement_ComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView EditElement_ListView;
        private System.Windows.Forms.PictureBox EditElement_ImageBox;
        private System.Windows.Forms.Button EditElement_Edit_Button;
        private System.Windows.Forms.Button EditElement_Cancel_Button;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button EditElement_Add_Button;
        private System.Windows.Forms.Button EditElement_Delete_Button;
    }
}