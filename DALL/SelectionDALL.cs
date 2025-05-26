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

       

        public DataTable afficherStockDate(DateTime date)
        {
            string query = "DECLARE @dateDernierINV DATETIME;" +
                "SELECT @dateDernierINV = (" +
                "    SELECT TOP 1 dateHr" +
                "    FROM mouvstock" +
                "   WHERE dateHr <= @dateCible AND type = 'INV'" +
                "   ORDER BY dateHr DESC" +
                ");";
            query += "SELECT sum(qte) as 'Stock à la date', a.libelle , CONCAT(d.nom, ', ', d.ville) AS 'Dépôt', @dateDernierINV AS 'Date du dernier inventaire'" +
                "FROM mouvstock\r\n" +
                "JOIN Articles a ON a.refArticles = mouvstock.refArticle\r\n" +
                "JOIN dépôt d ON d.idDepot = a.codeDep\r\nWHERE dateHr >= @dateDernierINV\r\nAND dateHr <= @dateCible\r\nGROUP BY a.libelle, d.nom, d.ville";
            SqlParameter[] checkParam = new SqlParameter[]
                    {
                        new SqlParameter("@dateCible", SqlDbType.DateTime) { Value = date}
                    };
            return ExecuteSelect(query, checkParam);

        }

        

        public DataTable search( string choix, string param = null)
        {
            string query = null;
            string lib = null;
            if(choix == "fab")
            {
                query = " SELECT * FROM fabricants";
                lib = "CONCAT(nomEnt,marque,refFab)";
            }
            else if(choix == "dep")
            {
                query = " SELECT * FROM dépôt";
                lib = "CONCAT(ville,nom,pays,idDepot,lattitude,longitude)";
            }
            else if(choix == "uni")
            {
                query = " SELECT * FROM unité";
                lib = "CONCAT(codeUni,libelle)";

            }
            else if(choix == "cat")
            {
                query = " SELECT * FROM  [catégorie_d_articles]";
                lib = "CONCAT(codeCat,libelle)";

            }else if(choix == "mvt")
            {
                query += "SELECT id, a.libelle, m.dateHr, m.qte, CONCAT(d.nom, ', ', d.ville) as dépôt FROM mouvstock m " +
                    " JOIN Articles a ON a.refArticles = m.refArticle" +
                    " JOIN dépôt d ON d.idDepot = m.numDepot";

                lib = "type = 'MVT' AND  CONCAT(a.libelle, dateHr, qte, d.nom)";
            }
            else if (choix == "inv")
            {
                query += "SELECT id, a.libelle, m.dateHr, m.qte, CONCAT(d.nom, ', ', d.ville) as dépôt FROM mouvstock m " +
                    " JOIN Articles a ON a.refArticles = m.refArticle" +
                    " JOIN dépôt d ON d.idDepot = m.numDepot";

                lib = "type = 'INV' AND CONCAT(a.libelle, dateHr, qte, d.nom)";
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



        

        public DataTable Charger(string nomTable)
        {
            string query = $"SELECT * FROM {nomTable}";
            return ExecuteSelect(query);
        }

       




    }
}
