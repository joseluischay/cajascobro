namespace cajascobro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            textBox1 = new TextBox();
            menuStrip1 = new MenuStrip();
            corteCajaToolStripMenuItem1 = new ToolStripMenuItem();
            confirmaciónToolStripMenuItem = new ToolStripMenuItem();
            toolStripTextBox1 = new ToolStripTextBox();
            confirmarToolStripMenuItem = new ToolStripMenuItem();
            toolStripTextBox2 = new ToolStripTextBox();
            pagosToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem1 = new ToolStripMenuItem();
            recargasToolStripMenuItem = new ToolStripMenuItem();
            companiaToolStripMenuItem = new ToolStripMenuItem();
            telcelToolStripMenuItem = new ToolStripTextBox();
            movistarToolStripMenuItem = new ToolStripMenuItem();
            aTToolStripMenuItem = new ToolStripMenuItem();
            unefonToolStripMenuItem = new ToolStripMenuItem();
            infonavitToolStripMenuItem = new ToolStripMenuItem();
            moneyGramToolStripMenuItem = new ToolStripMenuItem();
            otrosServiciosToolStripMenuItem = new ToolStripMenuItem();
            buscarClienteToolStripMenuItem = new ToolStripMenuItem();
            todosLosClientesToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem2 = new ToolStripMenuItem();
            button4 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 180);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 259);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.Location = new Point(448, 52);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Aceptar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            button2.KeyPress += button2_KeyPress;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(236, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 23);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { corteCajaToolStripMenuItem1, pagosToolStripMenuItem, salirToolStripMenuItem1, buscarClienteToolStripMenuItem, salirToolStripMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(926, 25);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // corteCajaToolStripMenuItem1
            // 
            corteCajaToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { confirmaciónToolStripMenuItem, confirmarToolStripMenuItem });
            corteCajaToolStripMenuItem1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            corteCajaToolStripMenuItem1.Name = "corteCajaToolStripMenuItem1";
            corteCajaToolStripMenuItem1.Size = new Size(98, 21);
            corteCajaToolStripMenuItem1.Text = "Corte de caja";
            corteCajaToolStripMenuItem1.Click += corteCajaToolStripMenuItem1_Click;
            // 
            // confirmaciónToolStripMenuItem
            // 
            confirmaciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBox1 });
            confirmaciónToolStripMenuItem.Name = "confirmaciónToolStripMenuItem";
            confirmaciónToolStripMenuItem.Size = new Size(263, 22);
            confirmaciónToolStripMenuItem.Text = "RETIRO PARCIAL";
            confirmaciónToolStripMenuItem.Click += confirmaciónToolStripMenuItem_Click;
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 23);
            toolStripTextBox1.Text = "Haz clic aqui";
            toolStripTextBox1.KeyPress += toolStripTextBox1_KeyPress;
            toolStripTextBox1.Click += toolStripTextBox1_Click_1;
            // 
            // confirmarToolStripMenuItem
            // 
            confirmarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBox2 });
            confirmarToolStripMenuItem.Name = "confirmarToolStripMenuItem";
            confirmarToolStripMenuItem.Size = new Size(263, 22);
            confirmarToolStripMenuItem.Text = "CONFIRMAR REGISTRO PARCIAL";
            confirmarToolStripMenuItem.Click += confirmarToolStripMenuItem_Click;
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.Size = new Size(100, 23);
            toolStripTextBox2.Text = "Haz clic aqui";
            toolStripTextBox2.KeyPress += toolStripTextBox2_KeyPress;
            toolStripTextBox2.Click += toolStripTextBox2_Click_1;
            // 
            // pagosToolStripMenuItem
            // 
            pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            pagosToolStripMenuItem.Size = new Size(12, 21);
            // 
            // salirToolStripMenuItem1
            // 
            salirToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { recargasToolStripMenuItem, infonavitToolStripMenuItem, moneyGramToolStripMenuItem, otrosServiciosToolStripMenuItem });
            salirToolStripMenuItem1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            salirToolStripMenuItem1.Size = new Size(71, 21);
            salirToolStripMenuItem1.Text = "Servicios";
            salirToolStripMenuItem1.Click += salirToolStripMenuItem1_Click;
            // 
            // recargasToolStripMenuItem
            // 
            recargasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { companiaToolStripMenuItem });
            recargasToolStripMenuItem.Name = "recargasToolStripMenuItem";
            recargasToolStripMenuItem.Size = new Size(163, 22);
            recargasToolStripMenuItem.Text = "RECARGAS";
            // 
            // companiaToolStripMenuItem
            // 
            companiaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { telcelToolStripMenuItem, movistarToolStripMenuItem, aTToolStripMenuItem, unefonToolStripMenuItem });
            companiaToolStripMenuItem.Name = "companiaToolStripMenuItem";
            companiaToolStripMenuItem.Size = new Size(135, 22);
            companiaToolStripMenuItem.Text = "Compañia";
            companiaToolStripMenuItem.Click += companiaToolStripMenuItem_Click;
            // 
            // telcelToolStripMenuItem
            // 
            telcelToolStripMenuItem.Name = "telcelToolStripMenuItem";
            telcelToolStripMenuItem.Size = new Size(180, 23);
            telcelToolStripMenuItem.Text = "Telcel";
            telcelToolStripMenuItem.Click += telcelToolStripMenuItem_Click;
            // 
            // movistarToolStripMenuItem
            // 
            movistarToolStripMenuItem.Name = "movistarToolStripMenuItem";
            movistarToolStripMenuItem.Size = new Size(240, 22);
            movistarToolStripMenuItem.Text = "Movistar";
            movistarToolStripMenuItem.Click += movistarToolStripMenuItem_Click;
            // 
            // aTToolStripMenuItem
            // 
            aTToolStripMenuItem.Name = "aTToolStripMenuItem";
            aTToolStripMenuItem.Size = new Size(240, 22);
            aTToolStripMenuItem.Text = "ATT";
            aTToolStripMenuItem.Click += aTToolStripMenuItem_Click;
            // 
            // unefonToolStripMenuItem
            // 
            unefonToolStripMenuItem.Name = "unefonToolStripMenuItem";
            unefonToolStripMenuItem.Size = new Size(240, 22);
            unefonToolStripMenuItem.Text = "Unefon";
            unefonToolStripMenuItem.Click += unefonToolStripMenuItem_Click;
            // 
            // infonavitToolStripMenuItem
            // 
            infonavitToolStripMenuItem.Name = "infonavitToolStripMenuItem";
            infonavitToolStripMenuItem.Size = new Size(163, 22);
            infonavitToolStripMenuItem.Text = "INFONAVIT";
            infonavitToolStripMenuItem.Click += infonavitToolStripMenuItem_Click;
            // 
            // moneyGramToolStripMenuItem
            // 
            moneyGramToolStripMenuItem.Name = "moneyGramToolStripMenuItem";
            moneyGramToolStripMenuItem.Size = new Size(163, 22);
            moneyGramToolStripMenuItem.Text = "MONEY GRAM";
            moneyGramToolStripMenuItem.Click += moneyGramToolStripMenuItem_Click;
            // 
            // otrosServiciosToolStripMenuItem
            // 
            otrosServiciosToolStripMenuItem.Name = "otrosServiciosToolStripMenuItem";
            otrosServiciosToolStripMenuItem.Size = new Size(163, 22);
            otrosServiciosToolStripMenuItem.Text = "SKY";
            otrosServiciosToolStripMenuItem.Click += otrosServiciosToolStripMenuItem_Click;
            // 
            // buscarClienteToolStripMenuItem
            // 
            buscarClienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { todosLosClientesToolStripMenuItem });
            buscarClienteToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            buscarClienteToolStripMenuItem.Size = new Size(65, 21);
            buscarClienteToolStripMenuItem.Text = "Clientes";
            buscarClienteToolStripMenuItem.Click += buscarClienteToolStripMenuItem_Click;
            // 
            // todosLosClientesToolStripMenuItem
            // 
            todosLosClientesToolStripMenuItem.Name = "todosLosClientesToolStripMenuItem";
            todosLosClientesToolStripMenuItem.Size = new Size(204, 22);
            todosLosClientesToolStripMenuItem.Text = "TODOS LOS CLIENTES";
            todosLosClientesToolStripMenuItem.Click += todosLosClientesToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem2
            // 
            salirToolStripMenuItem2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            salirToolStripMenuItem2.Name = "salirToolStripMenuItem2";
            salirToolStripMenuItem2.Size = new Size(45, 21);
            salirToolStripMenuItem2.Text = "Salir";
            salirToolStripMenuItem2.Click += salirToolStripMenuItem2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(694, 150);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 10;
            button4.Text = "Pagar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(421, 154);
            label2.Name = "label2";
            label2.Size = new Size(149, 15);
            label2.TabIndex = 11;
            label2.Text = "Ingrese la cantidad a pagar";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(576, 151);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(112, 23);
            textBox2.TabIndex = 12;
            textBox2.TextAlign = HorizontalAlignment.Right;
            textBox2.TextChanged += textBox2_TextChanged_1;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(576, 47);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 13;
            label3.Text = "Hora:";
            label3.Click += label3_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.Location = new Point(41, 34);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(170, 25);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.Text = "Número de cliente";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.KeyPress += radioButton1_KeyPress;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.Location = new Point(41, 65);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(170, 25);
            radioButton2.TabIndex = 15;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nombre de cliente";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            radioButton2.KeyPress += radioButton2_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(576, 67);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 16;
            label1.Text = "Fecha:";
            // 
            // button1
            // 
            button1.Location = new Point(804, 403);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 17;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 460);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "MENU CAJAS DE ABONO";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button2;
        private TextBox textBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem pagosToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem1;
        private ToolStripMenuItem recargasToolStripMenuItem;
        private ToolStripMenuItem companiaToolStripMenuItem;
        private ToolStripMenuItem movistarToolStripMenuItem;
        private ToolStripMenuItem infonavitToolStripMenuItem;
        private ToolStripMenuItem moneyGramToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem2;
        private ToolStripMenuItem buscarClienteToolStripMenuItem;
        private ToolStripMenuItem corteCajaToolStripMenuItem1;
        private ToolStripMenuItem todosLosClientesToolStripMenuItem;
        private Label label2;
        private TextBox textBox2;
        public Button button4;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem aTToolStripMenuItem;
        private ToolStripMenuItem unefonToolStripMenuItem;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ToolStripTextBox telcelToolStripMenuItem;
        private ToolStripMenuItem otrosServiciosToolStripMenuItem;
        private Label label1;
        private ToolStripMenuItem confirmaciónToolStripMenuItem;
        private ToolStripMenuItem confirmarToolStripMenuItem;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripTextBox toolStripTextBox2;
        private Button button1;
    }
}