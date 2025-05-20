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
    public partial class FormAjouterInv : Form
    {
        private Form1 ancien;
        public FormAjouterInv(Form1 ancien)
        {
            InitializeComponent();

            this.ancien = ancien;  
        }
    }
}
