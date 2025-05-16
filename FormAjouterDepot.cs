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
    public partial class FormAjouterDepot : Form
    {
        private InsertionDALL ins = new InsertionDALL();
        private Form1 ancien;
        public FormAjouterDepot(Form1 ancien)
        {
            InitializeComponent();
            txt_refD.Text = "DEP";
            this.ancien = ancien;
        }

        private void btn_AjouterDep_Click(object sender, EventArgs e)
        {
            if (ins.ajouterDep(txt_refD.Text, txt_nom.Text, txt_ville.Text, txt_pays.Text, txt_la.Text, txt_lo.Text))
            {
                this.ancien.LoadStockData();
                MessageBox.Show("Action réalisé avec succès.");
                this.Close();

            }
            else
            {
                MessageBox.Show("Erreur");
            }

        }


    }
}
