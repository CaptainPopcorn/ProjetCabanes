namespace ProjetCabanesGroupeA
{
    partial class FrmCabanes
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRapport = new System.Windows.Forms.Label();
            this.dtpDateVisite = new System.Windows.Forms.DateTimePicker();
            this.BtnShowListCabin = new System.Windows.Forms.Button();
            this.LbxCabin = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cabaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterCabaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRapport
            // 
            this.lblRapport.AutoSize = true;
            this.lblRapport.Location = new System.Drawing.Point(171, 117);
            this.lblRapport.Name = "lblRapport";
            this.lblRapport.Size = new System.Drawing.Size(35, 13);
            this.lblRapport.TabIndex = 0;
            this.lblRapport.Text = "label1";
            // 
            // dtpDateVisite
            // 
            this.dtpDateVisite.Location = new System.Drawing.Point(174, 80);
            this.dtpDateVisite.Name = "dtpDateVisite";
            this.dtpDateVisite.Size = new System.Drawing.Size(200, 20);
            this.dtpDateVisite.TabIndex = 1;
            this.dtpDateVisite.Value = new System.DateTime(2014, 11, 21, 0, 0, 0, 0);
            this.dtpDateVisite.ValueChanged += new System.EventHandler(this.dtpDateVisite_ValueChanged);
            // 
            // BtnShowListCabin
            // 
            this.BtnShowListCabin.Location = new System.Drawing.Point(12, 282);
            this.BtnShowListCabin.Name = "BtnShowListCabin";
            this.BtnShowListCabin.Size = new System.Drawing.Size(137, 23);
            this.BtnShowListCabin.TabIndex = 0;
            this.BtnShowListCabin.Text = "Affiche Liste Cabane";
            this.BtnShowListCabin.UseVisualStyleBackColor = true;
            this.BtnShowListCabin.Click += new System.EventHandler(this.BtnShowListCabin_Click);
            // 
            // LbxCabin
            // 
            this.LbxCabin.FormattingEnabled = true;
            this.LbxCabin.Location = new System.Drawing.Point(12, 25);
            this.LbxCabin.Name = "LbxCabin";
            this.LbxCabin.Size = new System.Drawing.Size(120, 251);
            this.LbxCabin.TabIndex = 1;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(427, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cabaneToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // cabaneToolStripMenuItem
            // 
            this.cabaneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterCabaneToolStripMenuItem});
            this.cabaneToolStripMenuItem.Name = "cabaneToolStripMenuItem";
            this.cabaneToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cabaneToolStripMenuItem.Text = "Cabane";
            // 
            // ajouterCabaneToolStripMenuItem
            // 
            this.ajouterCabaneToolStripMenuItem.Name = "ajouterCabaneToolStripMenuItem";
            this.ajouterCabaneToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.ajouterCabaneToolStripMenuItem.Text = "Ajouter cabane";
            this.ajouterCabaneToolStripMenuItem.Click += new System.EventHandler(this.ajouterCabaneToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 411);
            this.Controls.Add(this.dtpDateVisite);
            this.Controls.Add(this.lblRapport);
            this.Controls.Add(this.LbxCabin);
            this.Controls.Add(this.BtnShowListCabin);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Cabanes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRapport;
        private System.Windows.Forms.DateTimePicker dtpDateVisite;
        private System.Windows.Forms.Button BtnShowListCabin;
        private System.Windows.Forms.ListBox LbxCabin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cabaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterCabaneToolStripMenuItem;

    }
}

