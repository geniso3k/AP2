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
    public partial class FormAjouterFab : Form
    {
        private InsertionDALL ins = new InsertionDALL();
        private Form1 ancien;
        public FormAjouterFab(Form1 ancien)
        {
            InitializeComponent();
            txt_refFab.Text = "FAB";
            this.ancien = ancien;
        }

        private void btn_AjouterFab_Click(object sender, EventArgs e)
        {
            if (ins.ajouterFab(txt_refFab.Text, txt_Ent.Text, txt_Marque.Text))
            {
                this.ancien.LoadStockData();
                MessageBox.Show("Action réalisé avec succès.");
                this.Close();

            }

        }
    }
}
