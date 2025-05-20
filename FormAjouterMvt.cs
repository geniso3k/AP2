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
    public partial class FormAjouterMvt : Form
    {
        private ConnexionDB db;
        private Form1 ancien;
        public FormAjouterMvt(Form1 ancien)
        {
            this.ancien = ancien;
            InitializeComponent();
            db = new ConnexionDB(); // Initialisation de l'objet ConnexionDB
            LoadStockData();
        }

        private void btnValiderMvt_Click(object sender, EventArgs e)
        {
            SelectionDALL sd = new SelectionDALL();

            if (txt_MvtQtt.Text != "0") {
                if (sd.ajouterMvt(
                    Convert.ToString(cb_MvtArticle.SelectedValue),
                    date_Mvt.Value,
                    Convert.ToInt32(txt_MvtQtt.Text),
                    Convert.ToString(cb_MvtDepot.SelectedValue)
                    ))
                {
                    ancien.LoadStockData();
                    MessageBox.Show("Mouvement ajouté avec succès !");
                }
            }
            else
            {
                MessageBox.Show("La quantité ne peut pas être égale à 0");
            }

        }
        private void LoadStockData()
        {
            try
            {
                // Charger les catégories
                string queryCategorie = "select refArticles as id, libelle from Articles ";
                DataTable resultCategories = db.ExecuteSelect(queryCategorie);
                cb_MvtArticle.DataSource = resultCategories;
                cb_MvtArticle.DisplayMember = "libelle";
                cb_MvtArticle.ValueMember = "id";

                // Charger les fabricants
                string queryFab = "select idDepot as id, CONCAT(nom, ', ', ville) as nomEnt FROM dépôt";
                DataTable resultFabs = db.ExecuteSelect(queryFab);
                cb_MvtDepot.DataSource = resultFabs;
                cb_MvtDepot.DisplayMember = "nomEnt";
                cb_MvtDepot.ValueMember = "id";

                // Charger les dépôts
                txt_MvtQtt.Text = "0";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message);
            }
        }
    }
}
