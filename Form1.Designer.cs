﻿namespace AP2
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabStock = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.donnee_nvxStock_tab = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.datePickerStock = new System.Windows.Forms.DateTimePicker();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.btnAfficherStock = new System.Windows.Forms.Button();
            this.donnee_inv_tab = new System.Windows.Forms.TabPage();
            this.dgv_Inv = new System.Windows.Forms.DataGridView();
            this.cmSupp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_inv = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_searchInv = new System.Windows.Forms.TextBox();
            this.donnee_mvm_tab = new System.Windows.Forms.TabPage();
            this.txt_searchMvt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgv_Mvt = new System.Windows.Forms.DataGridView();
            this.btnMvt = new System.Windows.Forms.Button();
            this.tabDonnee = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.stockDgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.param_btnAjt = new System.Windows.Forms.Button();
            this.chkTri = new System.Windows.Forms.CheckBox();
            this.cb_cat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.cb_Fab = new System.Windows.Forms.ComboBox();
            this.cb_Dep = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_AjtFab = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_searchFab = new System.Windows.Forms.TextBox();
            this.dgv_AllFab = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_AjtDep = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_searchDep = new System.Windows.Forms.TextBox();
            this.dgv_allDep = new System.Windows.Forms.DataGridView();
            this.tabParam = new System.Windows.Forms.TabPage();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_addCat = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_searchCat = new System.Windows.Forms.TextBox();
            this.dgvCat = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btn_ajouterUni = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_searchUni = new System.Windows.Forms.TextBox();
            this.dgv_Uni = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabStock.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.donnee_nvxStock_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.donnee_inv_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inv)).BeginInit();
            this.cmSupp.SuspendLayout();
            this.donnee_mvm_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mvt)).BeginInit();
            this.tabDonnee.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDgv)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllFab)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allDep)).BeginInit();
            this.tabParam.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCat)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Uni)).BeginInit();
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Choisir un niveau de stock à une date précise";
            // 
            // datePickerStock
            // 
            this.datePickerStock.CustomFormat = "dd/MM/yyyy HH:mm";
            this.datePickerStock.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerStock.Location = new System.Drawing.Point(23, 29);
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
            this.dgvStock.Location = new System.Drawing.Point(3, 66);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(592, 323);
            this.dgvStock.StandardTab = true;
            this.dgvStock.TabIndex = 1;
            // 
            // btnAfficherStock
            // 
            this.btnAfficherStock.Location = new System.Drawing.Point(433, 26);
            this.btnAfficherStock.Name = "btnAfficherStock";
            this.btnAfficherStock.Size = new System.Drawing.Size(75, 23);
            this.btnAfficherStock.TabIndex = 0;
            this.btnAfficherStock.Text = "Valider";
            this.btnAfficherStock.UseVisualStyleBackColor = true;
            this.btnAfficherStock.Click += new System.EventHandler(this.btnAfficherStock_Click);
            // 
            // donnee_inv_tab
            // 
            this.donnee_inv_tab.Controls.Add(this.dgv_Inv);
            this.donnee_inv_tab.Controls.Add(this.btn_inv);
            this.donnee_inv_tab.Controls.Add(this.label10);
            this.donnee_inv_tab.Controls.Add(this.txt_searchInv);
            this.donnee_inv_tab.Location = new System.Drawing.Point(4, 22);
            this.donnee_inv_tab.Name = "donnee_inv_tab";
            this.donnee_inv_tab.Padding = new System.Windows.Forms.Padding(3);
            this.donnee_inv_tab.Size = new System.Drawing.Size(598, 392);
            this.donnee_inv_tab.TabIndex = 1;
            this.donnee_inv_tab.Text = "Inventaire";
            this.donnee_inv_tab.UseVisualStyleBackColor = true;
            // 
            // dgv_Inv
            // 
            this.dgv_Inv.AllowUserToAddRows = false;
            this.dgv_Inv.AllowUserToDeleteRows = false;
            this.dgv_Inv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Inv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Inv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Inv.ContextMenuStrip = this.cmSupp;
            this.dgv_Inv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Inv.Location = new System.Drawing.Point(3, 92);
            this.dgv_Inv.Name = "dgv_Inv";
            this.dgv_Inv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Inv.Size = new System.Drawing.Size(592, 297);
            this.dgv_Inv.TabIndex = 7;
            // 
            // cmSupp
            // 
            this.cmSupp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerToolStripMenuItem});
            this.cmSupp.Name = "cmSupp";
            this.cmSupp.Size = new System.Drawing.Size(130, 26);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // btn_inv
            // 
            this.btn_inv.Location = new System.Drawing.Point(389, 3);
            this.btn_inv.Name = "btn_inv";
            this.btn_inv.Size = new System.Drawing.Size(203, 77);
            this.btn_inv.TabIndex = 3;
            this.btn_inv.Text = "Faire l\'inventaire";
            this.btn_inv.UseVisualStyleBackColor = true;
            this.btn_inv.Click += new System.EventHandler(this.btn_inv_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Rechercher un inventaire";
            // 
            // txt_searchInv
            // 
            this.txt_searchInv.Location = new System.Drawing.Point(43, 36);
            this.txt_searchInv.Name = "txt_searchInv";
            this.txt_searchInv.Size = new System.Drawing.Size(100, 20);
            this.txt_searchInv.TabIndex = 1;
            this.txt_searchInv.TextChanged += new System.EventHandler(this.txt_searchInv_TextChanged);
            // 
            // donnee_mvm_tab
            // 
            this.donnee_mvm_tab.Controls.Add(this.txt_searchMvt);
            this.donnee_mvm_tab.Controls.Add(this.label11);
            this.donnee_mvm_tab.Controls.Add(this.dgv_Mvt);
            this.donnee_mvm_tab.Controls.Add(this.btnMvt);
            this.donnee_mvm_tab.Location = new System.Drawing.Point(4, 22);
            this.donnee_mvm_tab.Name = "donnee_mvm_tab";
            this.donnee_mvm_tab.Padding = new System.Windows.Forms.Padding(3);
            this.donnee_mvm_tab.Size = new System.Drawing.Size(598, 392);
            this.donnee_mvm_tab.TabIndex = 2;
            this.donnee_mvm_tab.Text = "Mouvements";
            this.donnee_mvm_tab.UseVisualStyleBackColor = true;
            // 
            // txt_searchMvt
            // 
            this.txt_searchMvt.Location = new System.Drawing.Point(40, 43);
            this.txt_searchMvt.Name = "txt_searchMvt";
            this.txt_searchMvt.Size = new System.Drawing.Size(179, 20);
            this.txt_searchMvt.TabIndex = 8;
            this.txt_searchMvt.TextChanged += new System.EventHandler(this.txt_searchMvt_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Rechercher mouvement";
            // 
            // dgv_Mvt
            // 
            this.dgv_Mvt.AllowUserToAddRows = false;
            this.dgv_Mvt.AllowUserToDeleteRows = false;
            this.dgv_Mvt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Mvt.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Mvt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Mvt.ContextMenuStrip = this.cmSupp;
            this.dgv_Mvt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Mvt.Location = new System.Drawing.Point(3, 92);
            this.dgv_Mvt.Name = "dgv_Mvt";
            this.dgv_Mvt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Mvt.Size = new System.Drawing.Size(592, 297);
            this.dgv_Mvt.TabIndex = 6;
            // 
            // btnMvt
            // 
            this.btnMvt.Location = new System.Drawing.Point(411, 26);
            this.btnMvt.Name = "btnMvt";
            this.btnMvt.Size = new System.Drawing.Size(150, 58);
            this.btnMvt.TabIndex = 5;
            this.btnMvt.Text = "Ajouter un mouvement";
            this.btnMvt.UseVisualStyleBackColor = true;
            this.btnMvt.Click += new System.EventHandler(this.btnMvt_Click);
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
            // stockDgv
            // 
            this.stockDgv.AllowUserToAddRows = false;
            this.stockDgv.AllowUserToDeleteRows = false;
            this.stockDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockDgv.ContextMenuStrip = this.cmSupp;
            this.stockDgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stockDgv.Location = new System.Drawing.Point(3, 152);
            this.stockDgv.Name = "stockDgv";
            this.stockDgv.ReadOnly = true;
            this.stockDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockDgv.Size = new System.Drawing.Size(602, 243);
            this.stockDgv.TabIndex = 14;
            this.stockDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockDgv_CellContentClick);
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
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(159, 115);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(283, 20);
            this.txtLibelle.TabIndex = 12;
            this.txtLibelle.TextChanged += new System.EventHandler(this.txtLibelle_TextChanged);
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
            // cb_Dep
            // 
            this.cb_Dep.FormattingEnabled = true;
            this.cb_Dep.Location = new System.Drawing.Point(159, 80);
            this.cb_Dep.Name = "cb_Dep";
            this.cb_Dep.Size = new System.Drawing.Size(283, 21);
            this.cb_Dep.TabIndex = 10;
            this.cb_Dep.SelectionChangeCommitted += new System.EventHandler(this.cb_Dep_SelectionChangeCommitted);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Recherche par dépôt:";
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
            // btn_AjtFab
            // 
            this.btn_AjtFab.Location = new System.Drawing.Point(444, 7);
            this.btn_AjtFab.Name = "btn_AjtFab";
            this.btn_AjtFab.Size = new System.Drawing.Size(156, 70);
            this.btn_AjtFab.TabIndex = 15;
            this.btn_AjtFab.Text = "Ajouter un fabricant";
            this.btn_AjtFab.UseVisualStyleBackColor = true;
            this.btn_AjtFab.Click += new System.EventHandler(this.btn_AjtFab_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Recherche par libellé:";
            // 
            // txt_searchFab
            // 
            this.txt_searchFab.Location = new System.Drawing.Point(27, 33);
            this.txt_searchFab.Name = "txt_searchFab";
            this.txt_searchFab.Size = new System.Drawing.Size(283, 20);
            this.txt_searchFab.TabIndex = 14;
            this.txt_searchFab.TextChanged += new System.EventHandler(this.txt_searchFab_TextChanged);
            // 
            // dgv_AllFab
            // 
            this.dgv_AllFab.AllowUserToAddRows = false;
            this.dgv_AllFab.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_AllFab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AllFab.ContextMenuStrip = this.cmSupp;
            this.dgv_AllFab.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_AllFab.Location = new System.Drawing.Point(3, 83);
            this.dgv_AllFab.Name = "dgv_AllFab";
            this.dgv_AllFab.Size = new System.Drawing.Size(602, 312);
            this.dgv_AllFab.TabIndex = 0;
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
            this.label7.Location = new System.Drawing.Point(24, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Recherche par libellé:";
            // 
            // txt_searchDep
            // 
            this.txt_searchDep.Location = new System.Drawing.Point(27, 30);
            this.txt_searchDep.Name = "txt_searchDep";
            this.txt_searchDep.Size = new System.Drawing.Size(283, 20);
            this.txt_searchDep.TabIndex = 18;
            this.txt_searchDep.TextChanged += new System.EventHandler(this.txt_searchDep_TextChanged);
            // 
            // dgv_allDep
            // 
            this.dgv_allDep.AllowUserToAddRows = false;
            this.dgv_allDep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_allDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_allDep.ContextMenuStrip = this.cmSupp;
            this.dgv_allDep.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_allDep.Location = new System.Drawing.Point(0, 86);
            this.dgv_allDep.Name = "dgv_allDep";
            this.dgv_allDep.Size = new System.Drawing.Size(608, 312);
            this.dgv_allDep.TabIndex = 16;
            // 
            // tabParam
            // 
            this.tabParam.Controls.Add(this.tabControl4);
            this.tabParam.Location = new System.Drawing.Point(4, 22);
            this.tabParam.Name = "tabParam";
            this.tabParam.Padding = new System.Windows.Forms.Padding(3);
            this.tabParam.Size = new System.Drawing.Size(612, 424);
            this.tabParam.TabIndex = 2;
            this.tabParam.Text = "Paramètres";
            this.tabParam.UseVisualStyleBackColor = true;
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.tabPage4);
            this.tabControl4.Controls.Add(this.tabPage5);
            this.tabControl4.Location = new System.Drawing.Point(3, 6);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(613, 418);
            this.tabControl4.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_addCat);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.txt_searchCat);
            this.tabPage4.Controls.Add(this.dgvCat);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(605, 392);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Catégories d\'article";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_addCat
            // 
            this.btn_addCat.Location = new System.Drawing.Point(347, 7);
            this.btn_addCat.Name = "btn_addCat";
            this.btn_addCat.Size = new System.Drawing.Size(250, 79);
            this.btn_addCat.TabIndex = 3;
            this.btn_addCat.Text = "Ajouter une catégorie";
            this.btn_addCat.UseVisualStyleBackColor = true;
            this.btn_addCat.Click += new System.EventHandler(this.btn_addCat_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Rechercher :";
            // 
            // txt_searchCat
            // 
            this.txt_searchCat.Location = new System.Drawing.Point(32, 29);
            this.txt_searchCat.Name = "txt_searchCat";
            this.txt_searchCat.Size = new System.Drawing.Size(268, 20);
            this.txt_searchCat.TabIndex = 1;
            this.txt_searchCat.TextChanged += new System.EventHandler(this.txt_searchCat_TextChanged);
            // 
            // dgvCat
            // 
            this.dgvCat.AllowUserToAddRows = false;
            this.dgvCat.AllowUserToDeleteRows = false;
            this.dgvCat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCat.ContextMenuStrip = this.cmSupp;
            this.dgvCat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCat.Location = new System.Drawing.Point(3, 92);
            this.dgvCat.Name = "dgvCat";
            this.dgvCat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCat.Size = new System.Drawing.Size(599, 297);
            this.dgvCat.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btn_ajouterUni);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.txt_searchUni);
            this.tabPage5.Controls.Add(this.dgv_Uni);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(605, 392);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Unités";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btn_ajouterUni
            // 
            this.btn_ajouterUni.Location = new System.Drawing.Point(347, 5);
            this.btn_ajouterUni.Name = "btn_ajouterUni";
            this.btn_ajouterUni.Size = new System.Drawing.Size(250, 79);
            this.btn_ajouterUni.TabIndex = 7;
            this.btn_ajouterUni.Text = "Ajouter une unité";
            this.btn_ajouterUni.UseVisualStyleBackColor = true;
            this.btn_ajouterUni.Click += new System.EventHandler(this.btn_ajouterUni_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Rechercher :";
            // 
            // txt_searchUni
            // 
            this.txt_searchUni.Location = new System.Drawing.Point(32, 27);
            this.txt_searchUni.Name = "txt_searchUni";
            this.txt_searchUni.Size = new System.Drawing.Size(268, 20);
            this.txt_searchUni.TabIndex = 5;
            this.txt_searchUni.TextChanged += new System.EventHandler(this.txt_searchUni_TextChanged);
            // 
            // dgv_Uni
            // 
            this.dgv_Uni.AllowUserToAddRows = false;
            this.dgv_Uni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Uni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Uni.ContextMenuStrip = this.cmSupp;
            this.dgv_Uni.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Uni.Location = new System.Drawing.Point(3, 92);
            this.dgv_Uni.MultiSelect = false;
            this.dgv_Uni.Name = "dgv_Uni";
            this.dgv_Uni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Uni.Size = new System.Drawing.Size(599, 297);
            this.dgv_Uni.TabIndex = 4;
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
            this.donnee_inv_tab.ResumeLayout(false);
            this.donnee_inv_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Inv)).EndInit();
            this.cmSupp.ResumeLayout(false);
            this.donnee_mvm_tab.ResumeLayout(false);
            this.donnee_mvm_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mvt)).EndInit();
            this.tabDonnee.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDgv)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllFab)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allDep)).EndInit();
            this.tabParam.ResumeLayout(false);
            this.tabControl4.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCat)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Uni)).EndInit();
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
        private System.Windows.Forms.ContextMenuStrip cmSupp;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_searchCat;
        private System.Windows.Forms.DataGridView dgvCat;
        private System.Windows.Forms.Button btn_addCat;
        private System.Windows.Forms.Button btn_ajouterUni;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_searchUni;
        private System.Windows.Forms.DataGridView dgv_Uni;
        private System.Windows.Forms.Button btnMvt;
        private System.Windows.Forms.Button btn_inv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_searchInv;
        private System.Windows.Forms.TextBox txt_searchMvt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgv_Mvt;
        private System.Windows.Forms.DataGridView dgv_Inv;
    }
}

