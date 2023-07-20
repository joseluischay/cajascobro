namespace cajascobro
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button4 = new Button();
            button3 = new Button();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            label10 = new Label();
            progressBar2 = new ProgressBar();
            label1 = new Label();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(386, 269);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 158;
            button4.Text = "Aceptar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(282, 269);
            button3.Name = "button3";
            button3.Size = new Size(78, 23);
            button3.TabIndex = 157;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(282, 221);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(179, 23);
            textBox10.TabIndex = 156;
            textBox10.KeyPress += textBox10_KeyPress;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(282, 187);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(179, 23);
            textBox9.TabIndex = 155;
            textBox9.KeyPress += textBox9_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(282, 152);
            label10.Name = "label10";
            label10.Size = new Size(126, 15);
            label10.TabIndex = 154;
            label10.Text = "Confirmación de corte";
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(255, 124);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(228, 223);
            progressBar2.TabIndex = 159;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(282, 75);
            label1.Name = "label1";
            label1.Size = new Size(167, 30);
            label1.TabIndex = 160;
            label1.Text = "Cortes parciales";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(label10);
            Controls.Add(progressBar2);
            Name = "Form6";
            Text = "CONFIRMACIÓN DE CORTES";
            Load += Form6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private TextBox textBox10;
        private TextBox textBox9;
        private Label label10;
        private ProgressBar progressBar2;
        private Label label1;
    }
}