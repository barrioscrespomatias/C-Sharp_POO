using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioClase06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.textBox1.Text = "Hola mundo";
            int cantidad = 5;
            int[] vec = new int[cantidad];
            vec[0] = 1;

            //for (int i=0; i<vec.Length; i++)
            //{
                
            //    MessageBox.Show(vec[i].ToString());
              
            //}

            foreach(int item in vec)
            {
                MessageBox.Show(item.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = this.textBox1.Text;
            this.BackColor = Color.Blue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
