
namespace PO_Project
{
    partial class DeleteElementDialog
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
            this.DeleteElementDialog_Cancel_Button = new System.Windows.Forms.Button();
            this.DeleteElementDialog_Label = new System.Windows.Forms.Label();
            this.DeleteElementDialog_Delete_Button = new System.Windows.Forms.Button();
            this.DeleteElementDIalog_ComboBox = new System.Windows.Forms.ComboBox();
            this.DeleteElementDialog_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DeleteElementDialog_Cancel_Button
            // 
            this.DeleteElementDialog_Cancel_Button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteElementDialog_Cancel_Button.Location = new System.Drawing.Point(245, 88);
            this.DeleteElementDialog_Cancel_Button.Name = "DeleteElementDialog_Cancel_Button";
            this.DeleteElementDialog_Cancel_Button.Size = new System.Drawing.Size(145, 61);
            this.DeleteElementDialog_Cancel_Button.TabIndex = 3;
            this.DeleteElementDialog_Cancel_Button.Text = "Anuluj";
            this.DeleteElementDialog_Cancel_Button.UseVisualStyleBackColor = true;
            this.DeleteElementDialog_Cancel_Button.Click += new System.EventHandler(this.DeleteElementDialog_Cancel_Button_Click);
            // 
            // DeleteElementDialog_Label
            // 
            this.DeleteElementDialog_Label.AutoSize = true;
            this.DeleteElementDialog_Label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteElementDialog_Label.Location = new System.Drawing.Point(8, 9);
            this.DeleteElementDialog_Label.Name = "DeleteElementDialog_Label";
            this.DeleteElementDialog_Label.Size = new System.Drawing.Size(257, 22);
            this.DeleteElementDialog_Label.TabIndex = 4;
            this.DeleteElementDialog_Label.Text = "Wybierz atrybut do usuniencia";
            // 
            // DeleteElementDialog_Delete_Button
            // 
            this.DeleteElementDialog_Delete_Button.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeleteElementDialog_Delete_Button.Location = new System.Drawing.Point(12, 88);
            this.DeleteElementDialog_Delete_Button.Name = "DeleteElementDialog_Delete_Button";
            this.DeleteElementDialog_Delete_Button.Size = new System.Drawing.Size(145, 61);
            this.DeleteElementDialog_Delete_Button.TabIndex = 2;
            this.DeleteElementDialog_Delete_Button.Text = "Usuń";
            this.DeleteElementDialog_Delete_Button.UseVisualStyleBackColor = true;
            this.DeleteElementDialog_Delete_Button.Click += new System.EventHandler(this.DeleteElementDialog_Delete_Button_Click);
            // 
            // DeleteElementDIalog_ComboBox
            // 
            this.DeleteElementDIalog_ComboBox.FormattingEnabled = true;
            this.DeleteElementDIalog_ComboBox.Location = new System.Drawing.Point(12, 34);
            this.DeleteElementDIalog_ComboBox.Name = "DeleteElementDIalog_ComboBox";
            this.DeleteElementDIalog_ComboBox.Size = new System.Drawing.Size(378, 21);
            this.DeleteElementDIalog_ComboBox.TabIndex = 5;
            this.DeleteElementDIalog_ComboBox.SelectedIndexChanged += new System.EventHandler(this.DeleteElementDIalog_ComboBox_SelectedIndexChanged);
            // 
            // DeleteElementDialog_TextBox
            // 
            this.DeleteElementDialog_TextBox.Location = new System.Drawing.Point(13, 62);
            this.DeleteElementDialog_TextBox.Name = "DeleteElementDialog_TextBox";
            this.DeleteElementDialog_TextBox.ReadOnly = true;
            this.DeleteElementDialog_TextBox.Size = new System.Drawing.Size(377, 20);
            this.DeleteElementDialog_TextBox.TabIndex = 6;
            // 
            // EditElementFormDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(402, 156);
            this.Controls.Add(this.DeleteElementDialog_TextBox);
            this.Controls.Add(this.DeleteElementDIalog_ComboBox);
            this.Controls.Add(this.DeleteElementDialog_Label);
            this.Controls.Add(this.DeleteElementDialog_Cancel_Button);
            this.Controls.Add(this.DeleteElementDialog_Delete_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditElementFormDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DeleteElementDialog_Cancel_Button;
        private System.Windows.Forms.Label DeleteElementDialog_Label;
        private System.Windows.Forms.Button DeleteElementDialog_Delete_Button;
        private System.Windows.Forms.ComboBox DeleteElementDIalog_ComboBox;
        private System.Windows.Forms.TextBox DeleteElementDialog_TextBox;
    }
}