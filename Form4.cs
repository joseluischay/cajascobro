namespace cajascobro
{
    public partial class Form4 : Form
    {
        private readonly object telcelToolStripMenuItem;



        /*Se añade constructor, para que al seleccionar el servicio en menu principal(form1), nos mande directo al siguiente 
          menu en este caso a form4,y aparezca el nombre de servicio */
        public Form4(String text)
        {
            InitializeComponent();
            telcelToolStripMenuItem = text;


            label24.Text = text;
            label30.Text = text;
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            /* en KeyPress es para al dar Enter nos lleva al sig. TextBox
             la condición es que al seleccionar un monto para la recarga nos mande un cuadro de dialogo
             y confirmar el num. telefónico*/


            String n1 = textBox19.Text;
            String n2 = textBox20.Text;

            if (n1 == n2)

            {

                MessageBox.Show(textBox20.Text, "CONFIRMACIÓN DE NÚMERO TELEFONICO ", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
               if
                   (n1 != n2)
            {
                MessageBox.Show("Verifica de nuevo el número !!!!", "ERROR EN CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




            if (n1 == n2 && radioButton1.Checked)
            {


                MessageBox.Show("CONFIRMAR PAGO POR $20.00 ", label24.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            if (n1 == n2 && radioButton2.Checked)
            {
                MessageBox.Show("CONFIRMAR PAGO POR $50.00 ", label24.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }


            if (n1 == n2 && radioButton3.Checked)
            {
                MessageBox.Show("CONFIRMAR PAGO POR 100.00 ", label24.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }

            else
            if
                (n1 == n2 && radioButton4.Checked)
            {

                MessageBox.Show("CONFIRMAR PAGO POR $200.00 ", label24.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
        }

        private void label25_Click(object sender, EventArgs e)
        {
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
        }

        private void label24_Click(object sender, EventArgs e)
        {
        }

        private void label23_Click(object sender, EventArgs e)
        {
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*para limitar a 10 caracteres al ingresar en textbox para el numero de telefono, hay que ir a
              propiedades del textbox seleccionar "MaxLength" y desde ahi se indica*/

            /*aqui es para reconocer solo numeros*/
            if ((e.KeyChar >= 32 && e.KeyChar <= 10 || (e.KeyChar >= 58 && e.KeyChar <= 255)))
            {
                MessageBox.Show("solo se permite números a 10 dígitos ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;


            }


            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBox20.Focus();
        }

        private void textBox21_TextChanged_1(object sender, EventArgs e)
        {


        }

        private void textBox21_KeyPress(object sender, KeyPressEventArgs e)
        {



        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 32 && e.KeyChar <= 10 || (e.KeyChar >= 58 && e.KeyChar <= 255)))
            {
                MessageBox.Show("solo se permite números a 10 dígitos ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;


            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                button5.Focus();



        }

        private void button5_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBox1.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBox2.Focus();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBox3.Focus();
        }

        private void label23_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox20_Click(object sender, EventArgs e)
        {







        }

        private void textBox19_Click(object sender, EventArgs e)
        {



        }

        private void label24_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox21_Click(object sender, EventArgs e)
        {




        }

        private void textBox20_Enter(object sender, EventArgs e)
        {

        }

        private void textBox21_MouseDown(object sender, MouseEventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {


            //para sumar denominaciones que se agregan
            double num1, num2, num3, num4, num5, num6, num7;
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            num3 = Convert.ToDouble(textBox3.Text);
            num4 = Convert.ToDouble(textBox4.Text);
            num5 = Convert.ToDouble(textBox5.Text);
            num6 = Convert.ToDouble(textBox6.Text);
            num7 = Convert.ToDouble(textBox7.Text);

            /*El formato 0:f2, donde f significa que tendremos valor Double y el 2 que tendremos dos decimales*/
            textBox8.Text = String.Format("{0:F2}", num1 * 1000 + num2 * 500 + num3 * 200 + num4 * 100 + num5 * 50 + num6 * 20 + num7 * 1);




            double n1, n2;
            n1 = Convert.ToDouble(textBox8.Text);
            n2 = Convert.ToDouble(textBox17.Text);
            label19.Text = String.Format("{0:F2}", n1 - n2);

            /*Uso de if para condicionar  dependiendo del valor que tengamos del pago
            En caso que no este completo o que tengamos que devolver cambio*/
            if (n1 < n2)

            {
                //uso MessageBox para nos mande un cuadro de dialogo por cada condicion de pago
                MessageBox.Show("Falta por cubrir el pago", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (n1 > n2)

            {
                /*MessageBox.Show(label19.Text, "REGRESAR CAMBIO!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);*/
                MessageBox.Show(label19.Text, "REGRESAR CAMBIO!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            if (n1 == n2)

            {
                MessageBox.Show("Operacion termino satisfactoriamente!!", "TERMINADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }






        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBox1.Focus();
        }

        private void label25_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBox4.Focus();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBox5.Focus();
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBox6.Focus();
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBox7.Focus();
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                button2.Focus();
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                button3.Focus();
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*en apartado egreso de denominaciones se sumaran las denominaciones que se agregen */
            double num1, num2, num3, num4, num5, num6, num7;
            num1 = Convert.ToDouble(textBox9.Text);
            num2 = Convert.ToDouble(textBox10.Text);
            num3 = Convert.ToDouble(textBox11.Text);
            num4 = Convert.ToDouble(textBox12.Text);
            num5 = Convert.ToDouble(textBox13.Text);
            num6 = Convert.ToDouble(textBox14.Text);
            num7 = Convert.ToDouble(textBox16.Text);

            /*en textBox16 que es donde se suma total de de efectivo ingresado(del menu ingreso denominacion) 
            el formato 0:f2, donde f significa que tendremos valor double y el 2 que tendremos dos decimales*/
            textBox21.Text = String.Format("{0:F2}", num1 * 1000 + num2 * 500 + num3 * 200 + num4 * 100 + num5 * 50 + num6 * 20 + num7 * 1);


            /*declaramos nuevos valores en poder usar if en caso de que no se cumpla alguna condicion al realizar pago*/
            double n1, n2;
            n1 = Convert.ToDouble(textBox21.Text);
            n2 = Convert.ToDouble(label19.Text);


            /*Uso de if para condicionar  dependiendo del valor que tengamos del pago
            En caso que no este completo o que tengamos que devolver cambio
            uso MessageBox para nos mande un cuadro de dialogo por cada condicion de pago*/
            if (n1 < n2)

            {

                MessageBox.Show("Verifica tu cambio!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (n1 > n2)

            {
                MessageBox.Show(label19.Text, "FALTA CAMBIO ", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            if (n1 == n2)

            {
                MessageBox.Show("Operacion termino satisfactoriamente!!", "TERMINADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }

        private void Form4_Load_1(object sender, EventArgs e)
        {
            /*Asignar por defecto valor 0, en caso de no ingresar valor a alguno, tomara este valor*/
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox17.Text = "0.00";
            textBox15.Text = "0.00";
            textBox14.Text = "0";
            textBox13.Text = "0";
            textBox12.Text = "0";
            textBox11.Text = "0";
            textBox10.Text = "0";
            textBox9.Text = "0";
            textBox16.Text = "0";
            textBox8.Text = "0.00";
            textBox21.Text = "0.00";
        }

        private void label19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBox10.Focus();
        }

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBox9.Focus();
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBox11.Focus();
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBox12.Focus();
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBox13.Focus();
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBox14.Focus();
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBox16.Focus();
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox21_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}
