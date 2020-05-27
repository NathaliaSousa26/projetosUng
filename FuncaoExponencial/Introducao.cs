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
    public partial class Introducao : form_Fundo
    {
        public Introducao()
        {
            InitializeComponent();
        }

        private void Introducao_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IniciarAula newIniciar = new IniciarAula();
            newIniciar.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Definicao newDefinicao = new Definicao();
            newDefinicao.Show();
            Hide();
        }
    }
}
