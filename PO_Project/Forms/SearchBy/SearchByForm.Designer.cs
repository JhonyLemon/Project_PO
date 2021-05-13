
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
            this.SearchByCancelButton = new System.Windows.Forms.Button();
            this.SearchByTextBox = new System.Windows.Forms.TextBox();
            this.SearchByLabelValue = new System.Windows.Forms.Label();
            this.SearchByTextBoxName = new System.Windows.Forms.TextBox();
            this.SearchByLabelName = new System.Windows.Forms.Label();
            this.SearchBySearchButton = new System.Windows.Forms.Button();
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
            // SearchByCancelButton
            // 
            this.SearchByCancelButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SearchByCancelButton.Location = new System.Drawing.Point(477, 63);
            this.SearchByCancelButton.Name = "SearchByCancelButton";
            this.SearchByCancelButton.Size = new System.Drawing.Size(203, 44);
            this.SearchByCancelButton.TabIndex = 3;
            this.SearchByCancelButton.Text = "Anuluj";
            this.SearchByCancelButton.UseVisualStyleBackColor = true;
            this.SearchByCancelButton.Click += new System.EventHandler(this.SearchByCancelButton_Click);
            // 
            // SearchByTextBox
            // 
            this.SearchByTextBox.Location = new System.Drawing.Point(467, 34);
            this.SearchByTextBox.Name = "SearchByTextBox";
            this.SearchByTextBox.Size = new System.Drawing.Size(203, 20);
            this.SearchByTextBox.TabIndex = 4;
            this.SearchByTextBox.TextChanged += new System.EventHandler(this.SearchByTextBox_TextChanged);
            // 
            // SearchByLabelValue
            // 
            this.SearchByLabelValue.AutoSize = true;
            this.SearchByLabelValue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SearchByLabelValue.Location = new System.Drawing.Point(311, 34);
            this.SearchByLabelValue.Name = "SearchByLabelValue";
            this.SearchByLabelValue.Size = new System.Drawing.Size(150, 22);
            this.SearchByLabelValue.TabIndex = 5;
            this.SearchByLabelValue.Text = "Szukana wartosc";
            // 
            // SearchByTextBoxName
            // 
            this.SearchByTextBoxName.Location = new System.Drawing.Point(158, 37);
            this.SearchByTextBoxName.Name = "SearchByTextBoxName";
            this.SearchByTextBoxName.Size = new System.Drawing.Size(144, 20);
            this.SearchByTextBoxName.TabIndex = 6;
            // 
            // SearchByLabelName
            // 
            this.SearchByLabelName.AutoSize = true;
            this.SearchByLabelName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SearchByLabelName.Location = new System.Drawing.Point(12, 34);
            this.SearchByLabelName.Name = "SearchByLabelName";
            this.SearchByLabelName.Size = new System.Drawing.Size(140, 22);
            this.SearchByLabelName.TabIndex = 7;
            this.SearchByLabelName.Text = "Nazwa atrybutu";
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
            // SearchByForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(692, 119);
            this.Controls.Add(this.SearchByLabelName);
            this.Controls.Add(this.SearchByTextBoxName);
            this.Controls.Add(this.SearchByLabelValue);
            this.Controls.Add(this.SearchByTextBox);
            this.Controls.Add(this.SearchByCancelButton);
            this.Controls.Add(this.SearchBySearchButton);
            this.Controls.Add(this.SearchByLabel);
            this.Controls.Add(this.SearchByComboBox);
            this.Name = "SearchByForm";
            this.ShowInTaskbar = false;
            this.Text = "SearchBy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SearchByComboBox;
        private System.Windows.Forms.Label SearchByLabel;
        private System.Windows.Forms.Button SearchByCancelButton;
        private System.Windows.Forms.TextBox SearchByTextBox;
        private System.Windows.Forms.Label SearchByLabelValue;
        private System.Windows.Forms.TextBox SearchByTextBoxName;
        private System.Windows.Forms.Label SearchByLabelName;
        private System.Windows.Forms.Button SearchBySearchButton;
    }
}