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
        private void LoadStockData()
        {
            try
            {
                dgv_AllFab.CellValueChanged += dgv_AllFab_CellValueChanged;
                dgv_AllFab.CellEndEdit += dgv_AllFab_CellEndEdit;

                dgv_allDep.CellValueChanged += dgv_allDep_CellValueChanged;
                dgv_allDep.CellEndEdit += dgv_allDep_CellEndEdit;

                // Charger les catégories
                string queryCategorie = "SELECT codeCat AS id, libelle FROM [catégorie_d_articles]";
                DataTable resultCategories = db.ExecuteSelect(queryCategorie);
                DataRow newRowCat = resultCategories.NewRow();
                newRowCat["id"] = 0;  // Mettre un entier au lieu de "*"
                newRowCat["libelle"] = "Toutes";
                resultCategories.Rows.InsertAt(newRowCat, 0);
                cb_cat.DataSource = resultCategories;
                cb_cat.DisplayMember = "libelle";
                cb_cat.ValueMember = "id";

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


                SelectionDALL selectionDALL = new SelectionDALL();
                DataTable dt = selectionDALL.search("dep");
                dgv_allDep.DataSource = dt;
                DataTable dt2 = selectionDALL.search("fab");
                dgv_AllFab.DataSource = dt2;

                // Charger les articles au démarrage
                LoadArticles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message);
            }
        }



        private void LoadArticles()
        {
            try
            {
                SelectionDALL selectionDALL = new SelectionDALL();

                // Récupération des valeurs sélectionnées
                string categorie = cb_cat.SelectedValue != null && cb_cat.SelectedValue.ToString() != "0" ? cb_cat.SelectedValue.ToString() : "*";
                string fabricant = cb_Fab.SelectedValue != null && cb_Fab.SelectedValue.ToString() != "0" ? cb_Fab.SelectedValue.ToString() : "*";
                string libelle = !string.IsNullOrEmpty(txtLibelle.Text) ? txtLibelle.Text.Trim() : "";
                bool triDesc = true;// chkTriDesc.Checked;

                // Appel à la fonction de récupération des articles
                DataTable dt = selectionDALL.Rafraichir(categorie, fabricant, libelle, triDesc);

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
            Form formAjouterArticle = new FormAjouterArticle();
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
            SelectionDALL sd = new SelectionDALL();
            DataTable dt = sd.afficherStockDate(dateCible);
            dgvStock.DataSource = dt;


        }

        private void btnMvt_Click(object sender, EventArgs e)
        {
            Form formAjouterMvt = new FormAjouterMvt();
            formAjouterMvt.Show();

        }

        private void txt_searchFab_TextChanged(object sender, EventArgs e)
        {

            SelectionDALL selectionDALL = new SelectionDALL();
            DataTable dt = selectionDALL.search("fab", txt_searchFab.Text);
            dgv_AllFab.DataSource = dt;

        }

        private void btn_AjtDep_Click(object sender, EventArgs e)
        {
            SelectionDALL selectionDALL = new SelectionDALL();
            DataTable dt = selectionDALL.search("dep", txt_searchDep.Text);
            dgv_allDep.DataSource = dt;
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

            SelectionDALL sd = new SelectionDALL();
            if(sd.ModifierDGV((DataGridView)sender, e.RowIndex, e.ColumnIndex, "Fabricants"))
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

            SelectionDALL sd = new SelectionDALL();
            if (sd.ModifierDGV((DataGridView)sender, e.RowIndex, e.ColumnIndex, "Dépôt"))
            {
                MessageBox.Show("Modification effectuée !");
            }
            else
            {
                MessageBox.Show("Aucune modification effectuée !");
            }

        }








    }
}
