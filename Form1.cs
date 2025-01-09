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
    public partial class Form1 : Form
    {

        private ConnexionDB db; // Instance de la classe ConnexionDB
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            db = new ConnexionDB(); // Initialisation de l'objet ConnexionDB

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Test de connexion
            MessageBox.Show("Connexion initialisée avec succès !");
        }
    }
}
