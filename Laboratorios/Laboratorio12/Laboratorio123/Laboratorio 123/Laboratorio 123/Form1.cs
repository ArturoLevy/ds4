namespace Laboratorio_123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtLadoA.Clear();
            txtLadoB.Clear();
            txtLadoC.Clear();
            txtSemiperimetro.Clear();
            txtArea.Clear();
        }

        private void btnSemiperimetro_Click(object sender, EventArgs e)
        {
            double ladoA = Convert.ToDouble(txtLadoA.Text);
            double ladoB = Convert.ToDouble(txtLadoB.Text);
            double ladoC = Convert.ToDouble(txtLadoC.Text);

            // Calcular el semiperímetro
            double semiperimetro = (ladoA + ladoB + ladoC) / 2;

            txtSemiperimetro.Text = semiperimetro.ToString();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            double ladoA = Convert.ToDouble(txtLadoA.Text);
            double ladoB = Convert.ToDouble(txtLadoB.Text);
            double ladoC = Convert.ToDouble(txtLadoC.Text);

            // Calculo del semiperimetro
            double semiperimetro = (ladoA + ladoB + ladoC) / 2;

            // Se investigo la formula de Heron para calcular el area de un triangulo
            double area = Math.Sqrt(semiperimetro * (semiperimetro - ladoA) * (semiperimetro - ladoB) * (semiperimetro - ladoC));

            txtArea.Text = area.ToString();
        }
    }
}
