using System;
using System.Data;
using System.Data.SqlClient;

namespace AP2
{
    internal class ConnexionDB
    {
        // Chaîne de connexion à la base de données
        private readonly string connectionString;

        // Constructeur pour initialiser la chaîne de connexion
        public ConnexionDB()
        {
            // Remplace par ta chaîne de connexion
            connectionString = "Server=SRV-SQL\\SQL_SLAM;Database=BD_STOCK_BYTYQI;Trusted_Connection=True;";
        }

        // Méthode pour obtenir une connexion SQL
        private SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Méthode pour exécuter une requête SELECT et retourner un DataTable
        public DataTable ExecuteSelectQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Ajouter les paramètres s'il y en a
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    // Ouvrir la connexion et exécuter la requête
                    try
                    {
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erreur lors de l'exécution de la requête SELECT : " + ex.Message);
                    }
                }
            }

            return dataTable;
        }

        // Méthode pour exécuter une requête INSERT, UPDATE, DELETE
        public bool ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Ajouter les paramètres s'il y en a
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    // Ouvrir la connexion et exécuter la requête
                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erreur lors de l'exécution de la requête : " + ex.Message);
                        return false;
                    }
                }
            }
        }

        // Méthode pour exécuter une requête scalar (retourne une seule valeur)
        public object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Ajouter les paramètres s'il y en a
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
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
