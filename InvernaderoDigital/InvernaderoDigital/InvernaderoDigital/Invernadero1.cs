using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace InvernaderoDigital
{
    public partial class Invernadero1 : Form
    {
        Stopwatch oSW = new Stopwatch();
        public Invernadero1()
        {
            InitializeComponent();
        }

        private void Invernadero1_Load(object sender, EventArgs e)
        {
             

            //Ventilacion
            cbVentilacion1.Items.Add("Activar");
            cbVentilacion1.Items.Add("Desactivar");

            //Riego 
            cbConfigRiego1.Items.Add("Activar");
            cbConfigRiego1.Items.Add("Desactivar");

            cbVelGoteo1.Items.Add("Baja");
            cbVelGoteo1.Items.Add("Media");
            cbVelGoteo1.Items.Add("Alta");

            

            //Fertilizador 

            cbFertilizador1.Items.Add("Activar");
            cbFertilizador1.Items.Add("Desactivar");

            //fumigador 

            cbFumigador1.Items.Add("Activar");
            cbFumigador1.Items.Add("Desactivar");

            //temperatura

            for (int i = 10; i < 31; i++)
            {
                cbTemperatura1.Items.Add(i + "°");
            }
        }

        public void tmRiego1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)oSW.ElapsedMilliseconds);
            txtMin.Text = ts.Minutes.ToString().Length < 2 ? "0" + ts.Minutes.ToString() : ts.Minutes.ToString();
            txtSeg.Text = ts.Seconds.ToString().Length < 2 ? "0" + ts.Seconds.ToString() : ts.Seconds.ToString();
            txtMil.Text = ts.Milliseconds.ToString();

            

        }

        public void BtGuardarConfig1_Click(object sender, EventArgs e)
        {
            string ventilacion = Convert.ToString(cbVentilacion1.SelectedItem);
            string riego = Convert.ToString(cbConfigRiego1.SelectedItem);
            string velocidad = Convert.ToString(cbVelGoteo1.SelectedItem);
            string fumigador = Convert.ToString(cbFumigador1.SelectedItem);
            string fertilizador = Convert.ToString(cbFertilizador1.SelectedItem);
            string temperatura = Convert.ToString(cbTemperatura1.SelectedItem);

            if (ventilacion == "Activar")
            {
                lblInfoVentilacion1.Text = "Ventilacion:Activada";
            }
            else
            {
                lblInfoVentilacion1.Text = "Ventilacion:Desactivada";
            }

            if (fumigador == "Activar")
            {
                lblInfoFumigador1.Text = "Fumigador: Activado";
            }
            else
            {
                lblInfoFumigador1.Text = "Fumigador:Desactivado";
            }

            if (fertilizador == "Activar")
            {
                lblInfoFertilizador1.Text = "Fertilizador: Activado";
            }
            else
            {
                lblInfoFertilizador1.Text = "Fertilizador:Desactivado";
            }

            if (temperatura == "")
            {
                MessageBox.Show("No ha ingresado la temperatura de su invernadero, por favor seleccione una");
            }
            else
            {
                lblInfoTemperatura1.Text = "Temperatura: " + temperatura;
            }
           
            if (riego == "Activar")
            {
                lblInfoRiego1.Text = "Riego:Activado";
                switch (velocidad)
                {
                    case "Baja":
                        lblInfoVelR1.Text = "Velocidad:Baja";
                        break;
                    case "Media":
                        lblInfoVelR1.Text = "Velocidad:Media";
                        break;
                    case "Alta":
                        lblInfoVelR1.Text = "Velocidad:Alta";
                        break;

                }

                oSW.Start();
                tmRiego1.Enabled = true;
                

            }
        }

        private void btVolver1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            FrmInicio volver = new FrmInicio();
            tmRiego1.Enabled = false;
            MessageBox.Show("La configuracion se perdera si sale de esta ventana.");
            volver.Show();
        }

        private void btDetenerP_Click(object sender, EventArgs e)
        {
           
            lblInfoVentilacion1.Text = "Ventilacion:Desactivada";
            lblInfoRiego1.Text = "Riego:Desactivado";
            lblInfoVelR1.Text = "Velocidad:-";
            lblInfoFumigador1.Text = "Fumigador:Desactivado";
            lblInfoFertilizador1.Text = "Fertilizador:Desactivado";
            oSW.Stop();
            MessageBox.Show("La temperatura de su invernadero, se mantendra encendida aunque hayan finalizado los demas procesos");
        }

       
    }
}
