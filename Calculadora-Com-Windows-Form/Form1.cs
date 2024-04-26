namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public decimal Resultado { get; set; }
        public decimal Valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }
        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multioplicacao,
            Divisao

        }


        private void textDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "1";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "6";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "8";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textDisplay.Text += "9";

        }

        private void btnAdicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(textDisplay.Text);
            textDisplay.Text = "";
            labelOperação.Text = "Adição";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(textDisplay.Text);
            textDisplay.Text = "";
            labelOperação.Text = "Subtração";


        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multioplicacao;
            Valor = Convert.ToDecimal(textDisplay.Text);
            textDisplay.Text = "";
            labelOperação.Text = "Multiplicação";


        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {            
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(textDisplay.Text);
            textDisplay.Text = "";
            labelOperação.Text = "Divisão";

        }

      

        private void btnvirgula_Click(object sender, EventArgs e)
        {
            if(!textDisplay.Text.Contains(","))
            textDisplay.Text += ",";

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "";
        }

       

       

        private void btnResultado_Click(object sender, EventArgs e)
        {

            switch(OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(textDisplay.Text);
                    break;

                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(textDisplay.Text);
                    break;  

                 case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(textDisplay.Text);
                    break;

                case Operacao.Multioplicacao:
                    Resultado = Valor * Convert.ToDecimal(textDisplay.Text);
                    break;
            }
            labelOperação.Text = "Resultado";

            textDisplay.Text = Convert.ToString(Resultado);
        }
    }
}
