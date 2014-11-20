namespace ProjetCabanesGroupeA
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // lblRapport
            // 
            this.lblRapport.AutoSize = true;
            this.lblRapport.Location = new System.Drawing.Point(108, 131);
            this.lblRapport.Name = "lblRapport";
            this.lblRapport.Size = new System.Drawing.Size(35, 13);
            this.lblRapport.TabIndex = 0;
            this.lblRapport.Text = "label1";
            // 
            // dtpDateVisite
            // 
            this.dtpDateVisite.Location = new System.Drawing.Point(37, 81);
            this.dtpDateVisite.Name = "dtpDateVisite";
            this.dtpDateVisite.Size = new System.Drawing.Size(200, 20);
            this.dtpDateVisite.TabIndex = 1;
            this.dtpDateVisite.Value = new System.DateTime(2014, 11, 21, 0, 0, 0, 0);
            this.dtpDateVisite.ValueChanged += new System.EventHandler(this.dtpDateVisite_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 411);
            this.Controls.Add(this.dtpDateVisite);
            this.Controls.Add(this.lblRapport);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRapport;
        private System.Windows.Forms.DateTimePicker dtpDateVisite;
    }
}

