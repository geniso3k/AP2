using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AP2.DALL;

namespace AP2
{
    public partial class FormAjouterUni : Form
    {
        private Form1 ancien;
        private InsertionDALL id = new InsertionDALL();

        public FormAjouterUni(Form1 ancien)
        {
            InitializeComponent();
            this.ancien = ancien;
            txt_codeCat.Text = "UNI";
            
        }

        private void btnAjt_Click(object sender, EventArgs e)
        {

            if (id.ajouterCatouUni(txt_codeCat.Text, txt_libelle.Text, "UNI"))
            {
                MessageBox.Show("Insertion effectué avec succès.");
                this.ancien.LoadStockData();
                this.Close();
            }

        }
    }
}
