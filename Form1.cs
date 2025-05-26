using AP2.DALL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AP2
{
    public partial class Form1 : Form
    {

        private ConnexionDB db; // Instance de la classe ConnexionDB
        private DataGridView dgvCible = null;

        //Instance et initialisation des DALL
        SelectionDALL sdall = new SelectionDALL();
        InsertionDALL idall = new InsertionDALL();
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            db = new ConnexionDB(); // Initialisation de l'objet ConnexionDB

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try {

                LoadStockData();


            }
            catch(Exception ex) {
                MessageBox.Show("Une erreur est survenue : "+ ex.Message);
            }
            
        }

        public void LoadStockData()
        {
            try
            {
                dgv_AllFab.CellValueChanged += dgv_AllFab_CellValueChanged;
                dgv_AllFab.CellEndEdit += dgv_AllFab_CellEndEdit;

                dgv_allDep.CellValueChanged += dgv_allDep_CellValueChanged;
                dgv_allDep.CellEndEdit += dgv_allDep_CellEndEdit;

                dgvCat.CellValueChanged += dgvCat_CellValueChanged;
                dgvCat.CellEndEdit += dgvCat_CellEndEdit;

                dgv_Uni.CellValueChanged += dgv_Uni_CellValueChanged;
                dgv_Uni.CellEndEdit += dgv_Uni_CellEndEdit;

                //  attachement des handlers pour 2 DGV

                supprimerToolStripMenuItem.Click += supprimerToolStripMenuItem_Click;

                dgv_allDep.MouseDown += dataGridView_MouseDown;
                dgv_AllFab.MouseDown += dataGridView_MouseDown;
                stockDgv.MouseDown += dataGridView_MouseDown;
                dgvCat.MouseDown += dataGridView_MouseDown;
                dgv_Uni.MouseDown += dataGridView_MouseDown;

                btnAfficherStock_Click(null,null);


                // Charger les unités
                string queryUni = "SELECT * FROM unité";
                DataTable resultUni = db.ExecuteSelect(queryUni);
                dgv_Uni.DataSource = resultUni;



                // Charger les catégories
                string queryCategorie = "SELECT codeCat, Libelle FROM [catégorie_d_articles]";
                DataTable resultCategories = db.ExecuteSelect(queryCategorie);
                DataRow newRowCat = resultCategories.NewRow();
                dgvCat.DataSource = resultCategories.Copy();
                newRowCat["codeCat"] = 0;  // Mettre un entier au lieu de "*"
                newRowCat["libelle"] = "Toutes";
                resultCategories.Rows.InsertAt(newRowCat, 0);
                cb_cat.DataSource = resultCategories;
                cb_cat.DisplayMember = "libelle";
                cb_cat.ValueMember = "codeCat";

                // Charger les fabricants
                string queryFab = "SELECT refFab AS id, nomEnt FROM fabricants";
                DataTable resultFabs = db.ExecuteSelect(queryFab);
                DataRow newRowFab = resultFabs.NewRow();
                newRowFab["id"] = 0;  // Mettre un entier au lieu de "*"
                newRowFab["nomEnt"] = "Tous";
                resultFabs.Rows.InsertAt(newRowFab, 0);
                cb_Fab.DataSource = resultFabs;
                cb_Fab.DisplayMember = "nomEnt";
                cb_Fab.ValueMember = "id";

                // Charger les dépôts
                string queryDepot = "SELECT idDepot AS id, nom FROM dépôt";
                DataTable resultDepots = db.ExecuteSelect(queryDepot);
                DataRow newRowDep = resultDepots.NewRow();
                newRowDep["id"] = 0;  // Mettre un entier au lieu de "*"
                newRowDep["nom"] = "Tous";
                resultDepots.Rows.InsertAt(newRowDep, 0);
                cb_Dep.DataSource = resultDepots;
                cb_Dep.DisplayMember = "nom";
                cb_Dep.ValueMember = "id";

                string queryInv = "select id, a.libelle, dateHr as Date, qte as Quantité, CONCAT(d.nom, ', ', d.ville) as Dépôt\r\nFROM mouvstock m\r\nJOIN Articles a ON a.refArticles = m.refArticle\r\nJOIN dépôt d ON d.idDepot = m.numDepot\r\n WHERE TYPE='INV' ORDER BY dateHr desc";
                DataTable resultInv = db.ExecuteSelect(queryInv);
                dgv_Inv.DataSource = resultInv;

                string queryMvt = "select id, a.libelle, dateHr as Date, qte as Quantité, CONCAT(d.nom, ', ', d.ville) as Dépôt\r\nFROM mouvstock m\r\nJOIN Articles a ON a.refArticles = m.refArticle\r\nJOIN dépôt d ON d.idDepot = m.numDepot\r\n WHERE TYPE='MVT' ORDER BY dateHr desc";
                DataTable resultMvt = db.ExecuteSelect(queryMvt);
                dgv_Mvt.DataSource = resultMvt;

                
                DataTable dt = this.sdall.search("dep");
                dgv_allDep.DataSource = dt;
                DataTable dt2 = this.sdall.search("fab");
                dgv_AllFab.DataSource = dt2;

                // Charger les articles au démarrage
                LoadArticles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message);
            }
        }

        private void dataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var dgv = sender as DataGridView;
                var hit = dgv.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    dgv.ClearSelection();
                    dgv.Rows[hit.RowIndex].Selected = true;
                    dgv.CurrentCell = dgv.Rows[hit.RowIndex].Cells[0];
                    dgvCible = dgv; // mémorise la grille ciblée
                }
            }
        }
        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvCible != null && dgvCible.SelectedRows.Count > 0)
            {

                string rowIndex = dgvCible.SelectedRows[0].Cells[0].Value.ToString();
                string subst = rowIndex.Substring(0, 3); // avoir uniquement le mot FAB ou DEP
                if (this.idall.deleteFabOuDep(rowIndex, subst))
                {
                    MessageBox.Show("Action réalisée avec succès");
                    this.LoadStockData();
                }
                
            }
        }

        private void LoadArticles()
        {
            try
            {
                

                // Récupération des valeurs sélectionnées
                string categorie = cb_cat.SelectedValue != null && cb_cat.SelectedValue.ToString() != "0" ? cb_cat.SelectedValue.ToString() : "*";
                string fabricant = cb_Fab.SelectedValue != null && cb_Fab.SelectedValue.ToString() != "0" ? cb_Fab.SelectedValue.ToString() : "*";
                string libelle = !string.IsNullOrEmpty(txtLibelle.Text) ? txtLibelle.Text.Trim() : "";
                bool triDesc = true;// chkTriDesc.Checked;

                // Appel à la fonction de récupération des articles
                DataTable dt = this.sdall.Rafraichir(categorie, fabricant, libelle, triDesc);

                // Liaison des résultats au DataGridView
                stockDgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des articles : " + ex.Message);
            }
        }
        private void cb_cat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadArticles();
        }

        private void cb_Fab_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadArticles();
        }

        private void cb_Dep_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadArticles();
        }

        private void cb_lib_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadArticles();
        }

        private void chkTriDesc_CheckedChanged(object sender, EventArgs e)
        {
            LoadArticles();
        }

        private void txtLibelle_TextChanged(object sender, EventArgs e)
        {
            LoadArticles();
        }

        private void param_btnAjt_Click(object sender, EventArgs e)
        {
            Form formAjouterArticle = new FormAjouterArticle(this);
            formAjouterArticle.Show();
        }

        private void chkTri_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = stockDgv.DataSource as DataTable;
            DataView dv = dt.DefaultView;
            if (dt == null)
            {
                MessageBox.Show("Pas de donnée trouvée");
                return;
            }

            if (chkTri.Checked)
            {
               dv.Sort = "Référence DESC";
            }
            else
            {
               dv.Sort = "Référence ASC";
            }
        }

        private void btnAfficherStock_Click(object sender, EventArgs e)
        {
            DateTime dateCible = datePickerStock.Value;
            
            DataTable dt = this.sdall.afficherStockDate(dateCible);
            dgvStock.DataSource = dt;


        }

        private void btnMvt_Click(object sender, EventArgs e)
        {
            Form formAjouterMvt = new FormAjouterMvt(this);
            formAjouterMvt.Show();

        }

        private void txt_searchFab_TextChanged(object sender, EventArgs e)
        {

            
            DataTable dt = this.sdall.search("fab", txt_searchFab.Text);
            dgv_AllFab.DataSource = dt;

        }
        private void txt_searchDep_TextChanged(object sender, EventArgs e)
        {

            
            DataTable dt = this.sdall.search("dep", txt_searchDep.Text);
            dgv_allDep.DataSource = dt;

        }

        private void btn_AjtDep_Click(object sender, EventArgs e)
        {
            Form nf = new FormAjouterDepot(this);
            nf.Show();
        }

        private void btn_AjtFab_Click(object sender, EventArgs e)
        {
            Form nf = new FormAjouterFab(this);
            nf.Show();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = tabControl1.SelectedIndex;
            MessageBox.Show(index.ToString());
        }


        private void dgv_AllFab_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgv_AllFab.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void dgv_AllFab_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            
            if(this.idall.ModifierDGV((DataGridView)sender, e.RowIndex, e.ColumnIndex, "Fabricants"))
            {
                MessageBox.Show("Modification effectuée !");
            }
            else
            {
                MessageBox.Show("Aucune modification effectuée !");
            }

        }


        private void dgv_allDep_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgv_allDep.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void dgv_allDep_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            
            if (this.idall.ModifierDGV((DataGridView)sender, e.RowIndex, e.ColumnIndex, "Dépôt"))
            {
                MessageBox.Show("Modification effectuée !");
            }
            else
            {
                MessageBox.Show("Aucune modification effectuée !");
            }

        }

        private void dgvCat_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgvCat.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void dgvCat_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            
            if (this.idall.ModifierDGV((DataGridView)sender, e.RowIndex, e.ColumnIndex, "catégorie_d_articles"))
            {
                MessageBox.Show("Modification effectuée !");
            }
            else
            {
                MessageBox.Show("Aucune modification effectuée !");
            }

        }
        private void dgv_Uni_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgv_Uni.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void dgv_Uni_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            
            if (this.idall.ModifierDGV((DataGridView)sender, e.RowIndex, e.ColumnIndex, "unité"))
            {
                MessageBox.Show("Modification effectuée !");
            }
            else
            {
                MessageBox.Show("Aucune modification effectuée !");
            }

        }

        private void stockDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if(e.RowIndex >= 0)
            {
                DataGridViewRow dgv = stockDgv.Rows[e.RowIndex];

                string id = dgv.Cells["Référence"].Value.ToString();
                string lib = dgv.Cells["Libellé"].Value.ToString();
                string cat = dgv.Cells["Catégorie"].Value.ToString(); 
                string fab = dgv.Cells["Fabricant"].Value.ToString();
                string uni = dgv.Cells["Unité"].Value.ToString(); 
                string dep = dgv.Cells["Dépôt"].Value.ToString();

                FormModifierArticle modifier = new FormModifierArticle(this, id, lib, cat, fab, uni, dep);
                modifier.Show();
            }

        }

        private void btn_addCat_Click(object sender, EventArgs e)
        {
            Form ajtCat = new FormAjouterCat(this);
            ajtCat.Show();
        }

        private void btn_ajouterUni_Click(object sender, EventArgs e)
        {
            Form ajtCat = new FormAjouterUni(this);
            ajtCat.Show();
        }

        private void txt_searchCat_TextChanged(object sender, EventArgs e)
        {
            
            DataTable dt = this.sdall.search("cat", txt_searchCat.Text);
            dgvCat.DataSource = dt;
        }

        private void txt_searchUni_TextChanged(object sender, EventArgs e)
        {
            
            DataTable dt = this.sdall.search("uni", txt_searchUni.Text);
            dgv_Uni.DataSource = dt;
        }

        private void txt_searchMvt_TextChanged(object sender, EventArgs e)
        {
            
            DataTable dt = this.sdall.search("mvt", txt_searchMvt.Text);
            dgv_Mvt.DataSource = dt;
        }

        private void txt_searchInv_TextChanged(object sender, EventArgs e)
        {
            
            DataTable dt = this.sdall.search("inv", txt_searchInv.Text);
            dgv_Inv.DataSource = dt;
        }

        private void btn_inv_Click(object sender, EventArgs e)
        {
            Form ajtInv = new FormAjouterInv(this);
            ajtInv.Show();
        }
    }
}
