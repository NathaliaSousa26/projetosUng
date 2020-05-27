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
    public partial class Graficos : form_Fundo
    {
        public Graficos()
        {
            InitializeComponent();
        }

        private void Graficos_Load(object sender, EventArgs e)
        {

        }

        private void btn_prox_Click(object sender, EventArgs e)
        {
            Conclusao newConclusao = new Conclusao();
            newConclusao.Show();
            Hide();
        }

        private void btn_ant_Click(object sender, EventArgs e)
        {
            Definicao newDefinicao = new Definicao();
            newDefinicao.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl1.Visible = true;
            lbl2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl1.Visible = false;
            lbl2.Visible = true;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbl1.Visible = false;
            lbl2.Visible = false;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lbl1.Visible = false;
            lbl2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
        }
    }
}
