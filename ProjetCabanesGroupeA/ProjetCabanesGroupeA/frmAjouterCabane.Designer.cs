namespace ProjetCabanesGroupeA
{
    partial class frmAjouterCabane
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
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbNbBed = new System.Windows.Forms.TextBox();
            this.txbTarif = new System.Windows.Forms.TextBox();
            this.txbAltitude = new System.Windows.Forms.TextBox();
            this.cbxShower = new System.Windows.Forms.CheckBox();
            this.btnValide = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(12, 32);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 20);
            this.txbName.TabIndex = 0;
            // 
            // txbNbBed
            // 
            this.txbNbBed.Location = new System.Drawing.Point(147, 32);
            this.txbNbBed.Name = "txbNbBed";
            this.txbNbBed.Size = new System.Drawing.Size(100, 20);
            this.txbNbBed.TabIndex = 1;
            // 
            // txbTarif
            // 
            this.txbTarif.Location = new System.Drawing.Point(12, 81);
            this.txbTarif.Name = "txbTarif";
            this.txbTarif.Size = new System.Drawing.Size(100, 20);
            this.txbTarif.TabIndex = 2;
            // 
            // txbAltitude
            // 
            this.txbAltitude.Location = new System.Drawing.Point(147, 81);
            this.txbAltitude.Name = "txbAltitude";
            this.txbAltitude.Size = new System.Drawing.Size(100, 20);
            this.txbAltitude.TabIndex = 3;
            // 
            // cbxShower
            // 
            this.cbxShower.AutoSize = true;
            this.cbxShower.Location = new System.Drawing.Point(13, 120);
            this.cbxShower.Name = "cbxShower";
            this.cbxShower.Size = new System.Drawing.Size(64, 17);
            this.cbxShower.TabIndex = 4;
            this.cbxShower.Text = "Douche";
            this.cbxShower.UseVisualStyleBackColor = true;
            // 
            // btnValide
            // 
            this.btnValide.Location = new System.Drawing.Point(12, 155);
            this.btnValide.Name = "btnValide";
            this.btnValide.Size = new System.Drawing.Size(75, 23);
            this.btnValide.TabIndex = 5;
            this.btnValide.Text = "Valider";
            this.btnValide.UseVisualStyleBackColor = true;
            this.btnValide.Click += new System.EventHandler(this.btnValide_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(172, 155);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "Annuler";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre de lit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tarif";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Altitude";
            // 
            // frmAjouterCabane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 198);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.btnValide);
            this.Controls.Add(this.cbxShower);
            this.Controls.Add(this.txbAltitude);
            this.Controls.Add(this.txbTarif);
            this.Controls.Add(this.txbNbBed);
            this.Controls.Add(this.txbName);
            this.Name = "frmAjouterCabane";
            this.Text = "Ajouter Cabane";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbNbBed;
        private System.Windows.Forms.TextBox txbTarif;
        private System.Windows.Forms.TextBox txbAltitude;
        private System.Windows.Forms.CheckBox cbxShower;
        private System.Windows.Forms.Button btnValide;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}