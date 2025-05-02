namespace AP2
{
    partial class FormAjouterMvt
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
            this.cb_MvtArticle = new System.Windows.Forms.ComboBox();
            this.cb_MvtDepot = new System.Windows.Forms.ComboBox();
            this.txt_MvtQtt = new System.Windows.Forms.TextBox();
            this.btnValiderMvt = new System.Windows.Forms.Button();
            this.date_Mvt = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_MvtArticle
            // 
            this.cb_MvtArticle.FormattingEnabled = true;
            this.cb_MvtArticle.Location = new System.Drawing.Point(27, 71);
            this.cb_MvtArticle.Name = "cb_MvtArticle";
            this.cb_MvtArticle.Size = new System.Drawing.Size(200, 21);
            this.cb_MvtArticle.TabIndex = 0;
            // 
            // cb_MvtDepot
            // 
            this.cb_MvtDepot.FormattingEnabled = true;
            this.cb_MvtDepot.Location = new System.Drawing.Point(27, 121);
            this.cb_MvtDepot.Name = "cb_MvtDepot";
            this.cb_MvtDepot.Size = new System.Drawing.Size(200, 21);
            this.cb_MvtDepot.TabIndex = 1;
            // 
            // txt_MvtQtt
            // 
            this.txt_MvtQtt.Location = new System.Drawing.Point(27, 166);
            this.txt_MvtQtt.Name = "txt_MvtQtt";
            this.txt_MvtQtt.Size = new System.Drawing.Size(200, 20);
            this.txt_MvtQtt.TabIndex = 2;
            // 
            // btnValiderMvt
            // 
            this.btnValiderMvt.Location = new System.Drawing.Point(27, 276);
            this.btnValiderMvt.Name = "btnValiderMvt";
            this.btnValiderMvt.Size = new System.Drawing.Size(75, 23);
            this.btnValiderMvt.TabIndex = 3;
            this.btnValiderMvt.Text = "Valider";
            this.btnValiderMvt.UseVisualStyleBackColor = true;
            this.btnValiderMvt.Click += new System.EventHandler(this.btnValiderMvt_Click);
            // 
            // date_Mvt
            // 
            this.date_Mvt.Location = new System.Drawing.Point(27, 225);
            this.date_Mvt.Name = "date_Mvt";
            this.date_Mvt.Size = new System.Drawing.Size(200, 20);
            this.date_Mvt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Article";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dépôt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantité (positive ou négative)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date/heure";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ajouter un mouvement";
            // 
            // FormAjouterMvt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(267, 353);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date_Mvt);
            this.Controls.Add(this.btnValiderMvt);
            this.Controls.Add(this.txt_MvtQtt);
            this.Controls.Add(this.cb_MvtDepot);
            this.Controls.Add(this.cb_MvtArticle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAjouterMvt";
            this.Text = "Ajouter un Mouvement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_MvtArticle;
        private System.Windows.Forms.ComboBox cb_MvtDepot;
        private System.Windows.Forms.TextBox txt_MvtQtt;
        private System.Windows.Forms.Button btnValiderMvt;
        private System.Windows.Forms.DateTimePicker date_Mvt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}