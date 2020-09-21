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

            if(btnLockCotizacion.DialogResult == DialogResult.OK && flag==0)
            {
                this.txtCotizacionEuro.Enabled = false;
                this.txtCotizacionDolar.Enabled = false;
                this.txtCotizacionPeso.Enabled = false;
                this.btnLockCotizacion.DialogResult = DialogResult.Cancel;
                flag = 1;
            }
            else
            {
                this.txtCotizacionEuro.Enabled = false;
                this.txtCotizacionDolar.Enabled = false;
                this.txtCotizacionPeso.Enabled = false;
                this.btnLockCotizacion.DialogResult = DialogResult.OK;

            }



        }
    }
}
