using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoVeterinario
{
    public partial class Pedido : Form
    {
        Conexao con = new Conexao();

        public Pedido()
        {
            InitializeComponent();
        }

        private void Pedido_Load(object sender, EventArgs e)
        {
            //TAMANHO || PORTE DO PET
            cmbPorte.Items.Add("...");
            cmbPorte.Items.Add("Pequeno (R$20,00)");
            cmbPorte.Items.Add("Médio (R$30,00)");
            cmbPorte.Items.Add("Grande (R$40,00)");
            //PLANO
            cmbTipo.Items.Add("...");
            cmbTipo.Items.Add("Básico (R$50,00)");
            cmbTipo.Items.Add("Integral (R$100,00)");
            cmbTipo.Items.Add("Preferencial (R$150,00)");

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Variaveis
            double valorPorte = 0; double valorPlano = 0; double valorTotal = 0;

            //VALORES ADICIONAIS POR PORTE
            if (cmbPorte.SelectedIndex == 0)
            {
                valorPorte = 20;
            }
            else if (cmbPorte.SelectedIndex == 1)
            {
                valorPorte = 30;
            }
            else if ( cmbPorte.SelectedIndex == 2)
            {
                valorPorte = 40;
            }

            //VALORES ADICIONAIS POR PLANO
            if (cmbTipo.SelectedIndex == 0)
            {
                valorPlano = 50;
            }
            else if (cmbTipo.SelectedIndex == 1)
            {
                valorPlano = 100;
            }
            else if (cmbTipo.SelectedIndex == 2)
            {
                valorPlano = 150;
            }
            else
            {

            }
            valorTotal = valorPorte + valorPlano;
            txtValor.Text = valorTotal.ToString("C");
        }

        //ESCOLHA DA RAÇA DO ANIMAL (IRRELEVANTE NO VALOR TOTAL)
        private void rbCachorro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCachorro.Checked)
            {
                cmbRaça.Items.Clear();
                cmbRaça.Items.Add("Labrador");
                cmbRaça.Items.Add("Poodle");
                cmbRaça.Items.Add("Bulldog");
                cmbRaça.Items.Add("Beagle");
                cmbRaça.Items.Add("Golden Retriever");
                cmbRaça.Items.Add("Rottweiler");
            }
        }

        private void rbGato_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGato.Checked)
            {
                cmbRaça.Items.Clear();
                cmbRaça.Items.Add("Siamês");
                cmbRaça.Items.Add("Persa");
                cmbRaça.Items.Add("Maine Coon");
                cmbRaça.Items.Add("Sphynx");
                cmbRaça.Items.Add("Bengal");
                cmbRaça.Items.Add("British Shorthair");
            }
        }

        private void rbAve_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAve.Checked)
            {
                cmbRaça.Items.Clear();
                cmbRaça.Items.Add("Calopsita");
                cmbRaça.Items.Add("Periquito");
                cmbRaça.Items.Add("Canário");
                cmbRaça.Items.Add("Agapornis");
                cmbRaça.Items.Add("Cacatua");
                cmbRaça.Items.Add("Papagaio");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //VERIFICAÇÃO DOS CAMPOS
            
            // VERIFICA SE ALGUM ITEM FOI SELECIONADO NO CMBPORTE
            if (cmbPorte.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione o porte do pet.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPorte.Focus();
            }

            // VERIFICA SE ALGUM ITEM FOI SELECIONADO NO CMBTIPO
            else if (cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione o tipo de plano.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTipo.Focus();
            }
            else
            {
                MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
