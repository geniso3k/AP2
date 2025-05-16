namespace AP2
{
    partial class FormAjouterDepot
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_refD = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_ville = new System.Windows.Forms.TextBox();
            this.txt_pays = new System.Windows.Forms.TextBox();
            this.txt_la = new System.Windows.Forms.TextBox();
            this.txt_lo = new System.Windows.Forms.TextBox();
            this.btn_AjouterDep = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Référence du dépot unique (DEPxxx)";
            // 
            // txt_refD
            // 
            this.txt_refD.Location = new System.Drawing.Point(12, 76);
            this.txt_refD.Name = "txt_refD";
            this.txt_refD.Size = new System.Drawing.Size(204, 20);
            this.txt_refD.TabIndex = 1;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(12, 126);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(204, 20);
            this.txt_nom.TabIndex = 2;
            // 
            // txt_ville
            // 
            this.txt_ville.Location = new System.Drawing.Point(12, 174);
            this.txt_ville.Name = "txt_ville";
            this.txt_ville.Size = new System.Drawing.Size(204, 20);
            this.txt_ville.TabIndex = 3;
            // 
            // txt_pays
            // 
            this.txt_pays.Location = new System.Drawing.Point(12, 223);
            this.txt_pays.Name = "txt_pays";
            this.txt_pays.Size = new System.Drawing.Size(204, 20);
            this.txt_pays.TabIndex = 4;
            // 
            // txt_la
            // 
            this.txt_la.Location = new System.Drawing.Point(12, 274);
            this.txt_la.Name = "txt_la";
            this.txt_la.Size = new System.Drawing.Size(204, 20);
            this.txt_la.TabIndex = 5;
            // 
            // txt_lo
            // 
            this.txt_lo.Location = new System.Drawing.Point(12, 324);
            this.txt_lo.Name = "txt_lo";
            this.txt_lo.Size = new System.Drawing.Size(204, 20);
            this.txt_lo.TabIndex = 6;
            // 
            // btn_AjouterDep
            // 
            this.btn_AjouterDep.Location = new System.Drawing.Point(12, 374);
            this.btn_AjouterDep.Name = "btn_AjouterDep";
            this.btn_AjouterDep.Size = new System.Drawing.Size(204, 46);
            this.btn_AjouterDep.TabIndex = 7;
            this.btn_AjouterDep.Text = "Ajouter dépôt";
            this.btn_AjouterDep.UseVisualStyleBackColor = true;
            this.btn_AjouterDep.Click += new System.EventHandler(this.btn_AjouterDep_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ville";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pays";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Lattitude";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Longitude";
            // 
            // FormAjouterDepot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 432);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_AjouterDep);
            this.Controls.Add(this.txt_lo);
            this.Controls.Add(this.txt_la);
            this.Controls.Add(this.txt_pays);
            this.Controls.Add(this.txt_ville);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.txt_refD);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAjouterDepot";
            this.Text = "FormAjouterDepot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_refD;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_ville;
        private System.Windows.Forms.TextBox txt_pays;
        private System.Windows.Forms.TextBox txt_la;
        private System.Windows.Forms.TextBox txt_lo;
        private System.Windows.Forms.Button btn_AjouterDep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}