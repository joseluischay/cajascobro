using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cajascobro
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*aqui es para reconocer solo numeros*/
            if ((e.KeyChar >= 32 && e.KeyChar <= 10 || (e.KeyChar >= 58 && e.KeyChar <= 255)))
            {
                MessageBox.Show("solo se permite números a 10 dígitos ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;


            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBox10.Focus();
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*aqui es para reconocer solo numeros*/
            if ((e.KeyChar >= 32 && e.KeyChar <= 10 || (e.KeyChar >= 58 && e.KeyChar <= 255)))
            {
                MessageBox.Show("solo se permite números a 10 dígitos ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;


            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                button4.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*ingresar numero de servicio, y confirmar, se le pone condicion ya que si los numeros
             son diferentes mandara verificar de nuevo el numero*/
            String n1 = textBox9.Text;
            String n2 = textBox10.Text;

            if (n1 == n2)

            {

                MessageBox.Show(textBox10.Text, "CONFIRMACIÓN DE FOLIO DE PARCIAL ", MessageBoxButtons.OK, MessageBoxIcon.Question);
                MessageBox.Show("Confirmacion de folio finalizó!!", "TERMINADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            else
               if
                   (n1 != n2)
            {
                MessageBox.Show("Verifica de nuevo el número !!!!", "ERROR EN CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
