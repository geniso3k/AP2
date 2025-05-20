namespace AP2
{
    partial class FormAjouterUni
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codeCat = new System.Windows.Forms.TextBox();
            this.txt_libelle = new System.Windows.Forms.TextBox();
            this.btnAjt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Référence de l\'unité (UNIxx)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Libellé de l\'unité";
            // 
            // txt_codeCat
            // 
            this.txt_codeCat.Location = new System.Drawing.Point(12, 70);
            this.txt_codeCat.Name = "txt_codeCat";
            this.txt_codeCat.Size = new System.Drawing.Size(242, 20);
            this.txt_codeCat.TabIndex = 2;
            // 
            // txt_libelle
            // 
            this.txt_libelle.Location = new System.Drawing.Point(12, 120);
            this.txt_libelle.Name = "txt_libelle";
            this.txt_libelle.Size = new System.Drawing.Size(242, 20);
            this.txt_libelle.TabIndex = 3;
            // 
            // btnAjt
            // 
            this.btnAjt.Location = new System.Drawing.Point(12, 161);
            this.btnAjt.Name = "btnAjt";
            this.btnAjt.Size = new System.Drawing.Size(242, 51);
            this.btnAjt.TabIndex = 4;
            this.btnAjt.Text = "Ajouter catégorie";
            this.btnAjt.UseVisualStyleBackColor = true;
            this.btnAjt.Click += new System.EventHandler(this.btnAjt_Click);
            // 
            // FormAjouterUni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 224);
            this.Controls.Add(this.btnAjt);
            this.Controls.Add(this.txt_libelle);
            this.Controls.Add(this.txt_codeCat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAjouterUni";
            this.Text = "FormAjouterUni";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codeCat;
        private System.Windows.Forms.TextBox txt_libelle;
        private System.Windows.Forms.Button btnAjt;
    }
}