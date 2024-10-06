namespace Laboratorio_123
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
            label5 = new Label();
            btnSemiperimetro = new Button();
            btnArea = new Button();
            btnReset = new Button();
            btnSalir = new Button();
            txtLadoA = new TextBox();
            txtLadoB = new TextBox();
            txtLadoC = new TextBox();
            txtSemiperimetro = new TextBox();
            txtArea = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 65);
            label1.Name = "label1";
            label1.Size = new Size(192, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingresa Longitud de Lado A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 108);
            label2.Name = "label2";
            label2.Size = new Size(191, 20);
            label2.TabIndex = 1;
            label2.Text = "Ingresa Longitud de Lado B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 151);
            label3.Name = "label3";
            label3.Size = new Size(191, 20);
            label3.TabIndex = 2;
            label3.Text = "Ingresa Longitud de Lado C";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 263);
            label4.Name = "label4";
            label4.Size = new Size(165, 20);
            label4.TabIndex = 3;
            label4.Text = "Calcular Semiperimetro";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 303);
            label5.Name = "label5";
            label5.Size = new Size(131, 20);
            label5.TabIndex = 4;
            label5.Text = "Area del Triangulo";
            // 
            // btnSemiperimetro
            // 
            btnSemiperimetro.Location = new Point(71, 200);
            btnSemiperimetro.Name = "btnSemiperimetro";
            btnSemiperimetro.Size = new Size(131, 29);
            btnSemiperimetro.TabIndex = 6;
            btnSemiperimetro.Text = "Semiperimetro";
            btnSemiperimetro.UseVisualStyleBackColor = true;
            btnSemiperimetro.Click += btnSemiperimetro_Click;
            // 
            // btnArea
            // 
            btnArea.Location = new Point(228, 200);
            btnArea.Name = "btnArea";
            btnArea.Size = new Size(94, 29);
            btnArea.TabIndex = 7;
            btnArea.Text = "Area";
            btnArea.UseVisualStyleBackColor = true;
            btnArea.Click += btnArea_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(346, 200);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(484, 200);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salida";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtLadoA
            // 
            txtLadoA.Location = new Point(284, 62);
            txtLadoA.Name = "txtLadoA";
            txtLadoA.Size = new Size(125, 27);
            txtLadoA.TabIndex = 10;
            // 
            // txtLadoB
            // 
            txtLadoB.Location = new Point(284, 105);
            txtLadoB.Name = "txtLadoB";
            txtLadoB.Size = new Size(125, 27);
            txtLadoB.TabIndex = 11;
            // 
            // txtLadoC
            // 
            txtLadoC.Location = new Point(284, 148);
            txtLadoC.Name = "txtLadoC";
            txtLadoC.Size = new Size(125, 27);
            txtLadoC.TabIndex = 12;
            // 
            // txtSemiperimetro
            // 
            txtSemiperimetro.Location = new Point(284, 260);
            txtSemiperimetro.Name = "txtSemiperimetro";
            txtSemiperimetro.Size = new Size(125, 27);
            txtSemiperimetro.TabIndex = 13;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(284, 300);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(125, 27);
            txtArea.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtArea);
            Controls.Add(txtSemiperimetro);
            Controls.Add(txtLadoC);
            Controls.Add(txtLadoB);
            Controls.Add(txtLadoA);
            Controls.Add(btnSalir);
            Controls.Add(btnReset);
            Controls.Add(btnArea);
            Controls.Add(btnSemiperimetro);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnSemiperimetro;
        private Button btnArea;
        private Button btnReset;
        private Button btnSalir;
        private TextBox txtLadoA;
        private TextBox txtLadoB;
        private TextBox txtLadoC;
        private TextBox txtSemiperimetro;
        private TextBox txtArea;
    }
}
