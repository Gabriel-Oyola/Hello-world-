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
    public partial class FrmSiembra : Form
    {
        public FrmSiembra()
        {
            InitializeComponent();
        }

        private void FrmSiembra_Load(object sender, EventArgs e)
        {
            //Agregar Items Verdura
            cbVerdura.Items.Add("Tomate");
            cbVerdura.Items.Add("Lechuga");
            cbVerdura.Items.Add("Pimiento");
            cbVerdura.Items.Add("Zanahoria");
            cbVerdura.Items.Add("Zapallito");
            //Agregar Filas
            cbFilaSembrar.Items.Add("Fila 1");
            cbFilaSembrar.Items.Add("Fila 2");
            cbFilaSembrar.Items.Add("Fila 3");

        }

        private void btSembrar_Click(object sender, EventArgs e)
        {
            string filaS = Convert.ToString(cbFilaSembrar.SelectedItem);
            
            string OpcionVerdura = Convert.ToString(cbVerdura.SelectedItem);


            if (listFila1.Items.Count < 10)
            {
                for (int i = 0; i <= 10; i++)
                {
                    if(filaS=="Fila 1")
                    {
                        listFila1.Items.Add(OpcionVerdura);
                    }
                   
                }
                
            }
            if (listfila2.Items.Count < 10)
            {
                for (int i = 0; i <= 10; i++)
                {
                    if (filaS == "Fila 2")
                    {
                        listfila2.Items.Add(OpcionVerdura);
                    }

                }
                
            }
            if (listFIla3.Items.Count < 10)
            {
                for (int i = 0; i <= 10; i++)
                {
                    if (filaS == "Fila 3")
                    {
                        listFIla3.Items.Add(OpcionVerdura);
                    }

                }
                 
            }
            else
            {
                MessageBox.Show("Limite siembra alcanzado en esta fila.");

            }

        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInicio volver = new FrmInicio();
            volver.Show();
        }
    }
}
