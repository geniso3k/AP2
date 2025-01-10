
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace AP2
{
    internal class Authentifications
    {
        private string username;
        private string password;
        private ConnexionDB db = new ConnexionDB();

        //  Propriété publique pour récupérer le nom d'utilisateur après vérification
        public string Username { get; private set; }

        //  Propriété publique pour stocker l'ID utilisateur si besoin
        public int UserId { get; private set; }

        public Authentifications(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        //  Méthode de vérification des identifiants
        public bool login()
        {
            //  Requête SQL pour récupérer les infos de l'utilisateur
            string requete = "SELECT id_utilisateur, nom_utilisateur, mot_de_passe, sel FROM utilisateurs WHERE nom_utilisateur = @username";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@username", this.username)
            };

            //  Exécution de la requête et récupération des données
            DataTable resultat = db.ExecuteSelect(requete, param);

            if (resultat.Rows.Count > 0)
            {
                //  Récupération des données
                string hashStocke = resultat.Rows[0]["mot_de_passe"].ToString();
                string selStocke = resultat.Rows[0]["sel"].ToString();
                this.Username = resultat.Rows[0]["nom_utilisateur"].ToString();
                this.UserId = Convert.ToInt32(resultat.Rows[0]["id_utilisateur"]);


                //  Vérification du mot de passe
                Motdepasse mdp = new Motdepasse(this.password, selStocke);
                bool estValide = mdp.verifierMDP(this.password, hashStocke, selStocke);

                return estValide;
            }

            //  Utilisateur non trouvé
            return false;
        }
        public bool register()
        {
            try
            {
                //Vérifier si l'utilisateur existe :
                string checkQuery = "SELECT COUNT(*) FROM Utilisateurs WHERE nom_utilisateur = @username";
                SqlParameter[] checkParam = new SqlParameter[]
                {
                    new SqlParameter("@username", username)
                };

                object result = db.ExecuteScalar(checkQuery, checkParam);
                int count = Convert.ToInt32(result);

                if (count > 0)
                {
                    // L'utilisateur existe déjà
                    MessageBox.Show("⚠️ Ce nom d'utilisateur est déjà pris.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }


                Motdepasse mdphash = new Motdepasse(password);
                string requete = "INSERT INTO utilisateurs (nom_utilisateur, mot_de_passe, sel) VALUES (@nom, @mdp, @sel)";
                
                SqlParameter[] param = new SqlParameter[]
               {
                    new SqlParameter("@nom", username),
                    new SqlParameter("@mdp", mdphash.getMdpHash),
                    new SqlParameter("@sel", mdphash.getSel)
               };


                bool rows = db.ExecuterCommande(requete, param);
                if (rows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }catch(Exception e) { return false; }
        }
    }
}
