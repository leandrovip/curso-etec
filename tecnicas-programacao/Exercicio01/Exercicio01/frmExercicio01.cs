using System;
using System.Drawing;
using System.Windows.Forms;

namespace Exercicio01
{
    public partial class frmExercicio01 : Form
    {
        public frmExercicio01()
        {
            InitializeComponent();

            // Formulario = frm
            // TextBox = txt
            // Label = lbl
            // ComboBox = cbo
            // DataGridView = dgv dtg
            // ListBoxView = ltv = ltb
            // ChcekBox = ckb
        }

        private void InitializeComponent()
        {
            txtNumero = new TextBox();
            lblNumero = new Label();
            btnResultado = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumero.Location = new Point(12, 83);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(336, 23);
            txtNumero.TabIndex = 0;
            txtNumero.TextAlign = HorizontalAlignment.Center;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 10F);
            lblNumero.Location = new Point(12, 61);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(216, 19);
            lblNumero.TabIndex = 3;
            lblNumero.Text = "Informe o número a ser verificado";
            // 
            // btnResultado
            // 
            btnResultado.BackColor = Color.LightGreen;
            btnResultado.FlatAppearance.BorderSize = 0;
            btnResultado.FlatStyle = FlatStyle.Flat;
            btnResultado.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResultado.Location = new Point(204, 169);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(144, 37);
            btnResultado.TabIndex = 1;
            btnResultado.Text = "Verificar";
            btnResultado.UseVisualStyleBackColor = false;
            btnResultado.Click += btnResultado_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.Location = new Point(25, 18);
            label1.Name = "label1";
            label1.Size = new Size(306, 25);
            label1.TabIndex = 2;
            label1.Text = "Verificar se número é par ou ímpar";
            // 
            // frmExercicio01
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 218);
            Controls.Add(btnResultado);
            Controls.Add(label1);
            Controls.Add(lblNumero);
            Controls.Add(txtNumero);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmExercicio01";
            Text = "Exercício 01";
            Load += frmExercicio01_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            // Verifica se existe algo digitado
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                MessageBox.Show("Nenhum número informado, tente novamente");
                return;
            }

            // Testar se consegue converter o valor para inteiro
            if (!int.TryParse(txtNumero.Text, out var numeroConvertido))
            {
                MessageBox.Show("Digite um número válido");
                return;
            }

            var numero = numeroConvertido; /*Convert.ToInt32(txtNumero.Text);*/
            var resultado = numero % 2;

            if (resultado == 0)
                MessageBox.Show("O número é PAR", "Resultado", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else
                MessageBox.Show("O número é ÍMPAR", "Resultado", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            txtNumero.Focus();
            txtNumero.SelectAll();
        }

        private void frmExercicio01_Load(object sender, EventArgs e) { }
    }
}