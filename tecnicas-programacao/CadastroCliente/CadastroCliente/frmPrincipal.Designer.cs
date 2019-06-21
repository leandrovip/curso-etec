namespace CadastroCliente
{
	partial class frmPrincipal
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
			this.lblTipoCliente = new System.Windows.Forms.Label();
			this.cboTipoCliente = new System.Windows.Forms.ComboBox();
			this.lblNome = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.mskDocumento = new System.Windows.Forms.MaskedTextBox();
			this.lblDocumento = new System.Windows.Forms.Label();
			this.lblEndereco = new System.Windows.Forms.Label();
			this.txtEndereco = new System.Windows.Forms.TextBox();
			this.lblNumero = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.lblBairro = new System.Windows.Forms.Label();
			this.txtBairro = new System.Windows.Forms.TextBox();
			this.lblCep = new System.Windows.Forms.Label();
			this.mskCep = new System.Windows.Forms.MaskedTextBox();
			this.lblCidade = new System.Windows.Forms.Label();
			this.txtCidade = new System.Windows.Forms.TextBox();
			this.lblUF = new System.Windows.Forms.Label();
			this.txtUf = new System.Windows.Forms.TextBox();
			this.lblDataNascimento = new System.Windows.Forms.Label();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblTipoCliente
			// 
			this.lblTipoCliente.AutoSize = true;
			this.lblTipoCliente.Location = new System.Drawing.Point(12, 23);
			this.lblTipoCliente.Name = "lblTipoCliente";
			this.lblTipoCliente.Size = new System.Drawing.Size(103, 17);
			this.lblTipoCliente.TabIndex = 12;
			this.lblTipoCliente.Text = "Tipo de Cliente";
			// 
			// cboTipoCliente
			// 
			this.cboTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboTipoCliente.FormattingEnabled = true;
			this.cboTipoCliente.Items.AddRange(new object[] {
            "Pessoa Física",
            "Pessoa Jurídica"});
			this.cboTipoCliente.Location = new System.Drawing.Point(15, 43);
			this.cboTipoCliente.Name = "cboTipoCliente";
			this.cboTipoCliente.Size = new System.Drawing.Size(175, 24);
			this.cboTipoCliente.TabIndex = 0;
			this.toolTip1.SetToolTip(this.cboTipoCliente, "Selecione o tipo do cliente");
			this.cboTipoCliente.SelectedIndexChanged += new System.EventHandler(this.cboTipoCliente_SelectedIndexChanged);
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(12, 97);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(45, 17);
			this.lblNome.TabIndex = 13;
			this.lblNome.Text = "Nome";
			// 
			// txtNome
			// 
			this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNome.Location = new System.Drawing.Point(15, 117);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(507, 23);
			this.txtNome.TabIndex = 1;
			this.txtNome.Tag = "Nome";
			// 
			// mskDocumento
			// 
			this.mskDocumento.Location = new System.Drawing.Point(528, 117);
			this.mskDocumento.Name = "mskDocumento";
			this.mskDocumento.Size = new System.Drawing.Size(214, 23);
			this.mskDocumento.TabIndex = 2;
			this.mskDocumento.Tag = "Documento";
			this.mskDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.mskDocumento.Leave += new System.EventHandler(this.mskDocumento_Leave);
			// 
			// lblDocumento
			// 
			this.lblDocumento.AutoSize = true;
			this.lblDocumento.Location = new System.Drawing.Point(525, 97);
			this.lblDocumento.Name = "lblDocumento";
			this.lblDocumento.Size = new System.Drawing.Size(80, 17);
			this.lblDocumento.TabIndex = 14;
			this.lblDocumento.Text = "Documento";
			// 
			// lblEndereco
			// 
			this.lblEndereco.AutoSize = true;
			this.lblEndereco.Location = new System.Drawing.Point(12, 165);
			this.lblEndereco.Name = "lblEndereco";
			this.lblEndereco.Size = new System.Drawing.Size(69, 17);
			this.lblEndereco.TabIndex = 15;
			this.lblEndereco.Text = "Endereço";
			// 
			// txtEndereco
			// 
			this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtEndereco.Location = new System.Drawing.Point(15, 185);
			this.txtEndereco.Name = "txtEndereco";
			this.txtEndereco.Size = new System.Drawing.Size(385, 23);
			this.txtEndereco.TabIndex = 3;
			this.txtEndereco.Tag = "Endereço";
			// 
			// lblNumero
			// 
			this.lblNumero.AutoSize = true;
			this.lblNumero.Location = new System.Drawing.Point(403, 165);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(58, 17);
			this.lblNumero.TabIndex = 16;
			this.lblNumero.Text = "Número";
			// 
			// txtNumero
			// 
			this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtNumero.Location = new System.Drawing.Point(406, 185);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(116, 23);
			this.txtNumero.TabIndex = 4;
			this.txtNumero.Tag = "Número";
			// 
			// lblBairro
			// 
			this.lblBairro.AutoSize = true;
			this.lblBairro.Location = new System.Drawing.Point(525, 165);
			this.lblBairro.Name = "lblBairro";
			this.lblBairro.Size = new System.Drawing.Size(46, 17);
			this.lblBairro.TabIndex = 17;
			this.lblBairro.Text = "Bairro";
			// 
			// txtBairro
			// 
			this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtBairro.Location = new System.Drawing.Point(528, 185);
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(214, 23);
			this.txtBairro.TabIndex = 5;
			this.txtBairro.Tag = "Bairro";
			// 
			// lblCep
			// 
			this.lblCep.AutoSize = true;
			this.lblCep.Location = new System.Drawing.Point(12, 234);
			this.lblCep.Name = "lblCep";
			this.lblCep.Size = new System.Drawing.Size(35, 17);
			this.lblCep.TabIndex = 18;
			this.lblCep.Text = "CEP";
			// 
			// mskCep
			// 
			this.mskCep.Location = new System.Drawing.Point(15, 254);
			this.mskCep.Mask = "##.###-###";
			this.mskCep.Name = "mskCep";
			this.mskCep.Size = new System.Drawing.Size(145, 23);
			this.mskCep.TabIndex = 6;
			this.mskCep.Tag = "CEP";
			this.mskCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblCidade
			// 
			this.lblCidade.AutoSize = true;
			this.lblCidade.Location = new System.Drawing.Point(163, 234);
			this.lblCidade.Name = "lblCidade";
			this.lblCidade.Size = new System.Drawing.Size(52, 17);
			this.lblCidade.TabIndex = 19;
			this.lblCidade.Text = "Cidade";
			// 
			// txtCidade
			// 
			this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCidade.Location = new System.Drawing.Point(166, 254);
			this.txtCidade.Name = "txtCidade";
			this.txtCidade.Size = new System.Drawing.Size(356, 23);
			this.txtCidade.TabIndex = 7;
			this.txtCidade.Tag = "Cidade";
			// 
			// lblUF
			// 
			this.lblUF.AutoSize = true;
			this.lblUF.Location = new System.Drawing.Point(525, 234);
			this.lblUF.Name = "lblUF";
			this.lblUF.Size = new System.Drawing.Size(26, 17);
			this.lblUF.TabIndex = 20;
			this.lblUF.Text = "UF";
			// 
			// txtUf
			// 
			this.txtUf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtUf.Location = new System.Drawing.Point(528, 254);
			this.txtUf.Name = "txtUf";
			this.txtUf.Size = new System.Drawing.Size(214, 23);
			this.txtUf.TabIndex = 8;
			this.txtUf.Tag = "Estado";
			// 
			// lblDataNascimento
			// 
			this.lblDataNascimento.AutoSize = true;
			this.lblDataNascimento.Location = new System.Drawing.Point(12, 294);
			this.lblDataNascimento.Name = "lblDataNascimento";
			this.lblDataNascimento.Size = new System.Drawing.Size(116, 17);
			this.lblDataNascimento.TabIndex = 21;
			this.lblDataNascimento.Text = "Data Nascimento";
			// 
			// btnSalvar
			// 
			this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(50)))));
			this.btnSalvar.FlatAppearance.BorderSize = 0;
			this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalvar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnSalvar.ForeColor = System.Drawing.Color.White;
			this.btnSalvar.Location = new System.Drawing.Point(277, 300);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(151, 43);
			this.btnSalvar.TabIndex = 10;
			this.btnSalvar.Text = "Salvar";
			this.toolTip1.SetToolTip(this.btnSalvar, "Clique para salvar o cliente atual");
			this.btnSalvar.UseVisualStyleBackColor = false;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// btnSair
			// 
			this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
			this.btnSair.FlatAppearance.BorderSize = 0;
			this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSair.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnSair.ForeColor = System.Drawing.Color.White;
			this.btnSair.Location = new System.Drawing.Point(591, 300);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(151, 43);
			this.btnSair.TabIndex = 12;
			this.btnSair.Text = "Sair";
			this.toolTip1.SetToolTip(this.btnSair, "Clique para fechar o formulário");
			this.btnSair.UseVisualStyleBackColor = false;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// toolTip1
			// 
			this.toolTip1.AutoPopDelay = 10000;
			this.toolTip1.InitialDelay = 100;
			this.toolTip1.ReshowDelay = 100;
			this.toolTip1.ShowAlways = true;
			// 
			// dtpDataNascimento
			// 
			this.dtpDataNascimento.CustomFormat = "";
			this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDataNascimento.Location = new System.Drawing.Point(15, 320);
			this.dtpDataNascimento.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
			this.dtpDataNascimento.Name = "dtpDataNascimento";
			this.dtpDataNascimento.Size = new System.Drawing.Size(145, 23);
			this.dtpDataNascimento.TabIndex = 9;
			// 
			// btnLimpar
			// 
			this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(66)))), ((int)(((byte)(250)))));
			this.btnLimpar.FlatAppearance.BorderSize = 0;
			this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimpar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnLimpar.ForeColor = System.Drawing.Color.White;
			this.btnLimpar.Location = new System.Drawing.Point(434, 300);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(151, 43);
			this.btnLimpar.TabIndex = 11;
			this.btnLimpar.Text = "Limpar";
			this.toolTip1.SetToolTip(this.btnLimpar, "Clique para limpar os campos preenchidos");
			this.btnLimpar.UseVisualStyleBackColor = false;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// frmPrincipal
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(754, 355);
			this.Controls.Add(this.dtpDataNascimento);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.mskCep);
			this.Controls.Add(this.mskDocumento);
			this.Controls.Add(this.txtBairro);
			this.Controls.Add(this.txtUf);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.txtCidade);
			this.Controls.Add(this.txtEndereco);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.lblUF);
			this.Controls.Add(this.lblBairro);
			this.Controls.Add(this.lblNumero);
			this.Controls.Add(this.cboTipoCliente);
			this.Controls.Add(this.lblCidade);
			this.Controls.Add(this.lblCep);
			this.Controls.Add(this.lblDataNascimento);
			this.Controls.Add(this.lblEndereco);
			this.Controls.Add(this.lblDocumento);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.lblTipoCliente);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Exercício - Cadastro de Clientes";
			this.Load += new System.EventHandler(this.frmPrincipal_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTipoCliente;
		private System.Windows.Forms.ComboBox cboTipoCliente;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.MaskedTextBox mskDocumento;
		private System.Windows.Forms.Label lblDocumento;
		private System.Windows.Forms.Label lblEndereco;
		private System.Windows.Forms.TextBox txtEndereco;
		private System.Windows.Forms.Label lblNumero;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Label lblBairro;
		private System.Windows.Forms.TextBox txtBairro;
		private System.Windows.Forms.Label lblCep;
		private System.Windows.Forms.MaskedTextBox mskCep;
		private System.Windows.Forms.Label lblCidade;
		private System.Windows.Forms.TextBox txtCidade;
		private System.Windows.Forms.Label lblUF;
		private System.Windows.Forms.TextBox txtUf;
		private System.Windows.Forms.Label lblDataNascimento;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnSair;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.DateTimePicker dtpDataNascimento;
		private System.Windows.Forms.Button btnLimpar;
	}
}