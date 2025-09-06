using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoVeterinario
{
    public partial class Pedido : Form
    {
        Conexao con = new Conexao();
        //VARIÁVEL TEMPORÁRIA PARA ARMAZENAR O TIPO DE ANIMAL SELECIONADO
        private string tipoAnimal = "";

        public Pedido()
        {
            InitializeComponent();
        }

        private void Pedido_Load(object sender, EventArgs e)
        {
            //TAMANHO || PORTE DO PET
            cmbPorte.Items.Add("Pequeno (R$20,00)");
            cmbPorte.Items.Add("Médio (R$30,00)");
            cmbPorte.Items.Add("Grande (R$40,00)");
            //PLANO
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
            else if (cmbPorte.SelectedIndex == 2)
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
                tipoAnimal = "Cachorro";
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
                tipoAnimal = "Gato";
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
                tipoAnimal = "Ave";
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
            else if (String.IsNullOrEmpty(tipoAnimal))
            {
                MessageBox.Show("Por favor, selecione o tipo de animal", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //INSERINDO OS DADOS NO SQL
                try
                {
                    string sql = "intert into tbplano(Nome,Idade,Porte,Raca,Plano,Tipo) values(@Nome,@Idade,@Porte,@Raca,@Plano,@Tipo)";
                    MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());
                    cmd.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = txtNome;
                    cmd.Parameters.Add("@Idade", MySqlDbType.Text).Value = txtIdade;
                    cmd.Parameters.Add("@Porte", MySqlDbType.VarChar).Value = cmbPorte;
                    cmd.Parameters.Add("@Raca", MySqlDbType.VarChar).Value = cmbRaça;
                    cmd.Parameters.Add("@Plano", MySqlDbType.VarChar).Value = cmbTipo;
                    cmd.Parameters.Add("@Tipo", MySqlDbType.VarChar).Value = tipoAnimal;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Dados salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNome.Text = "";
                    txtIdade.Text = "";
                    rbCachorro.Enabled = false;
                    rbGato.Enabled = false;
                    rbAve.Enabled = false;
                    cmbPorte.Enabled = false;
                    cmbRaça.Enabled = false;
                    cmbTipo.Enabled = false;
                    txtNome.Focus();
                    con.DesconnectarBD();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }

            }
        }

        private void dgvPesquisa_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CarregarPedidos();
        }

        //MÉTODO PARA CARREGAR AS INFORMAÇÕES NO DATAGRID
        public void CarregarPedidos()
        {
            try
            {
                txtCodPedido.Text = dgvPesquisa.SelectedRows[0].Cells[0].Value.ToString();
                txtNome.Text = dgvPesquisa.SelectedRows[0].Cells[1].Value.ToString();
                txtIdade.Text = dgvPesquisa.SelectedRows[0].Cells[2].Value.ToString();
                string tipoAnimal = dgvPesquisa.SelectedRows[0].Cells[3].Value.ToString();
                cmbPorte.Text = dgvPesquisa.SelectedRows[0].Cells[4].Value.ToString();
                cmbRaça.Text = dgvPesquisa.SelectedRows[0].Cells[4].Value.ToString();
                cmbTipo.Text = dgvPesquisa.SelectedRows[0].Cells[4].Value.ToString();
                txtValor.Text = dgvPesquisa.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erros ao clicar" + erro);
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisar.Text != "")
            {
                try
                {
                    con.ConnectarBD();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "select from * tbplano";

                    cmd.Connection = con.ConnectarBD();
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPesquisa.DataSource = dt;
                    con.DesconnectarBD();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                //LIMPA O DATAGRID
                dgvPesquisa.DataSource = null;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseja Sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sair == DialogResult.No)
            {
                Pedido ped = new Pedido();
                ped.Show();
                this.Hide();
            }
            else
            {
                Application.Exit();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtIdade.Clear();
            rbCachorro.Enabled = false;
            rbGato.Enabled = false;
            rbAve.Enabled = false;
            cmbPorte.SelectedIndex = -1;
            cmbRaça.SelectedIndex = -1;
            cmbTipo.SelectedIndex = -1;
            txtCodPedido.Clear();
            txtPesquisar.Clear();
            txtValor.Clear();
            txtNome.Focus();
        }
    }
}
