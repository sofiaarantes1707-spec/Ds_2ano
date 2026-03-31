using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Calculos
{
    public partial class CalculadoraPlus : Form
    {
        decimal vNumAnt;
        string vOperacao;
        bool vLimparVisor;
        public CalculadoraPlus()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }
   

        private void f_digitos(object sender, EventArgs e)
        {
            string digito = ((Button)sender).Text;
            if (lblVisor.Text == "0" || vLimparVisor)
                //se a pessoa apertar 0 vai limpar ou:
            {
                lblVisor.Text = "";
                vLimparVisor = false;
                //se a pessoa escerver nada
            }
            lblVisor.Text += digito; //em cadeia

            this.ActiveControl = null; //ou //lblVisor.Focus();
            //apertar o botao - nao deixar o foco no botão
            //o enter executa o botao que tem o foco, entao se tiver o foco no botao 1, o enter vai apertar o 1
        }
        private void f_operacoes(object sender, EventArgs e)
        { 
            vNumAnt = decimal.Parse(lblVisor.Text);
            vOperacao = ((Button)sender).Text;
            vLimparVisor = true; //intrução de atribuição - atribui o valor verdadeiro
            lblHistorico.Text = "";
            lblHistorico.Text = vNumAnt + " " + vOperacao + " ";
            this.ActiveControl = null;
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!lblVisor.Text.Contains(",")) 
            {
                //se o  texto do visor nao tiver virgula, 
                lblVisor.Text += ",";
            }
        }

        private void btnLimpar_Click (object sender, EventArgs e)
        {
            vNumAnt = 0;
            lblVisor.Text = "0";
        }

        private void bntigual_Click_1(object sender, EventArgs e)
        {
            decimal vNumAtual = decimal.Parse(lblVisor.Text);
            //decidir que operaçao realizar
            switch (vOperacao)
            {
                case "+":
                    lblVisor.Text = (vNumAnt + vNumAtual).ToString();
                    break;
                case "-":
                    lblVisor.Text = (vNumAnt - vNumAtual).ToString();
                    break;
            }
            lblHistorico.Text += vNumAtual + "=";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            lblVisor.Text = lblVisor.Text.Substring(0, lblVisor.Text.Length - 1);
            if (lblVisor.Text == "")
            {
                lblVisor.Text = "0";
            }   
        }

        private void CalculadoraPlus_Load(object sender, EventArgs e)
        {

        }

        private void CalculadoraPlus_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = e.KeyCode.ToString();
            //quando a pessoa apertar uma tecla, o label1 vai mostrar qual tecla foi apertada
            //como o cshar ve o codigo das teclas dentro do keydown
            Button botao = new Button();
            if (e.KeyCode == Keys.Escape) //esc
            {
                Close();
            }
            if(e.KeyCode >= Keys.NumPad0 && e.KeyCode<= Keys.NumPad9)
            {
                botao.Text = e.KeyCode.ToString().Substring(6);
                f_digitos(botao, e); // a funcao f digitos precisa dos objetos e do argumento
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
