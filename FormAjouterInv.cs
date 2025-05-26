using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AP2.DALL;

namespace AP2
{
    public partial class FormAjouterInv : Form
    {
        private ConnexionDB db;
        private Form1 ancien;
        private InsertionDALL idall = new InsertionDALL();
        public FormAjouterInv(Form1 ancien)
        {
            this.ancien = ancien;
            InitializeComponent();
            db = new ConnexionDB(); // Initialisation de l'objet ConnexionDB
            LoadStockData();
        }

        private void LoadStockData()
        {
            try
            {
                // Charger les catégories
                string queryCategorie = "select refArticles as id, libelle from Articles ";
                DataTable resultCategories = db.ExecuteSelect(queryCategorie);
                cbArticle.DataSource = resultCategories;
                cbArticle.DisplayMember = "libelle";
                cbArticle.ValueMember = "id";

                // Charger les fabricants
                string queryFab = "select idDepot as id, CONCAT(nom, ', ', ville) as nomEnt FROM dépôt";
                DataTable resultFabs = db.ExecuteSelect(queryFab);
                cbDep.DataSource = resultFabs;
                cbDep.DisplayMember = "nomEnt";
                cbDep.ValueMember = "id";

                // Charger les dépôts
                txtQtt.Text = "0";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message);
            }
        }

        private void btnAjouterInv_Click(object sender, EventArgs e)
        {


            if (txtQtt.Text != "0")
            {
                if (this.idall.ajouterInv(
                    Convert.ToString(cbArticle.SelectedValue),
                    dtpTime.Value,
                    Convert.ToInt32(txtQtt.Text),
                    Convert.ToString(cbDep.SelectedValue)
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


    }
}
