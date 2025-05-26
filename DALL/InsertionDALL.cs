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

        public bool ajouterProduit(string refA, string categorie, string fab, string dep, string unite, string libelle)
        {
            try
            {
                string query = "INSERT INTO articles (refArticles, libelle, codeUni,refFab, codeCat, codeDep) VALUES (@ref,@libelle, @codeUni, @refFab, @codeCat, @codeDep)";
                SqlParameter[] checkParam = new SqlParameter[]
                    {
                        new SqlParameter("@ref", refA),
                    new SqlParameter("@libelle", libelle),
                    new SqlParameter("@codeUni", unite),
                    new SqlParameter("@refFab", fab),
                    new SqlParameter("@codeCat", categorie),
                    new SqlParameter("@codeDep", dep)
                    };

                return ExecuterCommande(query, checkParam.ToArray());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur " + ex.Message);
                return false;
            }

        }

        public bool ajouterMvt(string refA, DateTime date, int qte, string numDepot)
        {
            string query = "INSERT INTO mouvstock(refArticle, dateHr, type, qte,numDepot) VALUES (@ref, @dat, 'MVT', @qte, @numD)";
            SqlParameter[] checkParam = new SqlParameter[]
            {
                new SqlParameter("@ref", refA),
                new SqlParameter("@dat", date),
                new SqlParameter("@qte", qte),
                new SqlParameter("@numD", numDepot)

            };

            return ExecuterCommande(query, checkParam) ? true : false;

        }

        public bool ajouterInv(string refA, DateTime date, int qte, string numDepot)
        {
            try
            {
                string query = "INSERT INTO mouvstock(refArticle, dateHr, type, qte,numDepot) VALUES (@ref, @dat, 'INV', @qte, @numD)";
                SqlParameter[] checkParam = new SqlParameter[]
                {
                new SqlParameter("@ref", refA),
                new SqlParameter("@dat", date),
                new SqlParameter("@qte", qte),
                new SqlParameter("@numD", numDepot)

                };

                return ExecuterCommande(query, checkParam) ? true : false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool ModifierDGV(DataGridView dgv, int rowIndex, int colIndex, string nomTable)
        {
            try
            {
                if (rowIndex < 0 || colIndex < 0 || dgv == null || dgv.Rows.Count <= rowIndex)
                    return false;

                var newValue = dgv.Rows[rowIndex].Cells[colIndex].Value?.ToString();
                if (string.IsNullOrWhiteSpace(newValue))
                    return false;

                string columnName = dgv.Columns[colIndex].Name;



                // ID dans la première colonne
                var idValue = dgv.Rows[rowIndex].Cells[0].Value;
                if (idValue == null)
                    return false;
                string column = dgv.Columns[0].Name;




                string query = $"UPDATE {nomTable} SET {columnName} = @val WHERE {column} = @id";



                SqlParameter[] checkParam = new SqlParameter[]
                            {
                        new SqlParameter("@val",  newValue),
                        new SqlParameter("@id",  idValue)
                            };

                return ExecuterCommande(query, checkParam) ? true : false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
                return false;
            }

        }

        public bool delete(string table, string idName, string id)
        {

            try
            {
                string query = "DELETE FROM " + table + " WHERE " + idName + " = @id";

                SqlParameter[] param = new SqlParameter[]
                {

                    new SqlParameter("@id", id)
                };
                return ExecuterCommande(query, param);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
        public bool deleteFabOuDep(string id, string param)
        {
            try
            {
                string table = null;
                if (param == "FAB")
                {
                    table = "fabricants";
                    param = "refFab= '" + id + "'";

                }
                else if (param == "DEP")
                {
                    table = "dépôt";
                    param = "idDepot = '" + id + "'";
                }
                else if (param == "ART")
                {
                    table = "Articles";
                    param = "refArticles = '" + id + "'";
                }
                else if (param == "CAT")
                {
                    table = "[catégorie_d_articles]";
                    param = "codeCat = '" + id + "'";
                }
                else if (param == "UNI")
                {
                    table = "unité";
                    param = "codeUni = '" + id + "'";
                }

                string query = "DELETE FROM " + table + " WHERE " + param;





                return ExecuterCommande(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        public bool editerArticle(string r, string l, string c, string f, string u, string d)
        {
            // Préparer la requête SQL
            string query = @"
            UPDATE articles
            SET 
                libelle = @libelle,
                codeCat = @codeCat,
                refFab = @refFab,
                codeUni = @codeUni,
                codeDep = @idDepot
            WHERE refArticles = @ref";


            // Créer un tableau de paramètres
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@libelle", l),
            new SqlParameter("@codeCat", c),
            new SqlParameter("@refFab", f),
            new SqlParameter("@codeUni", u),
            new SqlParameter("@idDepot", d),
            new SqlParameter("@ref", r)
            };


            return ExecuterCommande(query, parameters);

        }

    }
}
