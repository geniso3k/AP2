namespace AP2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.stocks_tab = new System.Windows.Forms.TabPage();
            this.cb_lib = new System.Windows.Forms.ComboBox();
            this.cb_Dep = new System.Windows.Forms.ComboBox();
            this.cb_Fab = new System.Windows.Forms.ComboBox();
            this.cb_cat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.param_btnEdit = new System.Windows.Forms.Button();
            this.param_btnSupprimer = new System.Windows.Forms.Button();
            this.param_btnAjt = new System.Windows.Forms.Button();
            this.stockDgv = new System.Windows.Forms.DataGridView();
            this.donnee_tab = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.donnee_article_tab = new System.Windows.Forms.TabPage();
            this.donnee_fabricants_tab = new System.Windows.Forms.TabPage();
            this.donnee_depot_tab = new System.Windows.Forms.TabPage();
            this.param_tab = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.stocks_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDgv)).BeginInit();
            this.donnee_tab.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.stocks_tab);
            this.tabControl1.Controls.Add(this.donnee_tab);
            this.tabControl1.Controls.Add(this.param_tab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // stocks_tab
            // 
            this.stocks_tab.Controls.Add(this.cb_lib);
            this.stocks_tab.Controls.Add(this.cb_Dep);
            this.stocks_tab.Controls.Add(this.cb_Fab);
            this.stocks_tab.Controls.Add(this.cb_cat);
            this.stocks_tab.Controls.Add(this.label4);
            this.stocks_tab.Controls.Add(this.label3);
            this.stocks_tab.Controls.Add(this.label2);
            this.stocks_tab.Controls.Add(this.label1);
            this.stocks_tab.Controls.Add(this.param_btnEdit);
            this.stocks_tab.Controls.Add(this.param_btnSupprimer);
            this.stocks_tab.Controls.Add(this.param_btnAjt);
            this.stocks_tab.Controls.Add(this.stockDgv);
            this.stocks_tab.Location = new System.Drawing.Point(4, 22);
            this.stocks_tab.Name = "stocks_tab";
            this.stocks_tab.Padding = new System.Windows.Forms.Padding(3);
            this.stocks_tab.Size = new System.Drawing.Size(792, 424);
            this.stocks_tab.TabIndex = 0;
            this.stocks_tab.Text = "Stocks";
            this.stocks_tab.UseVisualStyleBackColor = true;
            // 
            // cb_lib
            // 
            this.cb_lib.FormattingEnabled = true;
            this.cb_lib.Location = new System.Drawing.Point(143, 107);
            this.cb_lib.Name = "cb_lib";
            this.cb_lib.Size = new System.Drawing.Size(121, 21);
            this.cb_lib.TabIndex = 11;
            this.cb_lib.SelectionChangeCommitted += new System.EventHandler(this.cb_lib_SelectionChangeCommitted);
            // 
            // cb_Dep
            // 
            this.cb_Dep.FormattingEnabled = true;
            this.cb_Dep.Location = new System.Drawing.Point(143, 74);
            this.cb_Dep.Name = "cb_Dep";
            this.cb_Dep.Size = new System.Drawing.Size(121, 21);
            this.cb_Dep.TabIndex = 10;
            this.cb_Dep.SelectionChangeCommitted += new System.EventHandler(this.cb_Dep_SelectionChangeCommitted);
            // 
            // cb_Fab
            // 
            this.cb_Fab.FormattingEnabled = true;
            this.cb_Fab.Location = new System.Drawing.Point(143, 43);
            this.cb_Fab.Name = "cb_Fab";
            this.cb_Fab.Size = new System.Drawing.Size(121, 21);
            this.cb_Fab.TabIndex = 9;
            this.cb_Fab.SelectionChangeCommitted += new System.EventHandler(this.cb_Fab_SelectionChangeCommitted);
            // 
            // cb_cat
            // 
            this.cb_cat.FormattingEnabled = true;
            this.cb_cat.Location = new System.Drawing.Point(143, 11);
            this.cb_cat.Name = "cb_cat";
            this.cb_cat.Size = new System.Drawing.Size(121, 21);
            this.cb_cat.TabIndex = 8;
            this.cb_cat.SelectionChangeCommitted += new System.EventHandler(this.cb_cat_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Recherche par libellé:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Recherche par dépôt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Recherche par fabricant:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Recherche par catégorie:";
            // 
            // param_btnEdit
            // 
            this.param_btnEdit.Location = new System.Drawing.Point(344, 166);
            this.param_btnEdit.Name = "param_btnEdit";
            this.param_btnEdit.Size = new System.Drawing.Size(75, 23);
            this.param_btnEdit.TabIndex = 3;
            this.param_btnEdit.Text = "Modifier";
            this.param_btnEdit.UseVisualStyleBackColor = true;
            // 
            // param_btnSupprimer
            // 
            this.param_btnSupprimer.Location = new System.Drawing.Point(709, 166);
            this.param_btnSupprimer.Name = "param_btnSupprimer";
            this.param_btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.param_btnSupprimer.TabIndex = 2;
            this.param_btnSupprimer.Text = "Supprimer";
            this.param_btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // param_btnAjt
            // 
            this.param_btnAjt.Location = new System.Drawing.Point(6, 166);
            this.param_btnAjt.Name = "param_btnAjt";
            this.param_btnAjt.Size = new System.Drawing.Size(75, 23);
            this.param_btnAjt.TabIndex = 1;
            this.param_btnAjt.Text = "Ajouter";
            this.param_btnAjt.UseVisualStyleBackColor = true;
            // 
            // stockDgv
            // 
            this.stockDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.stockDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.stockDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stockDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockDgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stockDgv.Location = new System.Drawing.Point(3, 195);
            this.stockDgv.Name = "stockDgv";
            this.stockDgv.Size = new System.Drawing.Size(786, 226);
            this.stockDgv.TabIndex = 0;
            // 
            // donnee_tab
            // 
            this.donnee_tab.Controls.Add(this.tabControl2);
            this.donnee_tab.Location = new System.Drawing.Point(4, 22);
            this.donnee_tab.Name = "donnee_tab";
            this.donnee_tab.Padding = new System.Windows.Forms.Padding(3);
            this.donnee_tab.Size = new System.Drawing.Size(792, 424);
            this.donnee_tab.TabIndex = 1;
            this.donnee_tab.Text = "Données";
            this.donnee_tab.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.donnee_article_tab);
            this.tabControl2.Controls.Add(this.donnee_fabricants_tab);
            this.tabControl2.Controls.Add(this.donnee_depot_tab);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(786, 418);
            this.tabControl2.TabIndex = 0;
            // 
            // donnee_article_tab
            // 
            this.donnee_article_tab.Location = new System.Drawing.Point(4, 22);
            this.donnee_article_tab.Name = "donnee_article_tab";
            this.donnee_article_tab.Padding = new System.Windows.Forms.Padding(3);
            this.donnee_article_tab.Size = new System.Drawing.Size(778, 392);
            this.donnee_article_tab.TabIndex = 0;
            this.donnee_article_tab.Text = "Articles";
            this.donnee_article_tab.UseVisualStyleBackColor = true;
            // 
            // donnee_fabricants_tab
            // 
            this.donnee_fabricants_tab.Location = new System.Drawing.Point(4, 22);
            this.donnee_fabricants_tab.Name = "donnee_fabricants_tab";
            this.donnee_fabricants_tab.Padding = new System.Windows.Forms.Padding(3);
            this.donnee_fabricants_tab.Size = new System.Drawing.Size(778, 392);
            this.donnee_fabricants_tab.TabIndex = 1;
            this.donnee_fabricants_tab.Text = "Fabricants";
            this.donnee_fabricants_tab.UseVisualStyleBackColor = true;
            // 
            // donnee_depot_tab
            // 
            this.donnee_depot_tab.Location = new System.Drawing.Point(4, 22);
            this.donnee_depot_tab.Name = "donnee_depot_tab";
            this.donnee_depot_tab.Padding = new System.Windows.Forms.Padding(3);
            this.donnee_depot_tab.Size = new System.Drawing.Size(778, 392);
            this.donnee_depot_tab.TabIndex = 2;
            this.donnee_depot_tab.Text = "Dépôts";
            this.donnee_depot_tab.UseVisualStyleBackColor = true;
            // 
            // param_tab
            // 
            this.param_tab.Location = new System.Drawing.Point(4, 22);
            this.param_tab.Name = "param_tab";
            this.param_tab.Padding = new System.Windows.Forms.Padding(3);
            this.param_tab.Size = new System.Drawing.Size(792, 424);
            this.param_tab.TabIndex = 2;
            this.param_tab.Text = "Paramètres";
            this.param_tab.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Location = new System.Drawing.Point(816, 489);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.stocks_tab.ResumeLayout(false);
            this.stocks_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDgv)).EndInit();
            this.donnee_tab.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage stocks_tab;
        private System.Windows.Forms.TabPage donnee_tab;
        private System.Windows.Forms.TabPage param_tab;
        private System.Windows.Forms.DataGridView stockDgv;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage donnee_article_tab;
        private System.Windows.Forms.TabPage donnee_fabricants_tab;
        private System.Windows.Forms.TabPage donnee_depot_tab;
        private System.Windows.Forms.Button param_btnEdit;
        private System.Windows.Forms.Button param_btnSupprimer;
        private System.Windows.Forms.Button param_btnAjt;
        private System.Windows.Forms.ComboBox cb_lib;
        private System.Windows.Forms.ComboBox cb_Dep;
        private System.Windows.Forms.ComboBox cb_Fab;
        private System.Windows.Forms.ComboBox cb_cat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

