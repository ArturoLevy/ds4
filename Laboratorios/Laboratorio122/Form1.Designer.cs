namespace Laboratorio122
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
            txtResultado = new TextBox();
            txtNota2 = new TextBox();
            txtNota1 = new TextBox();
            btnSalir = new Button();
            btnLimpiar = new Button();
            btnCalcular = new Button();
            lblNota = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNota3 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(276, 303);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(267, 27);
            txtResultado.TabIndex = 19;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(276, 159);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(267, 27);
            txtNota2.TabIndex = 18;
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(276, 121);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(267, 27);
            txtNota1.TabIndex = 17;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(445, 251);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(96, 33);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(288, 251);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(96, 33);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Reiniciar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(131, 251);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(96, 33);
            btnCalcular.TabIndex = 14;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Location = new Point(82, 306);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(132, 20);
            lblNota.TabIndex = 13;
            lblNota.Text = "Promedio de Nota";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 166);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 12;
            label3.Text = "Nota 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 124);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 11;
            label2.Text = "Nota 1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(276, 45);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 10;
            label1.Text = "Calculo de Notas";
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(276, 203);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(267, 27);
            txtNota3.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 206);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 20;
            label5.Text = "Nota 3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNota3);
            Controls.Add(label5);
            Controls.Add(txtResultado);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(lblNota);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private TextBox txtNota2;
        private TextBox txtNota1;
        private Button btnSalir;
        private Button btnLimpiar;
        private Button btnCalcular;
        private Label lblNota;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtNota3;
        private Label label5;
    }
}
