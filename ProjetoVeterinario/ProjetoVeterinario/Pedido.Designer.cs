namespace ProjetoVeterinario
{
    partial class Pedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedido));
            this.rbAve = new System.Windows.Forms.RadioButton();
            this.rbGato = new System.Windows.Forms.RadioButton();
            this.rbCachorro = new System.Windows.Forms.RadioButton();
            this.lblPlano = new System.Windows.Forms.Label();
            this.lblRaça = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtCodPedido = new System.Windows.Forms.TextBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbRaça = new System.Windows.Forms.ComboBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.lblPorte = new System.Windows.Forms.Label();
            this.cmbPorte = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            this.gbTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbAve
            // 
            this.rbAve.AutoSize = true;
            this.rbAve.ForeColor = System.Drawing.Color.White;
            this.rbAve.Location = new System.Drawing.Point(7, 99);
            this.rbAve.Name = "rbAve";
            this.rbAve.Size = new System.Drawing.Size(52, 20);
            this.rbAve.TabIndex = 4;
            this.rbAve.TabStop = true;
            this.rbAve.Text = "Ave";
            this.rbAve.UseVisualStyleBackColor = true;
            this.rbAve.Click += new System.EventHandler(this.rbAve_CheckedChanged);
            // 
            // rbGato
            // 
            this.rbGato.AutoSize = true;
            this.rbGato.ForeColor = System.Drawing.Color.White;
            this.rbGato.Location = new System.Drawing.Point(7, 73);
            this.rbGato.Name = "rbGato";
            this.rbGato.Size = new System.Drawing.Size(58, 20);
            this.rbGato.TabIndex = 3;
            this.rbGato.TabStop = true;
            this.rbGato.Text = "Gato";
            this.rbGato.UseVisualStyleBackColor = true;
            this.rbGato.Click += new System.EventHandler(this.rbGato_CheckedChanged);
            // 
            // rbCachorro
            // 
            this.rbCachorro.AutoSize = true;
            this.rbCachorro.ForeColor = System.Drawing.Color.White;
            this.rbCachorro.Location = new System.Drawing.Point(7, 47);
            this.rbCachorro.Name = "rbCachorro";
            this.rbCachorro.Size = new System.Drawing.Size(88, 20);
            this.rbCachorro.TabIndex = 2;
            this.rbCachorro.TabStop = true;
            this.rbCachorro.Text = "Cachorro";
            this.rbCachorro.UseVisualStyleBackColor = true;
            this.rbCachorro.Click += new System.EventHandler(this.rbCachorro_CheckedChanged);
            // 
            // lblPlano
            // 
            this.lblPlano.AutoSize = true;
            this.lblPlano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlano.ForeColor = System.Drawing.Color.White;
            this.lblPlano.Location = new System.Drawing.Point(28, 480);
            this.lblPlano.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlano.Name = "lblPlano";
            this.lblPlano.Size = new System.Drawing.Size(104, 16);
            this.lblPlano.TabIndex = 89;
            this.lblPlano.Text = "Tipo do plano";
            // 
            // lblRaça
            // 
            this.lblRaça.AutoSize = true;
            this.lblRaça.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaça.ForeColor = System.Drawing.Color.White;
            this.lblRaça.Location = new System.Drawing.Point(29, 415);
            this.lblRaça.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRaça.Name = "lblRaça";
            this.lblRaça.Size = new System.Drawing.Size(116, 16);
            this.lblRaça.TabIndex = 88;
            this.lblRaça.Text = "Raça do animal";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.DarkRed;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(794, 287);
            this.btnSair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(154, 39);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(403, 488);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(235, 39);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular Orçamento";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Green;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(621, 287);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(154, 39);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(421, 287);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(178, 39);
            this.btnNovo.TabIndex = 10;
            this.btnNovo.Text = "Nova Consulta";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtCodPedido
            // 
            this.txtCodPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodPedido.Location = new System.Drawing.Point(415, 35);
            this.txtCodPedido.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodPedido.Name = "txtCodPedido";
            this.txtCodPedido.ReadOnly = true;
            this.txtCodPedido.Size = new System.Drawing.Size(107, 22);
            this.txtCodPedido.TabIndex = 83;
            this.txtCodPedido.TabStop = false;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(651, 35);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(310, 22);
            this.txtPesquisar.TabIndex = 11;
            this.txtPesquisar.Click += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisar.ForeColor = System.Drawing.Color.White;
            this.lblPesquisar.Location = new System.Drawing.Point(551, 38);
            this.lblPesquisar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(98, 16);
            this.lblPesquisar.TabIndex = 81;
            this.lblPesquisar.Text = "PESQUISAR:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.White;
            this.lblValor.Location = new System.Drawing.Point(677, 499);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(113, 16);
            this.lblValor.TabIndex = 80;
            this.lblValor.Text = "Valor do plano:";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtValor.Location = new System.Drawing.Point(794, 493);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(132, 31);
            this.txtValor.TabIndex = 79;
            this.txtValor.TabStop = false;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.ForeColor = System.Drawing.Color.White;
            this.lblIdade.Location = new System.Drawing.Point(33, 76);
            this.lblIdade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(119, 16);
            this.lblIdade.TabIndex = 78;
            this.lblIdade.Text = "Idade do animal";
            // 
            // txtIdade
            // 
            this.txtIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdade.Location = new System.Drawing.Point(31, 96);
            this.txtIdade.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(132, 22);
            this.txtIdade.TabIndex = 1;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(27, 500);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(230, 24);
            this.cmbTipo.TabIndex = 7;
            // 
            // cmbRaça
            // 
            this.cmbRaça.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRaça.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRaça.FormattingEnabled = true;
            this.cmbRaça.Location = new System.Drawing.Point(26, 434);
            this.cmbRaça.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRaça.Name = "cmbRaça";
            this.cmbRaça.Size = new System.Drawing.Size(230, 24);
            this.cmbRaça.TabIndex = 6;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(31, 16);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(120, 16);
            this.lblNome.TabIndex = 74;
            this.lblNome.Text = "Nome do animal";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(31, 35);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(230, 22);
            this.txtNome.TabIndex = 0;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.Location = new System.Drawing.Point(383, 65);
            this.dgvPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.ReadOnly = true;
            this.dgvPesquisa.Size = new System.Drawing.Size(606, 216);
            this.dgvPesquisa.TabIndex = 72;
            this.dgvPesquisa.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvPesquisa_MouseDoubleClick);
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.rbAve);
            this.gbTipo.Controls.Add(this.rbGato);
            this.gbTipo.Controls.Add(this.rbCachorro);
            this.gbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipo.ForeColor = System.Drawing.Color.White;
            this.gbTipo.Location = new System.Drawing.Point(27, 144);
            this.gbTipo.Margin = new System.Windows.Forms.Padding(4);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Padding = new System.Windows.Forms.Padding(4);
            this.gbTipo.Size = new System.Drawing.Size(267, 182);
            this.gbTipo.TabIndex = 71;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Tipo de Animal";
            // 
            // lblPorte
            // 
            this.lblPorte.AutoSize = true;
            this.lblPorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorte.ForeColor = System.Drawing.Color.White;
            this.lblPorte.Location = new System.Drawing.Point(23, 348);
            this.lblPorte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPorte.Name = "lblPorte";
            this.lblPorte.Size = new System.Drawing.Size(116, 16);
            this.lblPorte.TabIndex = 70;
            this.lblPorte.Text = "Porte do animal";
            // 
            // cmbPorte
            // 
            this.cmbPorte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPorte.FormattingEnabled = true;
            this.cmbPorte.Location = new System.Drawing.Point(27, 368);
            this.cmbPorte.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPorte.Name = "cmbPorte";
            this.cmbPorte.Size = new System.Drawing.Size(230, 24);
            this.cmbPorte.TabIndex = 5;
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblPlano);
            this.Controls.Add(this.lblRaça);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtCodPedido);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.cmbRaça);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dgvPesquisa);
            this.Controls.Add(this.gbTipo);
            this.Controls.Add(this.lblPorte);
            this.Controls.Add(this.cmbPorte);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Pedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.Pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbAve;
        private System.Windows.Forms.RadioButton rbGato;
        private System.Windows.Forms.RadioButton rbCachorro;
        private System.Windows.Forms.Label lblPlano;
        private System.Windows.Forms.Label lblRaça;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtCodPedido;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbRaça;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dgvPesquisa;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.Label lblPorte;
        private System.Windows.Forms.ComboBox cmbPorte;
    }
}