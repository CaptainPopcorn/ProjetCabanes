namespace ProjetCabanesGroupeA
{
    partial class frmRappCabane
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbNon = new System.Windows.Forms.RadioButton();
            this.rdbOui = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxListeCabanes = new System.Windows.Forms.ComboBox();
            this.tbxRapportsVisites = new System.Windows.Forms.TextBox();
            this.dtpDateVisite = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbNon);
            this.groupBox1.Controls.Add(this.rdbOui);
            this.groupBox1.Location = new System.Drawing.Point(244, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 44);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date de la visite connue ?";
            // 
            // rdbNon
            // 
            this.rdbNon.AutoSize = true;
            this.rdbNon.Location = new System.Drawing.Point(97, 19);
            this.rdbNon.Name = "rdbNon";
            this.rdbNon.Size = new System.Drawing.Size(45, 17);
            this.rdbNon.TabIndex = 8;
            this.rdbNon.Text = "Non";
            this.rdbNon.UseVisualStyleBackColor = true;
            // 
            // rdbOui
            // 
            this.rdbOui.AutoSize = true;
            this.rdbOui.Checked = true;
            this.rdbOui.Location = new System.Drawing.Point(22, 19);
            this.rdbOui.Name = "rdbOui";
            this.rdbOui.Size = new System.Drawing.Size(41, 17);
            this.rdbOui.TabIndex = 7;
            this.rdbOui.TabStop = true;
            this.rdbOui.Text = "Oui";
            this.rdbOui.UseVisualStyleBackColor = true;
            this.rdbOui.CheckedChanged += new System.EventHandler(this.rdbOui_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Date de la visite :";
            // 
            // cbxListeCabanes
            // 
            this.cbxListeCabanes.Enabled = false;
            this.cbxListeCabanes.FormattingEnabled = true;
            this.cbxListeCabanes.Location = new System.Drawing.Point(231, 70);
            this.cbxListeCabanes.Name = "cbxListeCabanes";
            this.cbxListeCabanes.Size = new System.Drawing.Size(200, 21);
            this.cbxListeCabanes.TabIndex = 12;
            this.cbxListeCabanes.SelectedIndexChanged += new System.EventHandler(this.cbxListeCabanes_SelectedIndexChanged);
            // 
            // tbxRapportsVisites
            // 
            this.tbxRapportsVisites.Location = new System.Drawing.Point(15, 131);
            this.tbxRapportsVisites.Multiline = true;
            this.tbxRapportsVisites.Name = "tbxRapportsVisites";
            this.tbxRapportsVisites.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxRapportsVisites.Size = new System.Drawing.Size(416, 267);
            this.tbxRapportsVisites.TabIndex = 11;
            // 
            // dtpDateVisite
            // 
            this.dtpDateVisite.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateVisite.Location = new System.Drawing.Point(15, 71);
            this.dtpDateVisite.Name = "dtpDateVisite";
            this.dtpDateVisite.Size = new System.Drawing.Size(200, 20);
            this.dtpDateVisite.TabIndex = 10;
            this.dtpDateVisite.Value = new System.DateTime(2014, 11, 21, 0, 0, 0, 0);
            this.dtpDateVisite.ValueChanged += new System.EventHandler(this.dtpDateVisite_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cabane visitée :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Rapport de la visite :";
            // 
            // frmRappCabane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 417);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxListeCabanes);
            this.Controls.Add(this.tbxRapportsVisites);
            this.Controls.Add(this.dtpDateVisite);
            this.Name = "frmRappCabane";
            this.Text = "frmRappCabane";
            this.Load += new System.EventHandler(this.frmRappCabane_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbNon;
        private System.Windows.Forms.RadioButton rdbOui;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxListeCabanes;
        private System.Windows.Forms.TextBox tbxRapportsVisites;
        private System.Windows.Forms.DateTimePicker dtpDateVisite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

    }
}