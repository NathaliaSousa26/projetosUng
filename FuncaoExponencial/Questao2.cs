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
    public partial class Questao2 : Fundo_Jogo
    { 
        public Questao2()
        {
            InitializeComponent();
        }
        public void ChamaQ3()
        {
            Questao3 newQ3 = new Questao3();
            newQ3.Show();
            Hide();
        }
        private void Questao2_Load(object sender, EventArgs e)
        {

        }

        private void btnOpcaoC_Click(object sender, EventArgs e)
        {
            btnOpcaoC.BackColor = Color.Green;
            MessageBox.Show("Resposta Correta");
            Respostas.Instance.respostaCerta++;
            ChamaQ3();
        }

        private void btnOpcaoA_Click_1(object sender, EventArgs e)
        {
            btnOpcaoA.BackColor = Color.Red;
            btnOpcaoC.BackColor = Color.Green;
            MessageBox.Show("Resposta Incorreta");
            ChamaQ3();
        }

        private void btnOpcaoB_Click_1(object sender, EventArgs e)
        {
            btnOpcaoB.BackColor = Color.Red;
            btnOpcaoC.BackColor = Color.Green;
            MessageBox.Show("Resposta Incorreta");
            ChamaQ3();
        }

        private void btnOpcaoD_Click(object sender, EventArgs e)
        {
            btnOpcaoD.BackColor = Color.Red;
            btnOpcaoC.BackColor = Color.Green;
            MessageBox.Show("Resposta Incorreta");
            ChamaQ3();

        }

        private void btnOpcaoE_Click(object sender, EventArgs e)
        {
            btnOpcaoE.BackColor = Color.Red;
            btnOpcaoC.BackColor = Color.Green;
            MessageBox.Show("Resposta Incorreta");
            ChamaQ3();
        }
    }
}
