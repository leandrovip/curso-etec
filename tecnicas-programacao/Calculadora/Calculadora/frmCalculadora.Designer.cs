namespace Calculadora
{
    partial class frmCalculadora
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
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txt7 = new System.Windows.Forms.Button();
            this.txt8 = new System.Windows.Forms.Button();
            this.txt9 = new System.Windows.Forms.Button();
            this.txtDivisao = new System.Windows.Forms.Button();
            this.txt4 = new System.Windows.Forms.Button();
            this.txt5 = new System.Windows.Forms.Button();
            this.txt6 = new System.Windows.Forms.Button();
            this.txtMultiplicacao = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.Button();
            this.txt3 = new System.Windows.Forms.Button();
            this.txtAdicao = new System.Windows.Forms.Button();
            this.txt0 = new System.Windows.Forms.Button();
            this.txtSubtracao = new System.Windows.Forms.Button();
            this.txtIgual = new System.Windows.Forms.Button();
            this.txtLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(12, 12);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(337, 53);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // txt7
            // 
            this.txt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt7.Location = new System.Drawing.Point(12, 151);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(71, 68);
            this.txt7.TabIndex = 1;
            this.txt7.Text = "7";
            this.txt7.UseVisualStyleBackColor = true;
            this.txt7.Click += new System.EventHandler(this.TextBox_Numero);
            // 
            // txt8
            // 
            this.txt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt8.Location = new System.Drawing.Point(100, 151);
            this.txt8.Name = "txt8";
            this.txt8.Size = new System.Drawing.Size(71, 68);
            this.txt8.TabIndex = 1;
            this.txt8.Text = "8";
            this.txt8.UseVisualStyleBackColor = true;
            this.txt8.Click += new System.EventHandler(this.TextBox_Numero);
            // 
            // txt9
            // 
            this.txt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt9.Location = new System.Drawing.Point(188, 152);
            this.txt9.Name = "txt9";
            this.txt9.Size = new System.Drawing.Size(71, 68);
            this.txt9.TabIndex = 1;
            this.txt9.Text = "9";
            this.txt9.UseVisualStyleBackColor = true;
            this.txt9.Click += new System.EventHandler(this.TextBox_Numero);
            // 
            // txtDivisao
            // 
            this.txtDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDivisao.Location = new System.Drawing.Point(276, 152);
            this.txtDivisao.Name = "txtDivisao";
            this.txtDivisao.Size = new System.Drawing.Size(71, 68);
            this.txtDivisao.TabIndex = 1;
            this.txtDivisao.Text = "/";
            this.txtDivisao.UseVisualStyleBackColor = true;
            this.txtDivisao.Click += new System.EventHandler(this.TextBox_Operador);
            // 
            // txt4
            // 
            this.txt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt4.Location = new System.Drawing.Point(12, 231);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(71, 68);
            this.txt4.TabIndex = 1;
            this.txt4.Text = "4";
            this.txt4.UseVisualStyleBackColor = true;
            this.txt4.Click += new System.EventHandler(this.TextBox_Numero);
            // 
            // txt5
            // 
            this.txt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt5.Location = new System.Drawing.Point(100, 231);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(71, 68);
            this.txt5.TabIndex = 1;
            this.txt5.Text = "5";
            this.txt5.UseVisualStyleBackColor = true;
            this.txt5.Click += new System.EventHandler(this.TextBox_Numero);
            // 
            // txt6
            // 
            this.txt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt6.Location = new System.Drawing.Point(188, 231);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(71, 68);
            this.txt6.TabIndex = 1;
            this.txt6.Text = "6";
            this.txt6.UseVisualStyleBackColor = true;
            this.txt6.Click += new System.EventHandler(this.TextBox_Numero);
            // 
            // txtMultiplicacao
            // 
            this.txtMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMultiplicacao.Location = new System.Drawing.Point(276, 231);
            this.txtMultiplicacao.Name = "txtMultiplicacao";
            this.txtMultiplicacao.Size = new System.Drawing.Size(71, 68);
            this.txtMultiplicacao.TabIndex = 1;
            this.txtMultiplicacao.Text = "*";
            this.txtMultiplicacao.UseVisualStyleBackColor = true;
            this.txtMultiplicacao.Click += new System.EventHandler(this.TextBox_Operador);
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(12, 311);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(71, 68);
            this.txt1.TabIndex = 1;
            this.txt1.Text = "1";
            this.txt1.UseVisualStyleBackColor = true;
            this.txt1.Click += new System.EventHandler(this.TextBox_Numero);
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.Location = new System.Drawing.Point(100, 311);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(71, 68);
            this.txt2.TabIndex = 1;
            this.txt2.Text = "2";
            this.txt2.UseVisualStyleBackColor = true;
            this.txt2.Click += new System.EventHandler(this.TextBox_Numero);
            // 
            // txt3
            // 
            this.txt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt3.Location = new System.Drawing.Point(188, 311);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(71, 68);
            this.txt3.TabIndex = 1;
            this.txt3.Text = "3";
            this.txt3.UseVisualStyleBackColor = true;
            this.txt3.Click += new System.EventHandler(this.TextBox_Numero);
            // 
            // txtAdicao
            // 
            this.txtAdicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdicao.Location = new System.Drawing.Point(276, 311);
            this.txtAdicao.Name = "txtAdicao";
            this.txtAdicao.Size = new System.Drawing.Size(71, 68);
            this.txtAdicao.TabIndex = 1;
            this.txtAdicao.Text = "+";
            this.txtAdicao.UseVisualStyleBackColor = true;
            this.txtAdicao.Click += new System.EventHandler(this.TextBox_Operador);
            // 
            // txt0
            // 
            this.txt0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt0.Location = new System.Drawing.Point(12, 391);
            this.txt0.Name = "txt0";
            this.txt0.Size = new System.Drawing.Size(71, 68);
            this.txt0.TabIndex = 1;
            this.txt0.Text = "0";
            this.txt0.UseVisualStyleBackColor = true;
            this.txt0.Click += new System.EventHandler(this.TextBox_Numero);
            // 
            // txtSubtracao
            // 
            this.txtSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtracao.Location = new System.Drawing.Point(276, 391);
            this.txtSubtracao.Name = "txtSubtracao";
            this.txtSubtracao.Size = new System.Drawing.Size(71, 68);
            this.txtSubtracao.TabIndex = 1;
            this.txtSubtracao.Text = "-";
            this.txtSubtracao.UseVisualStyleBackColor = true;
            this.txtSubtracao.Click += new System.EventHandler(this.TextBox_Operador);
            // 
            // txtIgual
            // 
            this.txtIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIgual.Location = new System.Drawing.Point(100, 392);
            this.txtIgual.Name = "txtIgual";
            this.txtIgual.Size = new System.Drawing.Size(159, 68);
            this.txtIgual.TabIndex = 1;
            this.txtIgual.Text = "=";
            this.txtIgual.UseVisualStyleBackColor = true;
            this.txtIgual.Click += new System.EventHandler(this.txtIgual_Click);
            // 
            // txtLimpar
            // 
            this.txtLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimpar.Location = new System.Drawing.Point(12, 71);
            this.txtLimpar.Name = "txtLimpar";
            this.txtLimpar.Size = new System.Drawing.Size(71, 68);
            this.txtLimpar.TabIndex = 1;
            this.txtLimpar.Text = "CE";
            this.txtLimpar.UseVisualStyleBackColor = true;
            this.txtLimpar.Click += new System.EventHandler(this.txtLimpar_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(361, 468);
            this.Controls.Add(this.txtDivisao);
            this.Controls.Add(this.txt9);
            this.Controls.Add(this.txt8);
            this.Controls.Add(this.txtMultiplicacao);
            this.Controls.Add(this.txtIgual);
            this.Controls.Add(this.txtSubtracao);
            this.Controls.Add(this.txtAdicao);
            this.Controls.Add(this.txt0);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txtLimpar);
            this.Controls.Add(this.txt7);
            this.Controls.Add(this.txtResultado);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCalculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button txt7;
        private System.Windows.Forms.Button txt8;
        private System.Windows.Forms.Button txt9;
        private System.Windows.Forms.Button txtDivisao;
        private System.Windows.Forms.Button txt4;
        private System.Windows.Forms.Button txt5;
        private System.Windows.Forms.Button txt6;
        private System.Windows.Forms.Button txtMultiplicacao;
        private System.Windows.Forms.Button txt1;
        private System.Windows.Forms.Button txt2;
        private System.Windows.Forms.Button txt3;
        private System.Windows.Forms.Button txtAdicao;
        private System.Windows.Forms.Button txt0;
        private System.Windows.Forms.Button txtSubtracao;
        private System.Windows.Forms.Button txtIgual;
        private System.Windows.Forms.Button txtLimpar;
    }
}