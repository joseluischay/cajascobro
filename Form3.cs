namespace cajascobro
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        /*sumar las denominaciones para hacer corte de caja*/
        {
            double num1, num2, num3, num4, num5, num6, num7;
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            num3 = Convert.ToDouble(textBox3.Text);
            num4 = Convert.ToDouble(textBox4.Text);
            num5 = Convert.ToDouble(textBox5.Text);
            num6 = Convert.ToDouble(textBox6.Text);
            num7 = Convert.ToDouble(textBox7.Text);

            textBox8.Text = String.Format("{0:F2}", num1 * 1000 + num2 * 500 + num3 * 200 + num4 * 100 + num5 * 50 + num6 * 20 + num7 * 1);

         
            MessageBox.Show(textBox8.Text, ("Retiro parcial realizado"));
            MessageBox.Show("Operacion termino satisfactoriamente!!", "TERMINADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    this.Close();
        }


        //keypress servira para formulario 3 para parcial
        //al escribir cantidad y dar enter nos mandara a al siguiente text box
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBox2.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBox3.Focus();

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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0.00";

        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
        
        }
    }
}

