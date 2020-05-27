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
    public partial class Questao5 : Fundo_Jogo
    {
        public Questao5()
        {
            InitializeComponent();
        }
        public void ChamaFim()
        {
            FimJogo newFim = new FimJogo();
            newFim.Show();
            Hide();
        }
        private void Questao5_Load(object sender, EventArgs e)
        {

        }

        private void btnOpcaoB_Click_1(object sender, EventArgs e)
        {
            btnOpcaoB.BackColor = Color.Green;
            MessageBox.Show("Resposta Correta");
            Respostas.Instance.respostaCerta++;
            ChamaFim();
        }

        private void btnOpcaoA_Click_1(object sender, EventArgs e)
        {
            btnOpcaoB.BackColor = Color.Green;
            btnOpcaoA.BackColor = Color.Red;
            MessageBox.Show("Resposta Incorreta");
            ChamaFim();
        }

        private void btnOpcaoC_Click(object sender, EventArgs e)
        {
            btnOpcaoB.BackColor = Color.Green;
            btnOpcaoC.BackColor = Color.Red;
            MessageBox.Show("Resposta Incorreta");
            ChamaFim();
        }

        private void btnOpcaoD_Click(object sender, EventArgs e)
        {
            btnOpcaoB.BackColor = Color.Green;
            btnOpcaoD.BackColor = Color.Red;
            MessageBox.Show("Resposta Incorreta");
            ChamaFim();
        }
    }
}
