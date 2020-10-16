using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio21_B
{
    public partial class Conversor : Form
    {
        public Conversor()
        {
            InitializeComponent();

            this.CenterToScreen();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnLockCotizacion_Click(object sender, EventArgs e)
        {
            int flag=0;
            this.btnLockCotizacion.DialogResult = DialogResult.OK;
            



        }

        private void Conversor_FormClosing(object sender, FormClosingEventArgs e)
        {           

            DialogResult rta = MessageBox.Show("Esta seguro de querer salir?", "Atencion!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (rta == DialogResult.Yes)
                e.Cancel = false;

            else
            {
                e.Cancel = true;
                MessageBox.Show("Continua en la aplicacion");

            }
        }

        private void Conversor_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Gracias por haber utilizado la aplicacion");
        }
    }
}
