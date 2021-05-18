
namespace PO_Project
{
    partial class AddAttributeDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAttributeDialog));
            this.AddAttribute_NameTextBox = new System.Windows.Forms.TextBox();
            this.AddAttribute_ValueTextBox = new System.Windows.Forms.TextBox();
            this.AddAttribute_NameLabel = new System.Windows.Forms.Label();
            this.AddAttribute_ValueLabel = new System.Windows.Forms.Label();
            this.AddAttribute_AddButton = new System.Windows.Forms.Button();
            this.AddAttribute_CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddAttribute_NameTextBox
            // 
            this.AddAttribute_NameTextBox.Location = new System.Drawing.Point(12, 34);
            this.AddAttribute_NameTextBox.Name = "AddAttribute_NameTextBox";
            this.AddAttribute_NameTextBox.Size = new System.Drawing.Size(385, 20);
            this.AddAttribute_NameTextBox.TabIndex = 0;
            // 
            // AddAttribute_ValueTextBox
            // 
            this.AddAttribute_ValueTextBox.Location = new System.Drawing.Point(12, 105);
            this.AddAttribute_ValueTextBox.Multiline = true;
            this.AddAttribute_ValueTextBox.Name = "AddAttribute_ValueTextBox";
            this.AddAttribute_ValueTextBox.Size = new System.Drawing.Size(385, 58);
            this.AddAttribute_ValueTextBox.TabIndex = 1;
            // 
            // AddAttribute_NameLabel
            // 
            this.AddAttribute_NameLabel.AutoSize = true;
            this.AddAttribute_NameLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddAttribute_NameLabel.Location = new System.Drawing.Point(12, 9);
            this.AddAttribute_NameLabel.Name = "AddAttribute_NameLabel";
            this.AddAttribute_NameLabel.Size = new System.Drawing.Size(147, 22);
            this.AddAttribute_NameLabel.TabIndex = 2;
            this.AddAttribute_NameLabel.Text = "Nazwa Atrybutu:";
            // 
            // AddAttribute_ValueLabel
            // 
            this.AddAttribute_ValueLabel.AutoSize = true;
            this.AddAttribute_ValueLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddAttribute_ValueLabel.Location = new System.Drawing.Point(8, 66);
            this.AddAttribute_ValueLabel.Name = "AddAttribute_ValueLabel";
            this.AddAttribute_ValueLabel.Size = new System.Drawing.Size(158, 22);
            this.AddAttribute_ValueLabel.TabIndex = 3;
            this.AddAttribute_ValueLabel.Text = "Wartosc atrybutu:";
            // 
            // AddAttribute_AddButton
            // 
            this.AddAttribute_AddButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddAttribute_AddButton.Location = new System.Drawing.Point(12, 169);
            this.AddAttribute_AddButton.Name = "AddAttribute_AddButton";
            this.AddAttribute_AddButton.Size = new System.Drawing.Size(100, 38);
            this.AddAttribute_AddButton.TabIndex = 4;
            this.AddAttribute_AddButton.Text = "Dodaj";
            this.AddAttribute_AddButton.UseVisualStyleBackColor = true;
            this.AddAttribute_AddButton.Click += new System.EventHandler(this.AddAttribute_AddButton_Click);
            // 
            // AddAttribute_CancelButton
            // 
            this.AddAttribute_CancelButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddAttribute_CancelButton.Location = new System.Drawing.Point(297, 169);
            this.AddAttribute_CancelButton.Name = "AddAttribute_CancelButton";
            this.AddAttribute_CancelButton.Size = new System.Drawing.Size(100, 38);
            this.AddAttribute_CancelButton.TabIndex = 5;
            this.AddAttribute_CancelButton.Text = "Anuluj";
            this.AddAttribute_CancelButton.UseVisualStyleBackColor = true;
            this.AddAttribute_CancelButton.Click += new System.EventHandler(this.AddAttribute_CancelButton_Click);
            // 
            // AddAttributeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(409, 219);
            this.Controls.Add(this.AddAttribute_CancelButton);
            this.Controls.Add(this.AddAttribute_AddButton);
            this.Controls.Add(this.AddAttribute_ValueLabel);
            this.Controls.Add(this.AddAttribute_NameLabel);
            this.Controls.Add(this.AddAttribute_ValueTextBox);
            this.Controls.Add(this.AddAttribute_NameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddAttributeDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Dodaj atrybut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddAttribute_NameTextBox;
        private System.Windows.Forms.TextBox AddAttribute_ValueTextBox;
        private System.Windows.Forms.Label AddAttribute_NameLabel;
        private System.Windows.Forms.Label AddAttribute_ValueLabel;
        private System.Windows.Forms.Button AddAttribute_AddButton;
        private System.Windows.Forms.Button AddAttribute_CancelButton;
    }
}