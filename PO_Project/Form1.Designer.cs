
namespace PO_Project
{
    partial class Form1
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
            this.Nowa_Biblioteka = new System.Windows.Forms.MenuItem();
            this.Otworz_Biblioteke = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.Dodaj_Element = new System.Windows.Forms.MenuItem();
            this.Usun_Element = new System.Windows.Forms.MenuItem();
            this.Edytuj_Element = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.Zmien_Widok = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.Instrukcja = new System.Windows.Forms.MenuItem();
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
            this.menuItem2,
            this.menuItem3,
            this.menuItem4});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Nowa_Biblioteka,
            this.Otworz_Biblioteke});
            this.menuItem1.Text = "Plik";
            // 
            // Nowa_Biblioteka
            // 
            this.Nowa_Biblioteka.Index = 0;
            this.Nowa_Biblioteka.Text = "Nowa Biblioteka";
            this.Nowa_Biblioteka.Click += new System.EventHandler(this.Nowa_Biblioteka_Click);
            // 
            // Otworz_Biblioteke
            // 
            this.Otworz_Biblioteke.Index = 1;
            this.Otworz_Biblioteke.Text = "Otworz Biblioteke";
            this.Otworz_Biblioteke.Click += new System.EventHandler(this.Otworz_Biblioteke_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Dodaj_Element,
            this.Usun_Element,
            this.Edytuj_Element});
            this.menuItem2.Text = "Edycja";
            // 
            // Dodaj_Element
            // 
            this.Dodaj_Element.Index = 0;
            this.Dodaj_Element.Text = "Dodaj ";
            this.Dodaj_Element.Click += new System.EventHandler(this.Dodaj_Element_Click);
            // 
            // Usun_Element
            // 
            this.Usun_Element.Index = 1;
            this.Usun_Element.Text = "Usuń";
            this.Usun_Element.Click += new System.EventHandler(this.Usun_Element_Click);
            // 
            // Edytuj_Element
            // 
            this.Edytuj_Element.Index = 2;
            this.Edytuj_Element.Text = "Edytuj";
            this.Edytuj_Element.Click += new System.EventHandler(this.Edytuj_Element_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Zmien_Widok});
            this.menuItem3.Text = "Widok";
            // 
            // Zmien_Widok
            // 
            this.Zmien_Widok.Index = 0;
            this.Zmien_Widok.Text = "Zmień Widok";
            this.Zmien_Widok.Click += new System.EventHandler(this.Zmien_Widok_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 3;
            this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Instrukcja});
            this.menuItem4.Text = "Pomoc";
            // 
            // Instrukcja
            // 
            this.Instrukcja.Index = 0;
            this.Instrukcja.Text = "Instrukcja";
            this.Instrukcja.Click += new System.EventHandler(this.Instrukcja_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Podwojny_Kontener);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Domowa Biblioteczka";
            this.Podwojny_Kontener.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Podwojny_Kontener)).EndInit();
            this.Podwojny_Kontener.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem Nowa_Biblioteka;
        private System.Windows.Forms.MenuItem Otworz_Biblioteke;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem Dodaj_Element;
        private System.Windows.Forms.MenuItem Usun_Element;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem Edytuj_Element;
        private System.Windows.Forms.MenuItem Zmien_Widok;
        private System.Windows.Forms.MenuItem Instrukcja;
        private System.Windows.Forms.SplitContainer Podwojny_Kontener;
        private System.Windows.Forms.ListView Lista_Obrazkow;
    }
}

