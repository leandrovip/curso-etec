namespace Exercicio01
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exercíciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parOuÍmparToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.áreaTrianguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarMenorNumeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercíciosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exercíciosToolStripMenuItem
            // 
            this.exercíciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parOuÍmparToolStripMenuItem,
            this.médiaToolStripMenuItem,
            this.áreaTrianguloToolStripMenuItem,
            this.mostrarMenorNumeroToolStripMenuItem});
            this.exercíciosToolStripMenuItem.Name = "exercíciosToolStripMenuItem";
            this.exercíciosToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.exercíciosToolStripMenuItem.Text = "Exercícios";
            // 
            // parOuÍmparToolStripMenuItem
            // 
            this.parOuÍmparToolStripMenuItem.Name = "parOuÍmparToolStripMenuItem";
            this.parOuÍmparToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.parOuÍmparToolStripMenuItem.Text = "Par ou Ímpar";
            this.parOuÍmparToolStripMenuItem.Click += new System.EventHandler(this.parOuÍmparToolStripMenuItem_Click);
            // 
            // médiaToolStripMenuItem
            // 
            this.médiaToolStripMenuItem.Name = "médiaToolStripMenuItem";
            this.médiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.médiaToolStripMenuItem.Text = "Média";
            this.médiaToolStripMenuItem.Click += new System.EventHandler(this.médiaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // áreaTrianguloToolStripMenuItem
            // 
            this.áreaTrianguloToolStripMenuItem.Name = "áreaTrianguloToolStripMenuItem";
            this.áreaTrianguloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.áreaTrianguloToolStripMenuItem.Text = "Área Triangulo";
            this.áreaTrianguloToolStripMenuItem.Click += new System.EventHandler(this.áreaTrianguloToolStripMenuItem_Click);
            // 
            // mostrarMenorNumeroToolStripMenuItem
            // 
            this.mostrarMenorNumeroToolStripMenuItem.Name = "mostrarMenorNumeroToolStripMenuItem";
            this.mostrarMenorNumeroToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.mostrarMenorNumeroToolStripMenuItem.Text = "Mostrar Menor Numero";
            this.mostrarMenorNumeroToolStripMenuItem.Click += new System.EventHandler(this.mostrarMenorNumeroToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Tela Inicial";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exercíciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parOuÍmparToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem áreaTrianguloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarMenorNumeroToolStripMenuItem;
    }
}