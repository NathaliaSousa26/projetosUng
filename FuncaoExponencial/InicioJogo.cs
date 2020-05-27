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
    public partial class InicioJogo : Fundo_Jogo
    {
        public InicioJogo()
        {
            InitializeComponent();
        }

        private void InicioJogo_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Questao1 newQ1 = new Questao1();
            newQ1.Show();
            Hide();
        }
    }
}
