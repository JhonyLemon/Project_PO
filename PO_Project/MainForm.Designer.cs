
namespace PO_Project
{
    partial class MainForm
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
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.Add_Button = new System.Windows.Forms.MenuItem();
            this.Edit_Button = new System.Windows.Forms.MenuItem();
            this.Delete_Button = new System.Windows.Forms.MenuItem();
            this.Search_Button = new System.Windows.Forms.MenuItem();
            this.Sort_Button = new System.Windows.Forms.MenuItem();
            this.Filter_Button = new System.Windows.Forms.MenuItem();
            this.Podwojny_Kontener = new System.Windows.Forms.SplitContainer();
            this.Lista_Obrazkow = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.Podwojny_Kontener)).BeginInit();
            this.Podwojny_Kontener.Panel1.SuspendLayout();
            this.Podwojny_Kontener.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.Search_Button,
            this.Sort_Button,
            this.Filter_Button});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Add_Button,
            this.Edit_Button,
            this.Delete_Button});
            this.menuItem1.Text = "Edycja";
            // 
            // Add_Button
            // 
            this.Add_Button.Index = 0;
            this.Add_Button.Text = "Dodaj";
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Edit_Button
            // 
            this.Edit_Button.Index = 1;
            this.Edit_Button.Text = "Edytuj";
            this.Edit_Button.Click += new System.EventHandler(this.Edit_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Index = 2;
            this.Delete_Button.Text = "Usun";
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Search_Button
            // 
            this.Search_Button.Index = 1;
            this.Search_Button.Text = "Szukaj";
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // Sort_Button
            // 
            this.Sort_Button.Index = 2;
            this.Sort_Button.Text = "Sortuj";
            this.Sort_Button.Click += new System.EventHandler(this.Sort_Button_Click);
            // 
            // Filter_Button
            // 
            this.Filter_Button.Index = 3;
            this.Filter_Button.Text = "Filtruj";
            this.Filter_Button.Click += new System.EventHandler(this.Filter_Button_Click);
            // 
            // Podwojny_Kontener
            // 
            this.Podwojny_Kontener.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Podwojny_Kontener.Location = new System.Drawing.Point(0, 0);
            this.Podwojny_Kontener.Name = "Podwojny_Kontener";
            this.Podwojny_Kontener.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Podwojny_Kontener.Panel1
            // 
            this.Podwojny_Kontener.Panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.ListItem;
            this.Podwojny_Kontener.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Podwojny_Kontener.Panel1.Controls.Add(this.Lista_Obrazkow);
            this.Podwojny_Kontener.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Podwojny_Kontener.Panel1MinSize = 50;
            // 
            // Podwojny_Kontener.Panel2
            // 
            this.Podwojny_Kontener.Panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.Podwojny_Kontener.Panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.Podwojny_Kontener.Panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Podwojny_Kontener.Panel2MinSize = 50;
            this.Podwojny_Kontener.Size = new System.Drawing.Size(800, 450);
            this.Podwojny_Kontener.SplitterDistance = 250;
            this.Podwojny_Kontener.TabIndex = 1;
            // 
            // Lista_Obrazkow
            // 
            this.Lista_Obrazkow.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Lista_Obrazkow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lista_Obrazkow.ForeColor = System.Drawing.SystemColors.Menu;
            this.Lista_Obrazkow.HideSelection = false;
            this.Lista_Obrazkow.Location = new System.Drawing.Point(0, 0);
            this.Lista_Obrazkow.Name = "Lista_Obrazkow";
            this.Lista_Obrazkow.Size = new System.Drawing.Size(800, 250);
            this.Lista_Obrazkow.TabIndex = 0;
            this.Lista_Obrazkow.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Podwojny_Kontener);
            this.Menu = this.mainMenu1;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Domowa Biblioteczka";
            this.Podwojny_Kontener.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Podwojny_Kontener)).EndInit();
            this.Podwojny_Kontener.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem Search_Button;
        private System.Windows.Forms.SplitContainer Podwojny_Kontener;
        private System.Windows.Forms.ListView Lista_Obrazkow;
        private System.Windows.Forms.MenuItem Add_Button;
        private System.Windows.Forms.MenuItem Edit_Button;
        private System.Windows.Forms.MenuItem Delete_Button;
        private System.Windows.Forms.MenuItem Sort_Button;
        private System.Windows.Forms.MenuItem Filter_Button;
    }
}

