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
            this.tabStock = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.donnee_nvxStock_tab = new System.Windows.Forms.TabPage();
            this.btnMvt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.datePickerStock = new System.Windows.Forms.DateTimePicker();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.btnAfficherStock = new System.Windows.Forms.Button();
            this.donnee_inv_tab = new System.Windows.Forms.TabPage();
            this.donnee_mvm_tab = new System.Windows.Forms.TabPage();
            this.tabDonnee = new System.Windows.Forms.TabPage();
            this.chkTri = new System.Windows.Forms.CheckBox();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.cb_Dep = new System.Windows.Forms.ComboBox();
            this.cb_Fab = new System.Windows.Forms.ComboBox();
            this.cb_cat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.param_btnAjt = new System.Windows.Forms.Button();
            this.tabParam = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.stockDgv = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgv_AllFab = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_searchFab = new System.Windows.Forms.TextBox();
            this.btn_AjtFab = new System.Windows.Forms.Button();
            this.btn_AjtDep = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_searchDep = new System.Windows.Forms.TextBox();
            this.dgv_allDep = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabStock.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.donnee_nvxStock_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.tabDonnee.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDgv)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllFab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allDep)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabStock);
            this.tabControl1.Controls.Add(this.tabDonnee);
            this.tabControl1.Controls.Add(this.tabParam);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(620, 450);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabStock
            // 
            this.tabStock.Controls.Add(this.tabControl2);
            this.tabStock.Location = new System.Drawing.Point(4, 22);
            this.tabStock.Name = "tabStock";
            this.tabStock.Padding = new System.Windows.Forms.Padding(3);
            this.tabStock.Size = new System.Drawing.Size(612, 424);
            this.tabStock.TabIndex = 1;
            this.tabStock.Text = "Stock";
            this.tabStock.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.donnee_nvxStock_tab);
            this.tabControl2.Controls.Add(this.donnee_inv_tab);
            this.tabControl2.Controls.Add(this.donnee_mvm_tab);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(606, 418);
            this.tabControl2.TabIndex = 0;
            // 
            // donnee_nvxStock_tab
            // 
            this.donnee_nvxStock_tab.Controls.Add(this.btnMvt);
            this.donnee_nvxStock_tab.Controls.Add(this.label5);
            this.donnee_nvxStock_tab.Controls.Add(this.datePickerStock);
            this.donnee_nvxStock_tab.Controls.Add(this.dgvStock);
            this.donnee_nvxStock_tab.Controls.Add(this.btnAfficherStock);
            this.donnee_nvxStock_tab.Location = new System.Drawing.Point(4, 22);
            this.donnee_nvxStock_tab.Name = "donnee_nvxStock_tab";
            this.donnee_nvxStock_tab.Padding = new System.Windows.Forms.Padding(3);
            this.donnee_nvxStock_tab.Size = new System.Drawing.Size(598, 392);
            this.donnee_nvxStock_tab.TabIndex = 0;
            this.donnee_nvxStock_tab.Text = "Niveaux de stock";
            this.donnee_nvxStock_tab.UseVisualStyleBackColor = true;
            // 
            // btnMvt
            // 
            this.btnMvt.Location = new System.Drawing.Point(426, 49);
            this.btnMvt.Name = "btnMvt";
            this.btnMvt.Size = new System.Drawing.Size(150, 58);
            this.btnMvt.TabIndex = 4;
            this.btnMvt.Text = "Ajouter un mouvement";
            this.btnMvt.UseVisualStyleBackColor = true;
            this.btnMvt.Click += new System.EventHandler(this.btnMvt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Choisir un niveau de stock à une date précise";
            // 
            // datePickerStock
            // 
            this.datePickerStock.CustomFormat = "dd/MM/yyyy HH:mm";
            this.datePickerStock.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerStock.Location = new System.Drawing.Point(23, 87);
            this.datePickerStock.Name = "datePickerStock";
            this.datePickerStock.Size = new System.Drawing.Size(200, 20);
            this.datePickerStock.TabIndex = 2;
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AllowUserToOrderColumns = true;
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvStock.Location = new System.Drawing.Point(3, 132);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(592, 257);
            this.dgvStock.StandardTab = true;
            this.dgvStock.TabIndex = 1;
            // 
            // btnAfficherStock
            // 
            this.btnAfficherStock.Location = new System.Drawing.Point(229, 84);
            this.btnAfficherStock.Name = "btnAfficherStock";
            this.btnAfficherStock.Size = new System.Drawing.Size(75, 23);
            this.btnAfficherStock.TabIndex = 0;
            this.btnAfficherStock.Text = "Valider";
            this.btnAfficherStock.UseVisualStyleBackColor = true;
            this.btnAfficherStock.Click += new System.EventHandler(this.btnAfficherStock_Click);
            // 
            // donnee_inv_tab
            // 
            this.donnee_inv_tab.Location = new System.Drawing.Point(4, 22);
            this.donnee_inv_tab.Name = "donnee_inv_tab";
            this.donnee_inv_tab.Padding = new System.Windows.Forms.Padding(3);
            this.donnee_inv_tab.Size = new System.Drawing.Size(598, 392);
            this.donnee_inv_tab.TabIndex = 1;
            this.donnee_inv_tab.Text = "Inventaire";
            this.donnee_inv_tab.UseVisualStyleBackColor = true;
            // 
            // donnee_mvm_tab
            // 
            this.donnee_mvm_tab.Location = new System.Drawing.Point(4, 22);
            this.donnee_mvm_tab.Name = "donnee_mvm_tab";
            this.donnee_mvm_tab.Padding = new System.Windows.Forms.Padding(3);
            this.donnee_mvm_tab.Size = new System.Drawing.Size(598, 392);
            this.donnee_mvm_tab.TabIndex = 2;
            this.donnee_mvm_tab.Text = "Mouvements";
            this.donnee_mvm_tab.UseVisualStyleBackColor = true;
            // 
            // tabDonnee
            // 
            this.tabDonnee.Controls.Add(this.tabControl3);
            this.tabDonnee.Location = new System.Drawing.Point(4, 22);
            this.tabDonnee.Name = "tabDonnee";
            this.tabDonnee.Padding = new System.Windows.Forms.Padding(3);
            this.tabDonnee.Size = new System.Drawing.Size(612, 424);
            this.tabDonnee.TabIndex = 0;
            this.tabDonnee.Text = "Données";
            this.tabDonnee.UseVisualStyleBackColor = true;
            // 
            // chkTri
            // 
            this.chkTri.AutoSize = true;
            this.chkTri.Location = new System.Drawing.Point(462, 114);
            this.chkTri.Name = "chkTri";
            this.chkTri.Size = new System.Drawing.Size(95, 17);
            this.chkTri.TabIndex = 13;
            this.chkTri.Text = "Tri décroissant";
            this.chkTri.UseVisualStyleBackColor = true;
            this.chkTri.CheckedChanged += new System.EventHandler(this.chkTri_CheckedChanged);
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(159, 115);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(283, 20);
            this.txtLibelle.TabIndex = 12;
            this.txtLibelle.TextChanged += new System.EventHandler(this.txtLibelle_TextChanged);
            // 
            // cb_Dep
            // 
            this.cb_Dep.FormattingEnabled = true;
            this.cb_Dep.Location = new System.Drawing.Point(159, 80);
            this.cb_Dep.Name = "cb_Dep";
            this.cb_Dep.Size = new System.Drawing.Size(283, 21);
            this.cb_Dep.TabIndex = 10;
            this.cb_Dep.SelectionChangeCommitted += new System.EventHandler(this.cb_Dep_SelectionChangeCommitted);
            // 
            // cb_Fab
            // 
            this.cb_Fab.FormattingEnabled = true;
            this.cb_Fab.Location = new System.Drawing.Point(159, 50);
            this.cb_Fab.Name = "cb_Fab";
            this.cb_Fab.Size = new System.Drawing.Size(283, 21);
            this.cb_Fab.TabIndex = 9;
            this.cb_Fab.SelectionChangeCommitted += new System.EventHandler(this.cb_Fab_SelectionChangeCommitted);
            // 
            // cb_cat
            // 
            this.cb_cat.FormattingEnabled = true;
            this.cb_cat.Location = new System.Drawing.Point(159, 20);
            this.cb_cat.Name = "cb_cat";
            this.cb_cat.Size = new System.Drawing.Size(283, 21);
            this.cb_cat.TabIndex = 8;
            this.cb_cat.SelectionChangeCommitted += new System.EventHandler(this.cb_cat_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Recherche par libellé:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Recherche par dépôt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Recherche par fabricant:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Recherche par catégorie:";
            // 
            // param_btnAjt
            // 
            this.param_btnAjt.Location = new System.Drawing.Point(462, 17);
            this.param_btnAjt.Name = "param_btnAjt";
            this.param_btnAjt.Size = new System.Drawing.Size(138, 84);
            this.param_btnAjt.TabIndex = 1;
            this.param_btnAjt.Text = "Ajouter un article";
            this.param_btnAjt.UseVisualStyleBackColor = true;
            this.param_btnAjt.Click += new System.EventHandler(this.param_btnAjt_Click);
            // 
            // tabParam
            // 
            this.tabParam.Location = new System.Drawing.Point(4, 22);
            this.tabParam.Name = "tabParam";
            this.tabParam.Padding = new System.Windows.Forms.Padding(3);
            this.tabParam.Size = new System.Drawing.Size(612, 424);
            this.tabParam.TabIndex = 2;
            this.tabParam.Text = "Paramètres";
            this.tabParam.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage1);
            this.tabControl3.Controls.Add(this.tabPage2);
            this.tabControl3.Controls.Add(this.tabPage3);
            this.tabControl3.Location = new System.Drawing.Point(0, 4);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(616, 424);
            this.tabControl3.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.stockDgv);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.param_btnAjt);
            this.tabPage1.Controls.Add(this.chkTri);
            this.tabPage1.Controls.Add(this.cb_cat);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtLibelle);
            this.tabPage1.Controls.Add(this.cb_Fab);
            this.tabPage1.Controls.Add(this.cb_Dep);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(608, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Articles";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_AjtFab);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txt_searchFab);
            this.tabPage2.Controls.Add(this.dgv_AllFab);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(608, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fabricants";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // stockDgv
            // 
            this.stockDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockDgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stockDgv.Location = new System.Drawing.Point(3, 152);
            this.stockDgv.Name = "stockDgv";
            this.stockDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockDgv.Size = new System.Drawing.Size(602, 243);
            this.stockDgv.TabIndex = 14;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_AjtDep);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txt_searchDep);
            this.tabPage3.Controls.Add(this.dgv_allDep);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(608, 398);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dépôts";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgv_AllFab
            // 
            this.dgv_AllFab.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_AllFab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AllFab.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_AllFab.Location = new System.Drawing.Point(3, 83);
            this.dgv_AllFab.Name = "dgv_AllFab";
            this.dgv_AllFab.Size = new System.Drawing.Size(602, 312);
            this.dgv_AllFab.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Recherche par libellé:";
            // 
            // txt_searchFab
            // 
            this.txt_searchFab.Location = new System.Drawing.Point(140, 29);
            this.txt_searchFab.Name = "txt_searchFab";
            this.txt_searchFab.Size = new System.Drawing.Size(283, 20);
            this.txt_searchFab.TabIndex = 14;
            this.txt_searchFab.TextChanged += new System.EventHandler(this.txt_searchFab_TextChanged);
            // 
            // btn_AjtFab
            // 
            this.btn_AjtFab.Location = new System.Drawing.Point(444, 7);
            this.btn_AjtFab.Name = "btn_AjtFab";
            this.btn_AjtFab.Size = new System.Drawing.Size(156, 70);
            this.btn_AjtFab.TabIndex = 15;
            this.btn_AjtFab.Text = "Ajouter un fabricant";
            this.btn_AjtFab.UseVisualStyleBackColor = true;
            // 
            // btn_AjtDep
            // 
            this.btn_AjtDep.Location = new System.Drawing.Point(444, 4);
            this.btn_AjtDep.Name = "btn_AjtDep";
            this.btn_AjtDep.Size = new System.Drawing.Size(156, 70);
            this.btn_AjtDep.TabIndex = 19;
            this.btn_AjtDep.Text = "Ajouter un dépôt";
            this.btn_AjtDep.UseVisualStyleBackColor = true;
            this.btn_AjtDep.Click += new System.EventHandler(this.btn_AjtDep_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Recherche par libellé:";
            // 
            // txt_searchDep
            // 
            this.txt_searchDep.Location = new System.Drawing.Point(140, 26);
            this.txt_searchDep.Name = "txt_searchDep";
            this.txt_searchDep.Size = new System.Drawing.Size(283, 20);
            this.txt_searchDep.TabIndex = 18;
            // 
            // dgv_allDep
            // 
            this.dgv_allDep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_allDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_allDep.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_allDep.Location = new System.Drawing.Point(0, 86);
            this.dgv_allDep.Name = "dgv_allDep";
            this.dgv_allDep.Size = new System.Drawing.Size(608, 312);
            this.dgv_allDep.TabIndex = 16;
             // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 450);
            this.Controls.Add(this.tabControl1);
            this.Location = new System.Drawing.Point(816, 489);
            this.Name = "Form1";
            this.Text = "Gestion de stock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabStock.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.donnee_nvxStock_tab.ResumeLayout(false);
            this.donnee_nvxStock_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.tabDonnee.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDgv)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllFab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allDep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDonnee;
        private System.Windows.Forms.TabPage tabStock;
        private System.Windows.Forms.TabPage tabParam;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage donnee_nvxStock_tab;
        private System.Windows.Forms.TabPage donnee_inv_tab;
        private System.Windows.Forms.TabPage donnee_mvm_tab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datePickerStock;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Button btnAfficherStock;
        private System.Windows.Forms.Button btnMvt;
        private System.Windows.Forms.CheckBox chkTri;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.ComboBox cb_Dep;
        private System.Windows.Forms.ComboBox cb_Fab;
        private System.Windows.Forms.ComboBox cb_cat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button param_btnAjt;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView stockDgv;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_AjtFab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_searchFab;
        private System.Windows.Forms.DataGridView dgv_AllFab;
        private System.Windows.Forms.Button btn_AjtDep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_searchDep;
        private System.Windows.Forms.DataGridView dgv_allDep;
    }
}

