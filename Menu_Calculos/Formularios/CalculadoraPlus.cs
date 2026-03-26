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
            {
                lblVisor.Text = "";
                vLimparVisor = false;
            }
            lblVisor.Text += digito;
        }
        private void f_operacoes(object sender, EventArgs e)
        { 
            vNumAnt = decimal.Parse(lblVisor.Text);
            vOperacao = ((Button)sender).Text;
            vLimparVisor = true;
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (lblVisor.Text.Contains(",")) 
            {
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
            //decidir que operaçao realizar
            switch (vOperacao)
            {
                case "+":
                    lblVisor.Text = (vNumAnt + decimal.Parse(lblVisor.Text)).ToString();
                    break;
                case "-":
                    lblVisor.Text = (vNumAnt - decimal.Parse(lblVisor.Text)).ToString();
                    break;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            lblVisor.Text = lblVisor.Text.Substring(0, lblVisor.Text.Length - 1);
            if (lblVisor.Text == "")
            {
                lblVisor.Text = "0";
            }   
        }
    }
}
