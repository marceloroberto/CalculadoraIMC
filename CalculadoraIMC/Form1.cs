namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        public double altura, peso, resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            altura = Convert.ToDouble(txtAltura.Text);
            peso = Convert.ToDouble(txtPeso.Text);

            resultado = peso / (altura * altura);

            //lblResultado.Text = Convert.ToString(resultado); // Traz o resultado sem limite de números
            //lblResultado.Text = resultado.ToString("F2"); // Formata o resultado com o tipo Flutuante com 2 casas decimais


            if (resultado > 40)
            {
                lblResultado.Text = "Resultado: " + resultado.ToString("F2") + " - Obesidade III (Mórbida)";
            }
            else if (resultado > 35 && resultado < 39.99)
            {
                lblResultado.Text = "Resultado: " + resultado.ToString("F2") + " - Obesidade II (Severa)";
            }
            else if (resultado > 30 && resultado < 34.99)
            {
                lblResultado.Text = "Resultado: " + resultado.ToString("F2") + " - Obesidade I";
            }
            else if (resultado > 25 && resultado < 29.99)
            {
                lblResultado.Text = "Resultado: " + resultado.ToString("F2") + " - Acima do peso";
            }
            else if (resultado > 18.5 && resultado < 24.99)
            {
                lblResultado.Text = "Resultado: " + resultado.ToString("F2") + " - Peso normal";
            }
            else if (resultado > 17 && resultado < 18.49)
            {
                lblResultado.Text = "Resultado: " + resultado.ToString("F2") + " - Abaixo do peso";
            }
            else if (resultado < 17)
            {
                lblResultado.Text = "Resultado: " + resultado.ToString("F2") + " - Muito abaixo do peso";
            }


        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
