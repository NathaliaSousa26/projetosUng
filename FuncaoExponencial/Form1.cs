using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuncaoExponencial
{
    public partial class form_menu : Form
    {
        public form_menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_ler_Click(object sender, EventArgs e)
        { 
            IniciarAula newIniciar = new IniciarAula();
            newIniciar.Show();
            Hide();
        }

        private void btn_jogar_Click(object sender, EventArgs e)
        {
            InicioJogo newJogo = new InicioJogo();
            newJogo.Show();
            Hide();
        }
    }
}
