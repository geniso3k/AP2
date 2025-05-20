using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AP2
{
    internal class ConnexionDB
    {
        // Chaîne de connexion à la base de données
        private readonly string connectionString;

        // Constructeur pour initialiser la chaîne de connexion
        public ConnexionDB()
        {
            //connectionString = "Server=SRV-SQL\\SQL_SLAM;Database=BD_STOCK_BYTYQI;Trusted_Connection=True;";
            connectionString = "Server=localhost\\SQLEXPRESS;Database=BD_STOCK_BYTYQI;Trusted_Connection=True";
        }

        // Méthode pour obtenir une connexion SQL
        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Méthode pour exécuter une requête SELECT et retourner un DataTable

        public DataTable ExecuteSelect(string query, SqlParameter[] parametres = null)
        {
            DataTable resultat = new DataTable();

            using (SqlConnection connexion = this.GetConnection())
            {

                using (SqlCommand commande = new SqlCommand(query, connexion))
                {
                    try
                    {
                        // Ajout des paramètres de façon sécurisée
                        if (parametres != null)
                        {
                            
                              commande.Parameters.AddRange(parametres);
                            
                        }
                        
                        connexion.Open();

                        using (SqlDataReader lecteur = commande.ExecuteReader())
                        {
                            resultat.Load(lecteur);
                        }

                    }
                    catch (Exception ex) {
                        MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }

            }
            return resultat;

        }






        // Méthode pour exécuter une requête INSERT, UPDATE, DELETE
        public bool ExecuterCommande(string query, SqlParameter[] parametre = null)
        {
            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Ajouter les paramètres s'il y en a
                    if (parametre != null)
                    {
                        command.Parameters.AddRange(parametre);
                    }

                    // Ouvrir la connexion et exécuter la requête
                    try
                    {
                        
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 547)
                        {
                            MessageBox.Show("Impossible, l'article est encore utilisé dans une autre table. (probablement dans les mouvements de stock)");

                        }
                        else
                        {
                            MessageBox.Show("Erreur lors de l'exécution de la requête : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                            return false;
                    }
                }
            }
        }

        // Méthode pour exécuter une requête scalar (retourne une seule valeur)
        public object ExecuteScalar(string query, SqlParameter[] parametre = null)
        {
            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Ajouter les paramètres s'il y en a
                    if (parametre != null)
                    {
                        command.Parameters.AddRange(parametre);
                    }

                    // Ouvrir la connexion et exécuter la requête
                    try
                    {
                        connection.Open();
                        return command.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erreur lors de l'exécution de la requête scalar : " + ex.Message);
                        return null;
                    }
                }
            }
        }
    }
}
