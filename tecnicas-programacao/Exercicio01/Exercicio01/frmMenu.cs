﻿using System;
using System.Windows.Forms;

namespace Exercicio01
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void parOuÍmparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmExercicio01();
            form.ShowDialog();
        }

        private void médiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmExercicio02();
            form.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void áreaTrianguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmExercicio03();
            form.ShowDialog();
        }

        private void mostrarMenorNumeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmExercicio04();
            form.ShowDialog();
        }

        private void categoriaNadadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmExercicio05();
            form.ShowDialog();
        }
    }
}