using System.Data;
using System.Data.SqlClient;

namespace cajascobro
{
    public partial class Form1 : Form
    {
        /* conectarse con base de datos sqlserver */
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LRFS2O5;Initial Catalog=CajasAbono;Integrated Security=True");


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarData();
        }

        private void cargarData()
        /*aqui se pone a que tabla de base de datos se tomara la informacion para verse en el datagridview*/
        {
            SqlDataAdapter da = new SqlDataAdapter("select*from Clientes", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridView1.DataSource = dt;
        }

        private void salirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        /*aqui es para poder buscar por numero de cliente*/
        {
            conn.Open();


            if (radioButton1.Checked)
            {
                string consulta = "select*from Clientes where IdCliente= " + textBox1.Text + "";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conn);
                DataTable dat = new DataTable();
                adaptador.Fill(dat);
                this.dataGridView1.DataSource = dat;
                SqlCommand comando = new SqlCommand(consulta, conn);
                SqlDataReader lector;
                lector = comando.ExecuteReader();
            }
            else
            if (radioButton2.Checked)
            {
                string consulta = "select*from Clientes where Nombre=  '" + textBox1.Text + "'";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conn);
                DataTable dat = new DataTable();
                adaptador.Fill(dat);
                this.dataGridView1.DataSource = dat;
                SqlCommand comando = new SqlCommand(consulta, conn);
                SqlDataReader lector;
                lector = comando.ExecuteReader();



            }



            conn.Close();
            MessageBox.Show("Se encontro cliente", "listo");

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            //servira para al poner una cantidad a pagar en textbox para pagar, y dar enter en pagar nos mande en form2
            //y aparezca la cantidad que ingresamos.

            string texto = textBox2.Text;
            Form2 m = new Form2(texto);
            m.Show();

        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void corteCajaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        //para que al dar enter al escribir cantidad a pagar nos mande directo al boton pagar//
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                button4.Focus();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        //su funcion es que al ingresar un numero de cliente y dar enter nos mande al boton aceptar
        //para buscar por numero de cliente en base de datos
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                button2.Focus();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            textBox2.Text = "0.00";

        }

        private void companiaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        //servira para ver la hora al momento de ejecutar el formulario(ya que en diseño aparece como hora y fecha)
        {
            label3.Text = DateTime.Now.ToString("HH:MM:ss");
            label1.Text = DateTime.Now.ToString("dd/ MMMM /yyyy");
        }

        private void infonavitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string texto = infonavitToolStripMenuItem.Text;
            Form5 t = new Form5(texto);
            t.Show();
        }

        private void numeroDeCreditoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void todosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cargarData();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            cargarData();
        }

        private void porNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            cargarData();

        }

        private void telcelToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string texto = telcelToolStripMenuItem.Text;
            Form4 t = new Form4(texto);
            t.Show();
        }

        private void movistarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string texto = movistarToolStripMenuItem.Text;
            Form4 t = new Form4(texto);
            t.Show();
        }

        private void aTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string texto = aTToolStripMenuItem.Text;
            Form4 t = new Form4(texto);
            t.Show();
        }

        private void unefonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string texto = unefonToolStripMenuItem.Text;
            Form4 t = new Form4(texto);
            t.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void otrosServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string texto = otrosServiciosToolStripMenuItem.Text;
            Form5 t = new Form5(texto);
            t.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBox1.Focus();
        }

        private void radioButton2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                textBox1.Focus();
        }

        private void moneyGramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string texto = moneyGramToolStripMenuItem.Text;
            Form5 t = new Form5(texto);
            t.Show();
        }

        private void toolStripTextBox2_DoubleClick(object sender, EventArgs e)
        {

        }

        private void confirmaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {



        }

        private void confirmarToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void toolStripTextBox1_Click_1(object sender, EventArgs e)
        {
            Form formulario = new Form3();
            formulario.Show();
        }

        private void toolStripTextBox2_Click_1(object sender, EventArgs e)
        {
            Form formulario = new Form6();
            formulario.Show();
        }

        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void toolStripTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}