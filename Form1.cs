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

        private void dgvStock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                string cellValue = dgvStock.Rows[e.RowIndex].Cells[0].Value.ToString();
                MessageBox.Show(cellValue.ToString());
            }
        }
    }
}
