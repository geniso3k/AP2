using AP2.DALL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP2
{
    public partial class FormAjouterArticle : Form
    {
        private ConnexionDB db;
        public FormAjouterArticle()
        {
            InitializeComponent();
            db = new ConnexionDB(); // Initialisation de l'objet ConnexionDB
            LoadStockData();
        }
        private void LoadStockData()
        {
            try
            {
                // Charger les catégories
                string queryCategorie = "SELECT codeCat AS id, libelle FROM [catégorie_d_articles]";
                DataTable resultCategories = db.ExecuteSelect(queryCategorie);
                cb_Cat.DataSource = resultCategories;
                cb_Cat.DisplayMember = "libelle";
                cb_Cat.ValueMember = "id";

                // Charger les fabricants
                string queryFab = "SELECT refFab AS id, nomEnt FROM fabricants";
                DataTable resultFabs = db.ExecuteSelect(queryFab);
                cb_Fab.DataSource = resultFabs;
                cb_Fab.DisplayMember = "nomEnt";
                cb_Fab.ValueMember = "id";

                // Charger les dépôts
                string queryDepot = "SELECT idDepot AS id, nom FROM dépôt";
                DataTable resultDepots = db.ExecuteSelect(queryDepot);
                cb_Dep.DataSource = resultDepots;
                cb_Dep.DisplayMember = "nom";
                cb_Dep.ValueMember = "id";

                // Charger les dépôts
                string queryUni = "SELECT codeUni AS id, libelle as nom FROM unité";
                DataTable resultUni = db.ExecuteSelect(queryUni);
                cb_Uni.DataSource = resultUni;
                cb_Uni.DisplayMember = "nom";
                cb_Uni.ValueMember = "id";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message);
            }
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            SelectionDALL selectionDALL = new SelectionDALL();

            if (!string.IsNullOrEmpty(txtLibelle.Text)){
                bool reussite =
                selectionDALL.ajouterProduit(
                    Convert.ToString(cb_Cat.SelectedValue),
                    Convert.ToString(cb_Fab.SelectedValue),
                    Convert.ToString(cb_Dep.SelectedValue),
                    Convert.ToString(cb_Uni.SelectedValue),
                    txtLibelle.Text
                    );
                if(reussite)
                {
                    txtLibelle.Clear();
                    cb_Cat.SelectedIndex = -1;
                    cb_Fab.SelectedIndex = -1;
                    cb_Dep.SelectedIndex = -1;
                    cb_Uni.SelectedIndex = -1;
                    MessageBox.Show("Produit ajouté avec succès");
                    this.Close();
                }
                

            }
            else
            {
                txtLibelle.Focus();
            }
        }
    }
}
