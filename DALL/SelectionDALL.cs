using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AP2.DALL
{
    class SelectionDALL : ConnexionDB
    {
        public DataTable Rafraichir(string categorie, string fabricant, string libelle, bool triDesc)
        {
            string query = @"
 SELECT 
     a.refArticles AS Référence, 
     a.libelle AS Libellé, 
     c.libelle AS Catégorie, 
     f.nomEnt AS Fabricant,
	 u.libelle AS Unité,
     d.nom AS Dépôt
 FROM articles a

 JOIN catégorie_d_articles c ON a.codeCat = c.codeCat
 JOIN fabricants f ON a.refFab = f.refFab
 JOIN dépôt d ON a.codeDep = d.idDepot
 JOIN unité u ON a.codeUni = u.codeUni
 where 1=1

";

            List<SqlParameter> parameters = new List<SqlParameter>();

            // Vérification des filtres et exclusion de ceux contenant "*"
            if (!string.IsNullOrEmpty(categorie) && categorie != "*")
            {
                query += " AND c.codeCat = @categorie";
                parameters.Add(new SqlParameter("@categorie", categorie));
            }

            if (!string.IsNullOrEmpty(fabricant) && fabricant != "*")
            {
                query += " AND f.refFab = @fabricant";
                parameters.Add(new SqlParameter("@fabricant", fabricant));
            }


            if (!string.IsNullOrEmpty(libelle) && libelle != "*")
            {
                query += " AND a.libelle LIKE @libelle";
                parameters.Add(new SqlParameter("@libelle", "%" + libelle + "%"));
            }

           
            // Ajout du tri
            query += triDesc ? " ORDER BY a.refArticles DESC;" : " ORDER BY a.refArticles ASC";
            if (libelle == "*")
            {
                query += " LIMIT 20;";
            }
            return ExecuteSelect(query, parameters.ToArray());
        }

        public  bool ajouterProduit(string categorie, string fab, string dep, string unite, string libelle)
        {
            try
            {
                string query = "INSERT INTO articles (libelle, codeUni,refFab, codeCat, codeDep) VALUES (@libelle, @codeUni, @refFab, @codeCat, @codeDep)";
                SqlParameter[] checkParam = new SqlParameter[]
                    {
                    new SqlParameter("@libelle", libelle),
                    new SqlParameter("@codeUni", unite),
                    new SqlParameter("@refFab", fab),
                    new SqlParameter("@codeCat", categorie),
                    new SqlParameter("@codeDep", dep)
                    };

                return ExecuterCommande(query, checkParam.ToArray());
                
            }catch(Exception ex)
            {
                MessageBox.Show("Erreur "+ex.Message);
                return false;
            }

        }

        public DataTable afficherStockDate(DateTime date)
        {

            string query = "" +
                "SELECT alibelle as Libelle, dnom as Dépôt, stockAlaDate, dateDernierInventaire " +
                "FROM fn_StockAlaDate(@date)";
            SqlParameter[] checkParam = new SqlParameter[]
                    {
                        new SqlParameter("@date", SqlDbType.DateTime) { Value = date}
                    };
            return ExecuteSelect(query, checkParam);

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

            return ExecuterCommande(query, checkParam) ? true: false;
            
        }

        public DataTable search( string choix, string param = null)
        {
            string query = "SELECT * FROM ";
            string lib;
            if(choix == "fab")
            {
                query += "fabricants";
                lib = "nomEnt";
            }
            else
            {
                query += "dépôt";
                lib = "ville";
            }

            
            if (param != null)
            {
                query += " WHERE "+lib+" LIKE @libelle;";
                

                SqlParameter[] checkParam = new SqlParameter[]
                        {
                        new SqlParameter("@libelle",  "%"+param+"%")
                        };
                return ExecuteSelect(query, checkParam);
            }
            else
            {

                return ExecuteSelect(query);
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




                string query = $"UPDATE {nomTable} SET {columnName} = @val WHERE {dgv.Columns[0].Name} = @id";

                SqlParameter[] checkParam = new SqlParameter[]
                            {
                        new SqlParameter("@val",  newValue),
                        new SqlParameter("@id",  idValue)
                            };

                return ExecuterCommande(query, checkParam) ? true : false;
            }catch(Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
                return false;
            }

        }


    }
}
