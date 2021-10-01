using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto01
{
    public partial class fmFormulario : Form
    {
        //definicion objeto
        fmAcercaDe ventanaAcercaDe; // si lo creas aqui o con el initiaize component es estatico
        public fmFormulario()
        {
            InitializeComponent();
           // ventanaAcercaDe = new fmAcercaDe();
           //ocupan memoria todo el tiempo
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAumenta_Click(object sender, EventArgs e)
        {
            float aumenta = laMover.Font.Size;
            aumenta++;
            if (aumenta < 100)
            {
                laTamanyo.Text = Convert.ToString(aumenta);
                btnAumenta.Text = "Suma: " + Convert.ToString(aumenta);
                btnDisminuye.Text = "Resta: " + Convert.ToString(aumenta);
                laMover.Font = new Font("", aumenta, FontStyle.Regular, GraphicsUnit.Point);
            }
        }

        private void btnDisminuye_Click(object sender, EventArgs e)
        {

            float disminuye = laMover.Font.Size;
            disminuye--;
            if (disminuye >= 1)
            {
                laTamanyo.Text = Convert.ToString(disminuye);
                btnAumenta.Text = "Suma: " + Convert.ToString(disminuye);
                btnDisminuye.Text = "Resta: " + Convert.ToString(disminuye);
                laMover.Font = new Font("", disminuye, FontStyle.Regular, GraphicsUnit.Point);
            }
        }

        private void btnArriba_Click(object sender, EventArgs e)
        {
            //laMover.Top--;
            if (laMover.Top <= -laMover.Height)
            {
                laMover.Top = Height - 44;
            }
            laMover.Top = laMover.Top - 2;
        }

        private void btnAbajo_Click(object sender, EventArgs e)
        {
            laMover.Top++;
            if (laMover.Top >= Height - 40)
            {
                laMover.Top = - 40;
            }
            laMover.Top = laMover.Top + 2;
        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            Button miBoton = (Button)sender;
            MessageBox.Show("Es el boton "+miBoton.Text);
           /* if (sender == btnUno)
            {
                MessageBox.Show("Es el uno");
            }
           */
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            if (laMover.Left < -40)
            {
                laMover.Left = Width;
            }
            laMover.Left = laMover.Left - 2;
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            if (laMover.Left > Width)
            {
                laMover.Left = laMover.Width;
            }
            laMover.Left = laMover.Left + 2;
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            ventanaAcercaDe = new fmAcercaDe(); // esta es la forma de hacerlo dinamico
            ventanaAcercaDe.ShowDialog();
            ventanaAcercaDe.Dispose(); // se usa en dinamico para destruir el objeto y que no ocupe memoria (revisar por si me he equivocado)
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnControlPan_Click(object sender, EventArgs e)
        {
            foreach  (Control miPanelControl in pnBotones.Controls)
            {
                miPanelControl.ForeColor = Color.Orange;
                MessageBox.Show(miPanelControl.Name);
            }
            MessageBox.Show("Total Botones: "+pnBotones.Controls.Count);
        }

        private void btnDelante_Click(object sender, EventArgs e)
        {
            laMover.BringToFront();
        }

        private void btnDetras_Click(object sender, EventArgs e)
        {
            laMover.SendToBack();
        }

        private void btnControlFor_Click(object sender, EventArgs e)
        {
            foreach ( Control c in Controls )
            {
                if (c is Button)
                {
                    c.ForeColor = Color.Yellow;
                }
                MessageBox.Show(c.Name);
            }
            MessageBox.Show("Total de controles en el Formulario: "+Controls.Count);
        }

       private void btnNoVisible_Click(object sender, EventArgs e)
        {
            if (btnNoVisible.Text == "Visible")
            {
                btnNoVisible.Text = "No Visible";
            }else
            {
                btnNoVisible.Text = "Visible";
            }
            pnBotones.Visible = !pnBotones.Visible;
        }
    }
        /*
* SECUENCIA DE CREACION DE EVENTOS AL INICIO DE LA APLICACION

* Control.HandleCreated
* Control.BindingContextChanged
* Form.Load
* Control.VisibleChanged
* Form.Activated
* Form.Shown
* 
* CERRADO
* 
* Form.Closing
* Form.FormClosing
* Form.Closed
* Form.FormClosed
* Form.Deactivate
* 
*/

    /*
     * Pasos para crear un proyecto multiformulario
     * -Incluir un nuevo form (menu/proyecto/agregar windows form) y diseñarlo
     * -Definir el nuevo objeto ventana a nivel global para poder ser usado en diferentes funciones
     * Construyo el objeto:
     *  -si es estatico en la funcion principal en initializecomponent o en la definicion
     *  -si es dinamico creo el objeto en el mismo evento que invoca al nuevo formulario
     *  
     *  Muestro el nuevo formulario con el metodo showdialog si es modal o show si es flotante
     *  Si es dinamico destruyo el objeto nueva ventana en el mismo evento donde se invoca
     *  Si es estatico no se destruye hasta el fin de la aplicacion
     */
    }
