namespace ProjetCabanesGroupeA
{
    partial class frmAjoutCabane
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
            this.btnAddCabane = new System.Windows.Forms.Button();
            this.txtbNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbNbLit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbTarif = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbAltitude = new System.Windows.Forms.TextBox();
            this.ckbDouche = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnAddCabane
            // 
            this.btnAddCabane.Location = new System.Drawing.Point(179, 104);
            this.btnAddCabane.Name = "btnAddCabane";
            this.btnAddCabane.Size = new System.Drawing.Size(75, 23);
            this.btnAddCabane.TabIndex = 0;
            this.btnAddCabane.Text = "Ajouter";
            this.btnAddCabane.UseVisualStyleBackColor = true;
            this.btnAddCabane.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbNom
            // 
            this.txtbNom.Location = new System.Drawing.Point(8, 29);
            this.txtbNom.Name = "txtbNom";
            this.txtbNom.Size = new System.Drawing.Size(100, 20);
            this.txtbNom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre de lit";
            // 
            // txtbNbLit
            // 
            this.txtbNbLit.Location = new System.Drawing.Point(154, 29);
            this.txtbNbLit.MaxLength = 3;
            this.txtbNbLit.Name = "txtbNbLit";
            this.txtbNbLit.Size = new System.Drawing.Size(100, 20);
            this.txtbNbLit.TabIndex = 3;
            this.txtbNbLit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNbLit_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tarif";
            // 
            // txtbTarif
            // 
            this.txtbTarif.Location = new System.Drawing.Point(8, 74);
            this.txtbTarif.MaxLength = 7;
            this.txtbTarif.Name = "txtbTarif";
            this.txtbTarif.Size = new System.Drawing.Size(100, 20);
            this.txtbTarif.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Altitude (m)";
            // 
            // txtbAltitude
            // 
            this.txtbAltitude.Location = new System.Drawing.Point(154, 74);
            this.txtbAltitude.MaxLength = 5;
            this.txtbAltitude.Name = "txtbAltitude";
            this.txtbAltitude.Size = new System.Drawing.Size(100, 20);
            this.txtbAltitude.TabIndex = 7;
            this.txtbAltitude.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNbLit_KeyPress);
            // 
            // ckbDouche
            // 
            this.ckbDouche.AutoSize = true;
            this.ckbDouche.Location = new System.Drawing.Point(8, 110);
            this.ckbDouche.Name = "ckbDouche";
            this.ckbDouche.Size = new System.Drawing.Size(64, 17);
            this.ckbDouche.TabIndex = 11;
            this.ckbDouche.Text = "Douche";
            this.ckbDouche.UseVisualStyleBackColor = true;
            // 
            // frmAjoutCabane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 139);
            this.Controls.Add(this.ckbDouche);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbAltitude);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbTarif);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbNbLit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbNom);
            this.Controls.Add(this.btnAddCabane);
            this.Name = "frmAjoutCabane";
            this.Text = "Ajouter une cabane";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCabane;
        private System.Windows.Forms.TextBox txtbNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbNbLit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbTarif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbAltitude;
        private System.Windows.Forms.CheckBox ckbDouche;
    }
}