namespace AP2
{
    partial class FormModifierArticle
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
            this.txt_ref = new System.Windows.Forms.TextBox();
            this.txt_libelle = new System.Windows.Forms.TextBox();
            this.cb_cat = new System.Windows.Forms.ComboBox();
            this.cb_fab = new System.Windows.Forms.ComboBox();
            this.cb_unite = new System.Windows.Forms.ComboBox();
            this.cb_depot = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_ref
            // 
            this.txt_ref.Enabled = false;
            this.txt_ref.Location = new System.Drawing.Point(12, 26);
            this.txt_ref.Name = "txt_ref";
            this.txt_ref.Size = new System.Drawing.Size(160, 20);
            this.txt_ref.TabIndex = 0;
            // 
            // txt_libelle
            // 
            this.txt_libelle.Location = new System.Drawing.Point(12, 63);
            this.txt_libelle.Name = "txt_libelle";
            this.txt_libelle.Size = new System.Drawing.Size(160, 20);
            this.txt_libelle.TabIndex = 1;
            // 
            // cb_cat
            // 
            this.cb_cat.FormattingEnabled = true;
            this.cb_cat.Location = new System.Drawing.Point(12, 108);
            this.cb_cat.Name = "cb_cat";
            this.cb_cat.Size = new System.Drawing.Size(160, 21);
            this.cb_cat.TabIndex = 2;
            // 
            // cb_fab
            // 
            this.cb_fab.FormattingEnabled = true;
            this.cb_fab.Location = new System.Drawing.Point(12, 149);
            this.cb_fab.Name = "cb_fab";
            this.cb_fab.Size = new System.Drawing.Size(160, 21);
            this.cb_fab.TabIndex = 3;
            // 
            // cb_unite
            // 
            this.cb_unite.FormattingEnabled = true;
            this.cb_unite.Location = new System.Drawing.Point(12, 197);
            this.cb_unite.Name = "cb_unite";
            this.cb_unite.Size = new System.Drawing.Size(160, 21);
            this.cb_unite.TabIndex = 4;
            // 
            // cb_depot
            // 
            this.cb_depot.FormattingEnabled = true;
            this.cb_depot.Location = new System.Drawing.Point(12, 242);
            this.cb_depot.Name = "cb_depot";
            this.cb_depot.Size = new System.Drawing.Size(160, 21);
            this.cb_depot.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Réference";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Catégorie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fabricant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Unité";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dépôt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Libellé";
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(12, 283);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(160, 23);
            this.btn_edit.TabIndex = 12;
            this.btn_edit.Text = "Sauvegarder";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.IndianRed;
            this.btn_del.Location = new System.Drawing.Point(12, 312);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(82, 23);
            this.btn_del.TabIndex = 13;
            this.btn_del.Text = "Supprimer l\'article";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(100, 312);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(72, 23);
            this.btn_annuler.TabIndex = 14;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // FormModifierArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 340);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_depot);
            this.Controls.Add(this.cb_unite);
            this.Controls.Add(this.cb_fab);
            this.Controls.Add(this.cb_cat);
            this.Controls.Add(this.txt_libelle);
            this.Controls.Add(this.txt_ref);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormModifierArticle";
            this.Text = "FormModifierArticle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ref;
        private System.Windows.Forms.TextBox txt_libelle;
        private System.Windows.Forms.ComboBox cb_cat;
        private System.Windows.Forms.ComboBox cb_fab;
        private System.Windows.Forms.ComboBox cb_unite;
        private System.Windows.Forms.ComboBox cb_depot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_annuler;
    }
}