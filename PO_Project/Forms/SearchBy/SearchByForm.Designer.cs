
namespace PO_Project
{
    partial class SearchByForm
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
            this.SearchByComboBox = new System.Windows.Forms.ComboBox();
            this.SearchByLabel = new System.Windows.Forms.Label();
            this.SearchBySearchButton = new System.Windows.Forms.Button();
            this.SearchByCancelButton = new System.Windows.Forms.Button();
            this.SearchByTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SearchByComboBox
            // 
            this.SearchByComboBox.FormattingEnabled = true;
            this.SearchByComboBox.Location = new System.Drawing.Point(123, 10);
            this.SearchByComboBox.Name = "SearchByComboBox";
            this.SearchByComboBox.Size = new System.Drawing.Size(344, 21);
            this.SearchByComboBox.TabIndex = 0;
            this.SearchByComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchByComboBox_SelectedIndexChanged);
            // 
            // SearchByLabel
            // 
            this.SearchByLabel.AutoSize = true;
            this.SearchByLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SearchByLabel.Location = new System.Drawing.Point(12, 9);
            this.SearchByLabel.Name = "SearchByLabel";
            this.SearchByLabel.Size = new System.Drawing.Size(114, 22);
            this.SearchByLabel.TabIndex = 1;
            this.SearchByLabel.Text = "Szukaj przez";
            // 
            // SearchBySearchButton
            // 
            this.SearchBySearchButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SearchBySearchButton.Location = new System.Drawing.Point(5, 61);
            this.SearchBySearchButton.Name = "SearchBySearchButton";
            this.SearchBySearchButton.Size = new System.Drawing.Size(253, 44);
            this.SearchBySearchButton.TabIndex = 2;
            this.SearchBySearchButton.Text = "Szukaj";
            this.SearchBySearchButton.UseVisualStyleBackColor = true;
            this.SearchBySearchButton.Click += new System.EventHandler(this.SearchBySearchButton_Click);
            // 
            // SearchByCancelButton
            // 
            this.SearchByCancelButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SearchByCancelButton.Location = new System.Drawing.Point(264, 61);
            this.SearchByCancelButton.Name = "SearchByCancelButton";
            this.SearchByCancelButton.Size = new System.Drawing.Size(203, 44);
            this.SearchByCancelButton.TabIndex = 3;
            this.SearchByCancelButton.Text = "Anuluj";
            this.SearchByCancelButton.UseVisualStyleBackColor = true;
            this.SearchByCancelButton.Click += new System.EventHandler(this.SearchByCancelButton_Click);
            // 
            // SearchByTextBox
            // 
            this.SearchByTextBox.Location = new System.Drawing.Point(5, 35);
            this.SearchByTextBox.Name = "SearchByTextBox";
            this.SearchByTextBox.Size = new System.Drawing.Size(462, 20);
            this.SearchByTextBox.TabIndex = 4;
            // 
            // SearchByForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(479, 119);
            this.Controls.Add(this.SearchByTextBox);
            this.Controls.Add(this.SearchByCancelButton);
            this.Controls.Add(this.SearchBySearchButton);
            this.Controls.Add(this.SearchByLabel);
            this.Controls.Add(this.SearchByComboBox);
            this.Name = "SearchByForm";
            this.Text = "SearchBy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SearchByComboBox;
        private System.Windows.Forms.Label SearchByLabel;
        private System.Windows.Forms.Button SearchBySearchButton;
        private System.Windows.Forms.Button SearchByCancelButton;
        private System.Windows.Forms.TextBox SearchByTextBox;
    }
}