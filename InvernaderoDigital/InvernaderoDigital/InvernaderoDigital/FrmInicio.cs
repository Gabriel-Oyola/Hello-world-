using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvernaderoDigital
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void btConfigInv1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Invernadero1 Inv1 = new Invernadero1();
            Inv1.Show();

        }

        private void btSyC_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmSiembra SyC = new FrmSiembra();
            SyC.Show();
        }
    }
}
