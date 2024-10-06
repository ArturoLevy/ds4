namespace Laboratorio121
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            txtVelocidad = new TextBox();
            txtTiempo = new TextBox();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(284, 50);
            label1.Name = "label1";
            label1.Size = new Size(231, 20);
            label1.TabIndex = 0;
            label1.Text = "Calculo de Velocidad de un Movil";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 129);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 1;
            label2.Text = "Velocidad km/h";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 171);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 2;
            label3.Text = "Tiempo (horas)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 271);
            label4.Name = "label4";
            label4.Size = new Size(165, 20);
            label4.TabIndex = 3;
            label4.Text = "Distania Recorrida (km)";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(141, 212);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(96, 33);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(298, 212);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(96, 33);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Reiniciar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(455, 212);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(96, 33);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtVelocidad
            // 
            txtVelocidad.Location = new Point(284, 126);
            txtVelocidad.Name = "txtVelocidad";
            txtVelocidad.Size = new Size(267, 27);
            txtVelocidad.TabIndex = 7;
            // 
            // txtTiempo
            // 
            txtTiempo.Location = new Point(284, 164);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(267, 27);
            txtTiempo.TabIndex = 8;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(284, 268);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(267, 27);
            txtResultado.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResultado);
            Controls.Add(txtTiempo);
            Controls.Add(txtVelocidad);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private TextBox txtVelocidad;
        private TextBox txtTiempo;
        private TextBox txtResultado;
    }
}
