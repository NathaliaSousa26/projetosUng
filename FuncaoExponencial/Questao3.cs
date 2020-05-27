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
    public partial class Questao3 : Fundo_Jogo
    {
        public Questao3()
        {
            InitializeComponent();
        }
        public void ChamaQ4()
        {
            Questao4 newQ4 = new Questao4();
            newQ4.Show();
            Hide();
        }

        private void Questao3_Load(object sender, EventArgs e)
        {

        }

        private void btnOpcaoA_Click_1(object sender, EventArgs e)
        {
            btnOpcaoA.BackColor = Color.Red;
            btnOpcaoD.BackColor = Color.Green;
            MessageBox.Show("Resposta Incorreta");
            ChamaQ4();
        }

        private void btnOpcaoE_Click(object sender, EventArgs e)
        {
            btnOpcaoE.BackColor = Color.Red;
            btnOpcaoD.BackColor = Color.Green;
            MessageBox.Show("Resposta Incorreta");
            ChamaQ4();
        }

        private void btnOpcaoB_Click_1(object sender, EventArgs e)
        {
            btnOpcaoB.BackColor = Color.Red;
            btnOpcaoD.BackColor = Color.Green;
            MessageBox.Show("Resposta Incorreta");
            ChamaQ4();
        }

        private void btnOpcaoC_Click(object sender, EventArgs e)
        {
            btnOpcaoC.BackColor = Color.Red;
            btnOpcaoD.BackColor = Color.Green;
            MessageBox.Show("Resposta Incorreta");
            ChamaQ4();
        }

        private void btnOpcaoD_Click(object sender, EventArgs e)
        {
            btnOpcaoD.BackColor = Color.Green;
            MessageBox.Show("Resposta Correta");
            Respostas.Instance.respostaCerta++;
            ChamaQ4();
        }
    }
}
