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
    public partial class Questao4 : Fundo_Jogo
    {

        public Questao4()
        {
            InitializeComponent();
        }
        public void ChamaQ5()
        {
            Questao5 newQ5 = new Questao5();
            newQ5.Show();
            Hide();
        }
        private void Questao4_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnOpcaoA_Click_1(object sender, EventArgs e)
        {
            btnOpcaoA.BackColor = Color.Green;
            MessageBox.Show("Resposta Correta");
            Respostas.Instance.respostaCerta++;
            ChamaQ5();
        }

        private void btnOpcaoB_Click_1(object sender, EventArgs e)
        {
            btnOpcaoA.BackColor = Color.Green;
            btnOpcaoB.BackColor = Color.Red;
            MessageBox.Show("Resposta Incorreta");
            ChamaQ5();
        }

        private void btnOpcaoC_Click(object sender, EventArgs e)
        {
            btnOpcaoA.BackColor = Color.Green;
            btnOpcaoC.BackColor = Color.Red;
            MessageBox.Show("Resposta Incorreta");
            ChamaQ5();
        }

        private void btnOpcaoD_Click(object sender, EventArgs e)
        {
            btnOpcaoA.BackColor = Color.Green;
            btnOpcaoD.BackColor = Color.Red;
            MessageBox.Show("Resposta Incorreta");
            ChamaQ5();
        }

        private void btnOpcaoE_Click(object sender, EventArgs e)
        {
            btnOpcaoA.BackColor = Color.Green;
            btnOpcaoE.BackColor = Color.Red;
            MessageBox.Show("Resposta Incorreta");
            ChamaQ5();
        }
    }
}
