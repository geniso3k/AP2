namespace AP2
{
    partial class FormAjouterArticle
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
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.cb_Cat = new System.Windows.Forms.ComboBox();
            this.cb_Fab = new System.Windows.Forms.ComboBox();
            this.cb_Dep = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_Uni = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Location = new System.Drawing.Point(12, 261);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(351, 34);
            this.btn_Ajouter.TabIndex = 0;
            this.btn_Ajouter.Text = "Ajouter l\'article";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(12, 235);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(351, 20);
            this.txtLibelle.TabIndex = 1;
            // 
            // cb_Cat
            // 
            this.cb_Cat.FormattingEnabled = true;
            this.cb_Cat.Location = new System.Drawing.Point(12, 61);
            this.cb_Cat.Name = "cb_Cat";
            this.cb_Cat.Size = new System.Drawing.Size(351, 21);
            this.cb_Cat.TabIndex = 2;
            // 
            // cb_Fab
            // 
            this.cb_Fab.FormattingEnabled = true;
            this.cb_Fab.Location = new System.Drawing.Point(12, 107);
            this.cb_Fab.Name = "cb_Fab";
            this.cb_Fab.Size = new System.Drawing.Size(351, 21);
            this.cb_Fab.TabIndex = 4;
            // 
            // cb_Dep
            // 
            this.cb_Dep.FormattingEnabled = true;
            this.cb_Dep.Location = new System.Drawing.Point(12, 149);
            this.cb_Dep.Name = "cb_Dep";
            this.cb_Dep.Size = new System.Drawing.Size(351, 21);
            this.cb_Dep.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Catégorie de l\'article";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fabricant de l\'article";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dépôt de l\'artice";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Unité de l\'article";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Libellé de l\'article ";
            // 
            // cb_Uni
            // 
            this.cb_Uni.FormattingEnabled = true;
            this.cb_Uni.Location = new System.Drawing.Point(12, 192);
            this.cb_Uni.Name = "cb_Uni";
            this.cb_Uni.Size = new System.Drawing.Size(351, 21);
            this.cb_Uni.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(118, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ajouter un produit";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormAjouterArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 307);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_Uni);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Dep);
            this.Controls.Add(this.cb_Fab);
            this.Controls.Add(this.cb_Cat);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.btn_Ajouter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAjouterArticle";
            this.Text = "Ajouter un article";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.ComboBox cb_Cat;
        private System.Windows.Forms.ComboBox cb_Fab;
        private System.Windows.Forms.ComboBox cb_Dep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_Uni;
        private System.Windows.Forms.Label label6;
    }
}