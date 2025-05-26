namespace AP2
{
    partial class FormAjouterInv
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbArticle = new System.Windows.Forms.ComboBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.txtQtt = new System.Windows.Forms.TextBox();
            this.cbDep = new System.Windows.Forms.ComboBox();
            this.btnAjouterInv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Article souhaité pour l\'inventaire";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "date et heure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantité";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dépôt souhaité";
            // 
            // cbArticle
            // 
            this.cbArticle.FormattingEnabled = true;
            this.cbArticle.Location = new System.Drawing.Point(13, 75);
            this.cbArticle.Name = "cbArticle";
            this.cbArticle.Size = new System.Drawing.Size(247, 21);
            this.cbArticle.TabIndex = 4;
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(16, 125);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(247, 20);
            this.dtpTime.TabIndex = 5;
            // 
            // txtQtt
            // 
            this.txtQtt.Location = new System.Drawing.Point(13, 182);
            this.txtQtt.Name = "txtQtt";
            this.txtQtt.Size = new System.Drawing.Size(250, 20);
            this.txtQtt.TabIndex = 6;
            // 
            // cbDep
            // 
            this.cbDep.FormattingEnabled = true;
            this.cbDep.Location = new System.Drawing.Point(13, 241);
            this.cbDep.Name = "cbDep";
            this.cbDep.Size = new System.Drawing.Size(250, 21);
            this.cbDep.TabIndex = 7;
            // 
            // btnAjouterInv
            // 
            this.btnAjouterInv.Location = new System.Drawing.Point(13, 293);
            this.btnAjouterInv.Name = "btnAjouterInv";
            this.btnAjouterInv.Size = new System.Drawing.Size(250, 54);
            this.btnAjouterInv.TabIndex = 8;
            this.btnAjouterInv.Text = "Ajouter l\'inventaire";
            this.btnAjouterInv.UseVisualStyleBackColor = true;
            this.btnAjouterInv.Click += new System.EventHandler(this.btnAjouterInv_Click);
            // 
            // FormAjouterInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 369);
            this.Controls.Add(this.btnAjouterInv);
            this.Controls.Add(this.cbDep);
            this.Controls.Add(this.txtQtt);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.cbArticle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAjouterInv";
            this.Text = "FormAjouterInv";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbArticle;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.TextBox txtQtt;
        private System.Windows.Forms.ComboBox cbDep;
        private System.Windows.Forms.Button btnAjouterInv;
    }
}