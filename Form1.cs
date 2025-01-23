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
            // format ISO 8601 POUR MOUVEMENTSSTOCK !!!!!
            try
            {
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message);
            }

            try
            {
                string requete = "SELECT codeCat AS id, libelle FROM [catégorie_d_articles]";
                DataTable resultats = db.ExecuteSelect(requete);
                DataRow newRow = resultats.NewRow();
                newRow["id"] = 0;
                newRow["libelle"] = "Tous";
                resultats.Rows.InsertAt(newRow, 0);
                cb_cat.DataSource = resultats;
                cb_cat.DisplayMember = "libelle";
                cb_cat.ValueMember = "id";
                

            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des données : " + ex.Message);
            }

        }

        private void modifierData()
        {

            string Cat = cb_cat.SelectedValue.ToString();
            string Fab = cb_Fab.SelectedValue.ToString();
            string Dep = cb_Dep.SelectedValue.ToString();
            string Lib = cb_lib.SelectedValue.ToString();

            if (Cat == "0" && Fab == "0" && Dep == "0" && Lib == "0")
            {
                string requete = "SELECT mouvstocks.refArticles AS Référence a.libelle AS [Article], D.nom AS [Dépot], mouvstocks.dateHr AS [Date-Heure], " +
                                 "mouvstocks.typeMvm AS Type, mouvstocks.quantite AS Quantite " +
                                 "FROM mouvstocks " +
                                 "JOIN Articles AS A ON A.refArticles = mouvstocks.refArticles " +
                                 "JOIN [dépôt] AS D ON D.idDepot = mouvstocks.idDepot;";



                DataTable resultats = db.ExecuteSelect(requete);
                stockDgv.DataSource = resultats;
                stockDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
        
        private void changerCb(ComboBox cb, int id, string donnee, string table)
        {
            try
            {


                string requete = $"SELECT {id} AS id, {donnee} AS libelle FROM {table}";
                DataTable resultats = db.ExecuteSelect(requete);
                DataRow newRow = resultats.NewRow();
                newRow["id"] = 0;
                newRow["libelle"] = "Tous";
                resultats.Rows.InsertAt(newRow, 0);
                cb.DataSource = resultats;
                cb.DisplayMember = "libelle";
                cb.ValueMember = "id";
            }catch(Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement de la combobox : " + ex.Message);
            }
        }
        private void cb_cat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cb_cat.SelectedValue != null)
            {
               // modifierData(cb_cat.SelectedValue.ToString(), 1);
            }
        }

        private void cb_Fab_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cb_Fab.SelectedValue != null)
            {

            }

        }

        private void cb_Dep_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cb_Dep.SelectedValue != null)
            {

            }
        }

        private void cb_lib_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cb_lib.SelectedValue != null)
            {

            }
        }
    }
}
