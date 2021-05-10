
namespace PO_Project
{
    partial class SortByForm
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
            this.SortByComboBox = new System.Windows.Forms.ComboBox();
            this.SortByLabel = new System.Windows.Forms.Label();
            this.SortByCancelButton = new System.Windows.Forms.Button();
            this.SortBySortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SortByComboBox
            // 
            this.SortByComboBox.FormattingEnabled = true;
            this.SortByComboBox.Location = new System.Drawing.Point(16, 34);
            this.SortByComboBox.Name = "SortByComboBox";
            this.SortByComboBox.Size = new System.Drawing.Size(361, 21);
            this.SortByComboBox.TabIndex = 0;
            this.SortByComboBox.SelectedIndexChanged += new System.EventHandler(this.SortByComboBox_SelectedIndexChanged);
            // 
            // SortByLabel
            // 
            this.SortByLabel.AutoSize = true;
            this.SortByLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SortByLabel.Location = new System.Drawing.Point(12, 9);
            this.SortByLabel.Name = "SortByLabel";
            this.SortByLabel.Size = new System.Drawing.Size(164, 22);
            this.SortByLabel.TabIndex = 1;
            this.SortByLabel.Text = "Rodzaj sortowania";
            // 
            // SortByCancelButton
            // 
            this.SortByCancelButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SortByCancelButton.Location = new System.Drawing.Point(298, 80);
            this.SortByCancelButton.Name = "SortByCancelButton";
            this.SortByCancelButton.Size = new System.Drawing.Size(75, 45);
            this.SortByCancelButton.TabIndex = 2;
            this.SortByCancelButton.Text = "Anuluj";
            this.SortByCancelButton.UseVisualStyleBackColor = true;
            this.SortByCancelButton.Click += new System.EventHandler(this.SortByCancelButton_Click);
            // 
            // SortBySortButton
            // 
            this.SortBySortButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SortBySortButton.Location = new System.Drawing.Point(12, 80);
            this.SortBySortButton.Name = "SortBySortButton";
            this.SortBySortButton.Size = new System.Drawing.Size(75, 45);
            this.SortBySortButton.TabIndex = 3;
            this.SortBySortButton.Text = "Sortuj";
            this.SortBySortButton.UseVisualStyleBackColor = true;
            this.SortBySortButton.Click += new System.EventHandler(this.SortBySortButton_Click);
            // 
            // SortByForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(385, 137);
            this.Controls.Add(this.SortBySortButton);
            this.Controls.Add(this.SortByCancelButton);
            this.Controls.Add(this.SortByLabel);
            this.Controls.Add(this.SortByComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SortByForm";
            this.ShowInTaskbar = false;
            this.Text = "SortByForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SortByComboBox;
        private System.Windows.Forms.Label SortByLabel;
        private System.Windows.Forms.Button SortByCancelButton;
        private System.Windows.Forms.Button SortBySortButton;
    }
}