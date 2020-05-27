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
    public partial class form_Fundo : Form
    {
        public form_Fundo()
        {
            InitializeComponent();
        }

        private void unidade1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exemplosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conclusao newConclusao = new Conclusao();
            newConclusao.Show();
            Hide();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void form_Fundo_Load(object sender, EventArgs e)
        {

        }

        private void introduçaoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void click_sair(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void introduçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Introducao newIntroducao = new Introducao();
            newIntroducao.Show();
            Hide();
        }

        private void definiçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Definicao newDefinicao = new Definicao();
            newDefinicao.Show();
            Hide();
        }

        private void graficosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graficos newGraficos = new Graficos();
            newGraficos.Show();
            Hide();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox3_Click(object sender, EventArgs e)
        {
            form_menu newMenu = new form_menu();
            newMenu.Show();
            Hide();
        }
    }
}
