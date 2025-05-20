using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP2.DALL
{
    class InsertionDALL : ConnexionDB
    {

        public bool ajouterFab(string refF, string ent, string mar)
        {
            try
            {

                string query = "INSERT INTO fabricants (refFab, nomEnt, marque) VALUES (@r, @e, @m)";

                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@r", refF),
                    new SqlParameter("@e", ent),
                    new SqlParameter("@m", mar)
                };

               return ExecuterCommande(query, param);

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        public bool ajouterDep(string refD, string nom, string ville, string pays, string lattitude, string longitude)
        {
            try
            {

                string query = "INSERT INTO dépôt (idDepot, nom, ville, pays, lattitude, longitude) VALUES (@r, @n, @v, @p, @l, @lo)";

                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@r", refD),
                    new SqlParameter("@n", nom),
                    new SqlParameter("@v", ville),
                    new SqlParameter("@p", pays),
                    new SqlParameter("@l", lattitude),
                    new SqlParameter("@lo", longitude)
                };

                return ExecuterCommande(query, param);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        //Permet d'ajouter une catégorie OU un article en fonction du parameter
        public bool ajouterCatouUni(string code, string lib, string parameter)
        {
            try
            {
                string query = null;
                if (parameter == "CAT")
                {

                    query = "INSERT INTO [catégorie_d_articles] (codeCat,libelle) VALUES (@c, @l)";

                }
                else
                {
                    query = "INSERT INTO unité (codeUni,libelle) VALUES (@c, @l)";
                }

                SqlParameter[] param = new SqlParameter[]
                {
                    new SqlParameter("@c", code),
                    new SqlParameter("@l", lib),
                };

                return ExecuterCommande(query, param);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

    }
}
