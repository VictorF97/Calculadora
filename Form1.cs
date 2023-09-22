namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public decimal Resultado { get; set; }

        public decimal Valor { get; set; }

        private Operacao OperacaoSelecionada { get; set; }
        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao,
            Elevado,
            RaizQuadrada
        }
        public Calculadora()
        {
            InitializeComponent();
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            textResultado.Text += "0";
        }

        private void buttonUm_Click(object sender, EventArgs e)
        {
            textResultado.Text += "1";
        }

        private void buttonDois_Click(object sender, EventArgs e)
        {
            textResultado.Text += "2";
        }

        private void buttonTres_Click(object sender, EventArgs e)
        {
            textResultado.Text += "3";
        }

        private void buttonQuatro_Click(object sender, EventArgs e)
        {
            textResultado.Text += "4";
        }

        private void buttonCinco_Click(object sender, EventArgs e)
        {
            textResultado.Text += "5";
        }

        private void buttonSeis_Click(object sender, EventArgs e)
        {
            textResultado.Text += "6";
        }

        private void buttonSete_Click(object sender, EventArgs e)
        {
            textResultado.Text += "7";
        }

        private void buttonOito_Click(object sender, EventArgs e)
        {
            textResultado.Text += "8";
        }

        private void buttonNove_Click(object sender, EventArgs e)
        {
            textResultado.Text += "9";
        }

        private void buttonVirgula_Click(object sender, EventArgs e)
        {
            if (!textResultado.Text.Contains(","))
                textResultado.Text += ",";
        }

        private void buttonAdicao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(textResultado.Text);
            textResultado.Text = "";
            labelOperacao.Text = "+";
        }

        private void buttonSubtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(textResultado.Text);
            textResultado.Text = "";
            labelOperacao.Text = "-";
        }

        private void buttonMultiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(textResultado.Text);
            textResultado.Text = "";
            labelOperacao.Text = "X";
        }

        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(textResultado.Text);
            textResultado.Text = "";
            labelOperacao.Text = "/";
        }

        private void buttonAC_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
            labelOperacao.Text = "";
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(textResultado.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(textResultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(textResultado.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(textResultado.Text);
                    break;
                case Operacao.Elevado:

                    break;
            }
            textResultado.Text = Convert.ToString(Resultado);
            labelOperacao.Text = "=";
        }
    }
}