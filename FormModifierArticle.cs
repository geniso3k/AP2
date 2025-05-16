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
    public partial class FormModifierArticle : Form
    {
        private SelectionDALL sd = new SelectionDALL();
        private string id;
        private Form1 parentForm;
        private string lib;
        private string cat;
        private string fab;
        private string uni;
        private string dep;

        public FormModifierArticle( Form1 parent,string id = null, string lib = null, string cat = null, string fab = null, string uni = null, string dep = null)
        {
            InitializeComponent();
            this.parentForm = parent;
            if (id != null)
            {   
                
                this.id = id;
                this.lib = lib;
                this.cat = cat;
                this.fab = fab;
                this.uni = uni;
                this.dep = dep;

                txt_ref.Text = id;
                txt_libelle.Text = lib;
                this.chargerCat();
            }
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Voulez vous vraiment supprimer l'article dont la référence est "+this.id+" ?", "Suppression", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes && this.sd.delete("articles", "refArticles", this.id))
            {
                MessageBox.Show("L'article a été supprimé avec succès.");
                this.parentForm.LoadStockData();
                this.Close();
            }
        }

        private void chargerCat()
        {

            DataTable dt;
            
            dt = this.sd.Charger("catégorie_d_articles");

            cb_cat.DataSource = dt;
            cb_cat.DisplayMember = "libelle";
            cb_cat.ValueMember = "codeCat";

            cb_cat.SelectedValue = GetIdByLibelle(dt, this.cat, "codeCat", "libelle");
            


            dt = this.sd.Charger("Fabricants");

            cb_fab.DataSource = dt;
            cb_fab.DisplayMember = "nomEnt";
            cb_fab.ValueMember = "refFab";

            cb_fab.SelectedValue = GetIdByLibelle(dt, this.fab, "refFab", "nomEnt");


            dt = this.sd.Charger("unité");

            cb_unite.DataSource = dt;
            cb_unite.DisplayMember = "libelle";
            cb_unite.ValueMember = "codeUni";

            cb_unite.SelectedValue = GetIdByLibelle(dt, this.uni, "codeUni", "libelle");


            dt = this.sd.Charger("dépôt");

            // Ajoute une colonne pour l'affichage combiné
            dt.Columns.Add("affichage", typeof(string));
            foreach (DataRow row in dt.Rows)
            {
                row["affichage"] = $"{row["nom"]} ({row["ville"]})";
            }

            cb_depot.DataSource = dt;
            cb_depot.DisplayMember = "affichage";
            cb_depot.ValueMember = "idDepot";

            cb_depot.SelectedValue = GetIdByLibelle(dt, this.dep, "idDepot", "nom");


        }
        private string GetIdByLibelle(DataTable dt, string libelle, string param1, string param2)
        {
            var row = dt.AsEnumerable()
                        .FirstOrDefault(r => r[param2].ToString() == libelle);

            if (row != null)
            {
                return row[param1].ToString(); // Ou "id" si ta colonne s'appelle "id"
            }

            return null; // ou "" si tu préfères
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            // Récupérer les valeurs du formulaire
            string libelle = txt_libelle.Text.Trim();
            string codeCat = cb_cat.SelectedValue?.ToString();
            string refFab = cb_fab.SelectedValue?.ToString();
            string codeUni = cb_unite.SelectedValue?.ToString();
            string idDepot = cb_depot.SelectedValue?.ToString();

            if (sd.editerArticle(this.id, libelle, codeCat, refFab, codeUni, idDepot))
            {
                MessageBox.Show("Article modifié avec succès.");
                this.parentForm.LoadStockData();
                this.Close();
            }

        }
    }
}
