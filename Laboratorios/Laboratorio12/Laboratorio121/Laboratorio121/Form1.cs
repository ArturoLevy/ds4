namespace Laboratorio121
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtVelocidad.Clear();
            txtTiempo.Clear();
            txtResultado.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Obtener la velocidad y el tiempo ingresados como texto
            double velocidad = Convert.ToDouble(txtVelocidad.Text);
            double tiempo = Convert.ToDouble(txtTiempo.Text);

            // Calcular la distancia: distancia = velocidad * tiempo
            double distancia = velocidad * tiempo;

            // Mostrar el resultado en el TextBox3
            txtResultado.Text = distancia.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
