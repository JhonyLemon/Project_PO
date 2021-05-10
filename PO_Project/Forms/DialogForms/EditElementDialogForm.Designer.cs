
namespace PO_Project
{
    partial class EditElementDialogForm
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
            this.EditElementDialog_ComboBox = new System.Windows.Forms.ComboBox();
            this.EditElementDialog_TextBox = new System.Windows.Forms.TextBox();
            this.EditElementDialog_ConfirmButton = new System.Windows.Forms.Button();
            this.EditElementDialog_FinishButton = new System.Windows.Forms.Button();
            this.EditElementDialog_FileSelectButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.EditElementDialog_Name_TextBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EditElementDialog_ComboBox
            // 
            this.EditElementDialog_ComboBox.FormattingEnabled = true;
            this.EditElementDialog_ComboBox.Location = new System.Drawing.Point(12, 12);
            this.EditElementDialog_ComboBox.Name = "EditElementDialog_ComboBox";
            this.EditElementDialog_ComboBox.Size = new System.Drawing.Size(449, 21);
            this.EditElementDialog_ComboBox.TabIndex = 0;
            this.EditElementDialog_ComboBox.SelectionChangeCommitted += new System.EventHandler(this.EditElementDialog_ComboBox_SelectionChangeCommitted);
            // 
            // EditElementDialog_TextBox
            // 
            this.EditElementDialog_TextBox.Location = new System.Drawing.Point(12, 70);
            this.EditElementDialog_TextBox.Multiline = true;
            this.EditElementDialog_TextBox.Name = "EditElementDialog_TextBox";
            this.EditElementDialog_TextBox.Size = new System.Drawing.Size(449, 69);
            this.EditElementDialog_TextBox.TabIndex = 2;
            // 
            // EditElementDialog_ConfirmButton
            // 
            this.EditElementDialog_ConfirmButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditElementDialog_ConfirmButton.Location = new System.Drawing.Point(12, 145);
            this.EditElementDialog_ConfirmButton.Name = "EditElementDialog_ConfirmButton";
            this.EditElementDialog_ConfirmButton.Size = new System.Drawing.Size(186, 39);
            this.EditElementDialog_ConfirmButton.TabIndex = 3;
            this.EditElementDialog_ConfirmButton.Text = "Zatwierdz zmiany";
            this.EditElementDialog_ConfirmButton.UseVisualStyleBackColor = true;
            this.EditElementDialog_ConfirmButton.Click += new System.EventHandler(this.EditElementDialog_ConfirmButton_Click);
            // 
            // EditElementDialog_FinishButton
            // 
            this.EditElementDialog_FinishButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditElementDialog_FinishButton.Location = new System.Drawing.Point(275, 145);
            this.EditElementDialog_FinishButton.Name = "EditElementDialog_FinishButton";
            this.EditElementDialog_FinishButton.Size = new System.Drawing.Size(186, 39);
            this.EditElementDialog_FinishButton.TabIndex = 4;
            this.EditElementDialog_FinishButton.Text = "Zakoncz edycje";
            this.EditElementDialog_FinishButton.UseVisualStyleBackColor = true;
            this.EditElementDialog_FinishButton.Click += new System.EventHandler(this.EditElementDialog_FinishButton_Click);
            // 
            // EditElementDialog_FileSelectButton
            // 
            this.EditElementDialog_FileSelectButton.Location = new System.Drawing.Point(436, 44);
            this.EditElementDialog_FileSelectButton.Name = "EditElementDialog_FileSelectButton";
            this.EditElementDialog_FileSelectButton.Size = new System.Drawing.Size(25, 23);
            this.EditElementDialog_FileSelectButton.TabIndex = 5;
            this.EditElementDialog_FileSelectButton.Text = "...";
            this.EditElementDialog_FileSelectButton.UseVisualStyleBackColor = true;
            this.EditElementDialog_FileSelectButton.Visible = false;
            this.EditElementDialog_FileSelectButton.Click += new System.EventHandler(this.EditElementDialog_FileSelectButton_Click);
            // 
            // EditElementDialog_Name_TextBox
            // 
            this.EditElementDialog_Name_TextBox.AutoSize = true;
            this.EditElementDialog_Name_TextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EditElementDialog_Name_TextBox.Location = new System.Drawing.Point(13, 44);
            this.EditElementDialog_Name_TextBox.Name = "EditElementDialog_Name_TextBox";
            this.EditElementDialog_Name_TextBox.Size = new System.Drawing.Size(140, 22);
            this.EditElementDialog_Name_TextBox.TabIndex = 6;
            this.EditElementDialog_Name_TextBox.Text = "Nazwa atrybutu";
            // 
            // EditElementDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(473, 192);
            this.Controls.Add(this.EditElementDialog_Name_TextBox);
            this.Controls.Add(this.EditElementDialog_FileSelectButton);
            this.Controls.Add(this.EditElementDialog_FinishButton);
            this.Controls.Add(this.EditElementDialog_ConfirmButton);
            this.Controls.Add(this.EditElementDialog_TextBox);
            this.Controls.Add(this.EditElementDialog_ComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditElementDialogForm";
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox EditElementDialog_ComboBox;
        private System.Windows.Forms.TextBox EditElementDialog_TextBox;
        private System.Windows.Forms.Button EditElementDialog_ConfirmButton;
        private System.Windows.Forms.Button EditElementDialog_FinishButton;
        private System.Windows.Forms.Button EditElementDialog_FileSelectButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label EditElementDialog_Name_TextBox;
    }
}