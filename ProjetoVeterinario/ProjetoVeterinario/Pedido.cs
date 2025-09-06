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
        public Pedido()
        {
            InitializeComponent();
        }

        private void Pedido_Load(object sender, EventArgs e)
        {
            //TAMANHO PET
            cmbPorte.Items.Add("Pequeno");
            cmbPorte.Items.Add("Médio");
            cmbPorte.Items.Add("Grande");
            //PLANO
            cmbTipo.Items.Add("Básico");
            cmbTipo.Items.Add("Integral");
            cmbTipo.Items.Add("Preferencial");


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
    }
}
