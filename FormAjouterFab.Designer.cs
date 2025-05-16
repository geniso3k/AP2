namespace AP2
{
    partial class FormAjouterFab
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
            this.txt_refFab = new System.Windows.Forms.TextBox();
            this.txt_Marque = new System.Windows.Forms.TextBox();
            this.txt_Ent = new System.Windows.Forms.TextBox();
            this.btn_AjouterFab = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Référence fabricant unique (FABxxx)";
            // 
            // txt_refFab
            // 
            this.txt_refFab.Location = new System.Drawing.Point(12, 95);
            this.txt_refFab.Name = "txt_refFab";
            this.txt_refFab.Size = new System.Drawing.Size(227, 20);
            this.txt_refFab.TabIndex = 1;
            // 
            // txt_Marque
            // 
            this.txt_Marque.Location = new System.Drawing.Point(12, 214);
            this.txt_Marque.Name = "txt_Marque";
            this.txt_Marque.Size = new System.Drawing.Size(227, 20);
            this.txt_Marque.TabIndex = 2;
            // 
            // txt_Ent
            // 
            this.txt_Ent.Location = new System.Drawing.Point(12, 152);
            this.txt_Ent.Name = "txt_Ent";
            this.txt_Ent.Size = new System.Drawing.Size(227, 20);
            this.txt_Ent.TabIndex = 3;
            // 
            // btn_AjouterFab
            // 
            this.btn_AjouterFab.Location = new System.Drawing.Point(12, 259);
            this.btn_AjouterFab.Name = "btn_AjouterFab";
            this.btn_AjouterFab.Size = new System.Drawing.Size(227, 27);
            this.btn_AjouterFab.TabIndex = 4;
            this.btn_AjouterFab.Text = "Ajouter le fabricant";
            this.btn_AjouterFab.UseVisualStyleBackColor = true;
            this.btn_AjouterFab.Click += new System.EventHandler(this.btn_AjouterFab_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom de l\'entreprise";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nom de marque";
            // 
            // FormAjouterFab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 298);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_AjouterFab);
            this.Controls.Add(this.txt_Ent);
            this.Controls.Add(this.txt_Marque);
            this.Controls.Add(this.txt_refFab);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAjouterFab";
            this.Text = "FormAjouterFab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_refFab;
        private System.Windows.Forms.TextBox txt_Marque;
        private System.Windows.Forms.TextBox txt_Ent;
        private System.Windows.Forms.Button btn_AjouterFab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}