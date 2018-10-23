using System;
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnResultado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // txtNumero
            //
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(12, 83);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(336, 23);
            this.txtNumero.TabIndex = 0;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            // lblNumero
            //
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNumero.Location = new System.Drawing.Point(12, 61);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(216, 19);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Informe o número a ser verificado";
            //
            // btnResultado
            //
            this.btnResultado.BackColor = System.Drawing.Color.LightGreen;
            this.btnResultado.FlatAppearance.BorderSize = 0;
            this.btnResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultado.Location = new System.Drawing.Point(204, 169);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(144, 37);
            this.btnResultado.TabIndex = 1;
            this.btnResultado.Text = "Verificar";
            this.btnResultado.UseVisualStyleBackColor = false;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Verificar se número é par ou ímpar";
            //
            // frmExercicio01
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 218);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtNumero);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExercicio01";
            this.Text = "Exercício 01";
            this.ResumeLayout(false);
            this.PerformLayout();
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

            int numero = numeroConvertido; /*Convert.ToInt32(txtNumero.Text);*/
            int resultado = numero % 2;

            if (resultado == 0)
            {
                MessageBox.Show("O número é PAR", "Resultado", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O número é ÍMPAR", "Resultado", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            txtNumero.Focus();
            txtNumero.SelectAll();
        }
    }
}