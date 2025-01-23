using System;
using System.Windows.Forms;

namespace AP2
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Affiche la boîte de dialogue de connexion avant de lancer Form1
            if (ShowLoginDialog())
            {
                Application.Run(new Form1());
            }
            else
            {
                MessageBox.Show("Authentification échouée. L'application va se fermer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static bool ShowLoginDialog()
        {
            Form loginForm = new Form()
            {
                Width = 300,
                Height = 180,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Connexion",
                StartPosition = FormStartPosition.CenterScreen
            };

            Label lblUser = new Label() { Left = 10, Top = 20, Text = "Nom d'utilisateur:" };
            TextBox txtUser = new TextBox() { Left = 120, Top = 20, Width = 150 };
            Label lblPass = new Label() { Left = 10, Top = 60, Text = "Mot de passe:" };
            TextBox txtPass = new TextBox() { Left = 120, Top = 60, Width = 150, UseSystemPasswordChar = true };
            Button btnOk = new Button() { Text = "Se connecter", Left = 120, Width = 150, Top = 100, DialogResult = DialogResult.OK };

            btnOk.Click += (sender, e) => { loginForm.Close(); };

            loginForm.Controls.Add(lblUser);
            loginForm.Controls.Add(txtUser);
            loginForm.Controls.Add(lblPass);
            loginForm.Controls.Add(txtPass);
            loginForm.Controls.Add(btnOk);
            loginForm.AcceptButton = btnOk;


            /* Créer un utilisateur
            Authentifications newUser = new Authentifications("genis", "password");
            newUser.register(); */

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Authentifications auth = new Authentifications(txtUser.Text, txtPass.Text);
                return auth.login();
            }

            return false;
        }
    }
}
