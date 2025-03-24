namespace Calculadora
{
    public partial class Form1 : Form
    {
        public double temporal { get; set; }
        public string operador { get; set; }
        public Form1()
        {
            InitializeComponent();
            txtPantalla.Text = "0";
            temporal = 0;
            operador = "";
        }
        public void Numero_Click(Object sender, EventArgs e)
        {
            Button presionado = (Button)sender;
            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = "";
            }
            if (presionado.Text == ".")
            {
                if (!txtPantalla.Text.Contains("."))
                {
                    txtPantalla.Text += ".";
                }
            }
            else
            {
                txtPantalla.Text += presionado.Text;
            }
        }
        public void Operador_Click(Object sender, EventArgs e)
        {
            Button presionado = (Button)sender;
            temporal = double.Parse(txtPantalla.Text);
            lblPantalla.Text = txtPantalla.Text;
            txtPantalla.Text = "";
            operador = presionado.Text;
            lblPantalla.Text += " " + operador + " ";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            lblPantalla.Text += txtPantalla.Text + "=";
            double auxiliar = double.Parse(txtPantalla.Text);
            switch (operador)
            {
                case "+":
                    temporal = temporal + auxiliar;
                    break;
                case "-":
                    temporal = temporal - auxiliar;
                    break;
                case "*":
                    temporal = temporal * auxiliar;
                    break;
                case "/":
                    temporal = temporal / auxiliar;
                    break;
            }
            txtPantalla.Text = temporal.ToString();
            temporal = 0;
            operador = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblPantalla.Text = "";
            txtPantalla.Text = "";
            temporal = 0;
            operador = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblPantalla.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double auxiliar = double.Parse(txtPantalla.Text);
            auxiliar = auxiliar * -1;
            txtPantalla.Text = auxiliar.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string auxiliar = txtPantalla.Text;
            if (auxiliar.Length > 0) {
                string aux = "";
                for (int i = 0; i< auxiliar.Length - 1; i++) {
                    aux += auxiliar[i];
                }
                txtPantalla.Text = aux.ToString();
            } else {
                txtPantalla.Text = "0";
            }

        }
    }
}
