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
            this.param_tab = new System.Windows.Forms.TabPage();
            this.donnee_tab = new System.Windows.Forms.TabPage();
            this.stock_tab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.donnee_article_tab = new System.Windows.Forms.TabPage();
            this.donnee_fabricants_tab = new System.Windows.Forms.TabPage();
            this.donnee_depot_tab = new System.Windows.Forms.TabPage();
            this.param_btnAjt = new System.Windows.Forms.Button();
            this.param_btnSupprimer = new System.Windows.Forms.Button();
            this.param_btnEdit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.param_tab.SuspendLayout();
            this.donnee_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.param_tab);
            this.tabControl1.Controls.Add(this.donnee_tab);
            this.tabControl1.Controls.Add(this.stock_tab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // param_tab
            // 
            this.param_tab.Controls.Add(this.param_btnEdit);
            this.param_tab.Controls.Add(this.param_btnSupprimer);
            this.param_tab.Controls.Add(this.param_btnAjt);
            this.param_tab.Controls.Add(this.dataGridView1);
            this.param_tab.Location = new System.Drawing.Point(4, 22);
            this.param_tab.Name = "param_tab";
            this.param_tab.Padding = new System.Windows.Forms.Padding(3);
            this.param_tab.Size = new System.Drawing.Size(792, 424);
            this.param_tab.TabIndex = 0;
            this.param_tab.Text = "Paramètres";
            this.param_tab.UseVisualStyleBackColor = true;
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
            // stock_tab
            // 
            this.stock_tab.Location = new System.Drawing.Point(4, 22);
            this.stock_tab.Name = "stock_tab";
            this.stock_tab.Padding = new System.Windows.Forms.Padding(3);
            this.stock_tab.Size = new System.Drawing.Size(792, 424);
            this.stock_tab.TabIndex = 2;
            this.stock_tab.Text = "Stocks";
            this.stock_tab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(778, 376);
            this.dataGridView1.TabIndex = 0;
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
            // param_btnAjt
            // 
            this.param_btnAjt.Location = new System.Drawing.Point(9, 393);
            this.param_btnAjt.Name = "param_btnAjt";
            this.param_btnAjt.Size = new System.Drawing.Size(75, 23);
            this.param_btnAjt.TabIndex = 1;
            this.param_btnAjt.Text = "Ajouter";
            this.param_btnAjt.UseVisualStyleBackColor = true;
            // 
            // param_btnSupprimer
            // 
            this.param_btnSupprimer.Location = new System.Drawing.Point(709, 393);
            this.param_btnSupprimer.Name = "param_btnSupprimer";
            this.param_btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.param_btnSupprimer.TabIndex = 2;
            this.param_btnSupprimer.Text = "Supprimer";
            this.param_btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // param_btnEdit
            // 
            this.param_btnEdit.Location = new System.Drawing.Point(359, 393);
            this.param_btnEdit.Name = "param_btnEdit";
            this.param_btnEdit.Size = new System.Drawing.Size(75, 23);
            this.param_btnEdit.TabIndex = 3;
            this.param_btnEdit.Text = "Modifier";
            this.param_btnEdit.UseVisualStyleBackColor = true;
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
            this.param_tab.ResumeLayout(false);
            this.donnee_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage param_tab;
        private System.Windows.Forms.TabPage donnee_tab;
        private System.Windows.Forms.TabPage stock_tab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage donnee_article_tab;
        private System.Windows.Forms.TabPage donnee_fabricants_tab;
        private System.Windows.Forms.TabPage donnee_depot_tab;
        private System.Windows.Forms.Button param_btnEdit;
        private System.Windows.Forms.Button param_btnSupprimer;
        private System.Windows.Forms.Button param_btnAjt;
    }
}

