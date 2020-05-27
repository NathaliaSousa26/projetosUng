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
    public partial class Conclusao : form_Fundo
    {
        public Conclusao()
        {
            InitializeComponent();
        }

        private void Conclusao_Load(object sender, EventArgs e)
        {

        }

        private void btn_ant_Click(object sender, EventArgs e)
        {
            Graficos newGrafico = new Graficos();
            newGrafico.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InicioJogo newJogo = new InicioJogo();
            newJogo.Show();
            Hide();
        }
    }
}
