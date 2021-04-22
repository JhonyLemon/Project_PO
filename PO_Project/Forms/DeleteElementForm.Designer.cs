
namespace PO_Project
{
    partial class DeleteElementForm
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
            this.DeleteElement_ComboBox = new System.Windows.Forms.ComboBox();
            this.AddElement_Type_Static = new System.Windows.Forms.Label();
            this.DeleteElement_Delete_Button = new System.Windows.Forms.Button();
            this.DeleteElement_Cancel_Button = new System.Windows.Forms.Button();
            this.DeleteElement_ListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeleteElement_ImageBox = new System.Windows.Forms.PictureBox();
            this.mainFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainFormBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DeleteElement_ImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteElement_ComboBox
            // 
            this.DeleteElement_ComboBox.FormattingEnabled = true;
            this.DeleteElement_ComboBox.Location = new System.Drawing.Point(12, 62);
            this.DeleteElement_ComboBox.Name = "DeleteElement_ComboBox";
            this.DeleteElement_ComboBox.Size = new System.Drawing.Size(387, 21);
            this.DeleteElement_ComboBox.TabIndex = 0;
            // 
            // AddElement_Type_Static
            // 
            this.AddElement_Type_Static.AutoSize = true;
            this.AddElement_Type_Static.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddElement_Type_Static.Location = new System.Drawing.Point(122, 24);
            this.AddElement_Type_Static.Name = "AddElement_Type_Static";
            this.AddElement_Type_Static.Size = new System.Drawing.Size(150, 22);
            this.AddElement_Type_Static.TabIndex = 2;
            this.AddElement_Type_Static.Text = "Wybierz element:";
            // 
            // DeleteElement_Delete_Button
            // 
            this.DeleteElement_Delete_Button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteElement_Delete_Button.Location = new System.Drawing.Point(12, 400);
            this.DeleteElement_Delete_Button.Name = "DeleteElement_Delete_Button";
            this.DeleteElement_Delete_Button.Size = new System.Drawing.Size(157, 38);
            this.DeleteElement_Delete_Button.TabIndex = 21;
            this.DeleteElement_Delete_Button.Text = "Usuń";
            this.DeleteElement_Delete_Button.UseVisualStyleBackColor = true;
            this.DeleteElement_Delete_Button.Click += new System.EventHandler(this.DeleteElement_Delete_Button_Click);
            // 
            // DeleteElement_Cancel_Button
            // 
            this.DeleteElement_Cancel_Button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteElement_Cancel_Button.Location = new System.Drawing.Point(631, 400);
            this.DeleteElement_Cancel_Button.Name = "DeleteElement_Cancel_Button";
            this.DeleteElement_Cancel_Button.Size = new System.Drawing.Size(157, 38);
            this.DeleteElement_Cancel_Button.TabIndex = 22;
            this.DeleteElement_Cancel_Button.Text = "Anuluj";
            this.DeleteElement_Cancel_Button.UseVisualStyleBackColor = true;
            this.DeleteElement_Cancel_Button.Click += new System.EventHandler(this.DeleteElement_Cancel_Button_Click);
            // 
            // DeleteElement_ListView
            // 
            this.DeleteElement_ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.DeleteElement_ListView.HideSelection = false;
            this.DeleteElement_ListView.Location = new System.Drawing.Point(12, 104);
            this.DeleteElement_ListView.Name = "DeleteElement_ListView";
            this.DeleteElement_ListView.Size = new System.Drawing.Size(387, 274);
            this.DeleteElement_ListView.TabIndex = 24;
            this.DeleteElement_ListView.UseCompatibleStateImageBehavior = false;
            this.DeleteElement_ListView.View = System.Windows.Forms.View.Details;
            this.DeleteElement_ListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nazwa Atrybutu";
            this.columnHeader1.Width = 92;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Wartość";
            this.columnHeader2.Width = 287;
            // 
            // DeleteElement_ImageBox
            // 
            this.DeleteElement_ImageBox.Location = new System.Drawing.Point(416, 12);
            this.DeleteElement_ImageBox.Name = "DeleteElement_ImageBox";
            this.DeleteElement_ImageBox.Size = new System.Drawing.Size(372, 366);
            this.DeleteElement_ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DeleteElement_ImageBox.TabIndex = 23;
            this.DeleteElement_ImageBox.TabStop = false;
            // 
            // mainFormBindingSource
            // 
            this.mainFormBindingSource.DataSource = typeof(PO_Project.MainForm);
            // 
            // mainFormBindingSource1
            // 
            this.mainFormBindingSource1.DataSource = typeof(PO_Project.MainForm);
            // 
            // DeleteElementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteElement_ListView);
            this.Controls.Add(this.DeleteElement_ImageBox);
            this.Controls.Add(this.DeleteElement_Cancel_Button);
            this.Controls.Add(this.DeleteElement_Delete_Button);
            this.Controls.Add(this.AddElement_Type_Static);
            this.Controls.Add(this.DeleteElement_ComboBox);
            this.Name = "DeleteElementForm";
            this.Text = "Usuń wybrany element";
            ((System.ComponentModel.ISupportInitialize)(this.DeleteElement_ImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DeleteElement_ComboBox;
        private System.Windows.Forms.Label AddElement_Type_Static;
        private System.Windows.Forms.Button DeleteElement_Delete_Button;
        private System.Windows.Forms.Button DeleteElement_Cancel_Button;
        private System.Windows.Forms.PictureBox DeleteElement_ImageBox;
        private System.Windows.Forms.ListView DeleteElement_ListView;
        private System.Windows.Forms.BindingSource mainFormBindingSource;
        private System.Windows.Forms.BindingSource mainFormBindingSource1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}