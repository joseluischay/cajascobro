namespace cajascobro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(String text)
        {
            //se añade constructor, para ver lo que escribe en textbox de form1 al label pagar de form2
            InitializeComponent();

            textBox17.Text = text;

        }


        private void button2_Click(object sender, EventArgs e)

        {
            /*para sumar denominaciones que se agregan en cada textbox*/
            double num1, num2, num3, num4, num5, num6, num7;
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            num3 = Convert.ToDouble(textBox3.Text);
            num4 = Convert.ToDouble(textBox4.Text);
            num5 = Convert.ToDouble(textBox5.Text);
            num6 = Convert.ToDouble(textBox6.Text);
            num7 = Convert.ToDouble(textBox7.Text);

            /* en textBox15 que es donde se suma total de de efectivo ingresado(del menu ingreso denominacion) 
            el formato 0:f2, donde f significa que tendremos valor double y el 2 que tendremos dos decimales*/
            textBox15.Text = String.Format("{0:F2}", num1 * 1000 + num2 * 500 + num3 * 200 + num4 * 100 + num5 * 50 + num6 * 20 + num7 * 1);

            /*declaramos nuevos valores para poder usar if en caso de que no se cumpla alguna condición al realizar pago*/
            double n1, n2;
            n1 = Convert.ToDouble(textBox15.Text);
            n2 = Convert.ToDouble(textBox17.Text);
            label19.Text = String.Format("{0:F2}", n1 - n2);

            /*Uso de if para condicionar  dependiendo del valor que tengamos del pago
            //En caso que no este completo o que tengamos que devolver cambio*/
            if (n1 < n2)

            {
                /*uso MessageBox para nos mande un cuadro de dialogo por cada condición de pago*/
                MessageBox.Show("Falta por cubrir pago ", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (n1 > n2)

            {
                MessageBox.Show(label19.Text, ("Regresar cambio"));
            }
            if (n1 == n2)

            {
            
                MessageBox.Show("Operacion termino satisfactoriamente!!", "TERMINADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }

        }


        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        /*En propiedades se habilito en propiedades con True "readOnly"
         para los valores no se puedan modificar.*/
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        /*Con keypress de prop. servira para que al dar escribir cantidad a pagar nos mande al siguiente textbox*/
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBox4.Focus();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

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

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                button2.Focus();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBox5.Focus();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*para dar valores iniciales en textBox en 0, para si en caso que no se necesite
             agregar valor, ya tiene uno predeterminado */
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox15.Text = "0.00";
            textBox14.Text = "0";
            textBox13.Text = "0";
            textBox12.Text = "0";
            textBox11.Text = "0";
            textBox10.Text = "0";
            textBox9.Text = "0";
            textBox8.Text = "0";
            textBox16.Text = "0.00";
        
   



        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void label19_Click(object sender, EventArgs e)
        {



        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBox18.Focus();
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox15_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox15_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBox13.Focus();
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBox12.Focus();
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBox11.Focus();
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBox10.Focus();
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBox9.Focus();
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBox8.Focus();
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                button3.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }



        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            string texto = textBox18.Text;
            /*En el egreso de denominaciones se sumaran las denominaciones que se agregen*/
            double num1, num2, num3, num4, num5, num6, num7;
            num1 = Convert.ToDouble(textBox14.Text);
            num2 = Convert.ToDouble(textBox13.Text);
            num3 = Convert.ToDouble(textBox12.Text);
            num4 = Convert.ToDouble(textBox11.Text);
            num5 = Convert.ToDouble(textBox10.Text);
            num6 = Convert.ToDouble(textBox9.Text);
            num7 = Convert.ToDouble(textBox8.Text);

            /*En textBox16 que es donde se suma total de de efectivo ingresado(del menu ingreso denominacion) 
             el formato 0:f2, donde f significa que tendremos valor double y el 2 que tendremos dos decimales*/
            textBox16.Text = String.Format("{0:F2}", num1 * 1000 + num2 * 500 + num3 * 200 + num4 * 100 + num5 * 50 + num6 * 20 + num7 * 1);

            //declaramos nuevos valores en poder usar if en caso de que no se cumpla alguna condicion al realizar pago
            double n1, n2;
            n1 = Convert.ToDouble(textBox18.Text);
            n2 = Convert.ToDouble(textBox16.Text);
            label19.Text = String.Format("{0:F2}", n1 - n2);

            /*Uso de if para condicionar  dependiendo del valor que tengamos del pago
             En caso que no este completo o que tengamos que devolver cambio*/
            if (n1 < n2)

            {
                //uso MessageBox para nos mande un cuadro de dialogo por cada condicion de pago
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

        private void button3_KeyPress_1(object sender, KeyPressEventArgs e)
        /* uso de keypress, para saltar al sig. textbox o boton al dar enter*/
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBox8.Focus();
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBox14.Focus();
        }

        private void textBox18_Click(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
