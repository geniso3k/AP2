using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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



    }
}
