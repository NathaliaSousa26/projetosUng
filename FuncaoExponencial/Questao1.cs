using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuncaoExponencial
{
    public partial class Questao1 : Fundo_Jogo
    {
        public Questao1()
        {
            InitializeComponent();
        }
        public void ChamaQ2()
        {
             Questao2 newQ2 = new Questao2();
             newQ2.Show();
             Hide();
        }
        //public int respostaCorreta = 0;

        private void Questao1_Load(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            btnOpcaoE.BackColor = Color.Green;
            MessageBox.Show("Resposta Correta");
            //respostaCorreta++;
            Respostas.Instance.respostaCerta = 1;
            ChamaQ2();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btnOpcaoA.BackColor = Color.Red;
            btnOpcaoE.BackColor = Color.Green;
            MessageBox.Show("Resposta Incorreta");
            ChamaQ2();
        }

        private void btnOpcaoB_Click_1(object sender, EventArgs e)
        {
            btnOpcaoB.BackColor = Color.Red;
            btnOpcaoE.BackColor = Color.Green;
            MessageBox.Show("Resposta Incorreta");
            ChamaQ2();
        }

        private void btnOpcaoC_Click(object sender, EventArgs e)
        {
            btnOpcaoC.BackColor = Color.Red;
            btnOpcaoE.BackColor = Color.Green;
            MessageBox.Show("Resposta Incorreta");
            ChamaQ2();
        }

        private void btnOpcaoD_Click(object sender, EventArgs e)
        {
            btnOpcaoD.BackColor = Color.Red;
            btnOpcaoE.BackColor = Color.Green;
            MessageBox.Show("Resposta Incorreta");
            ChamaQ2();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
