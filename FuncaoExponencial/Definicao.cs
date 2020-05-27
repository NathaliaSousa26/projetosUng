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
    public partial class Definicao : form_Fundo
    {
        public Definicao()
        {
            InitializeComponent();
        }

        private void Definicao_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Introducao newIntroducao = new Introducao();
            newIntroducao.Show();
            Hide();
        }

        private void btn_prox_Click(object sender, EventArgs e)
        {
            Graficos newGraficos = new Graficos();
            newGraficos.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
