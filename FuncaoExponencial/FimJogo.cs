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
    public partial class FimJogo : Fundo_Jogo
    {
        public FimJogo()
        {
            InitializeComponent();
        }

        private string texto;
        private void FimJogo_Load(object sender, EventArgs e)
        {
            double acertos = Respostas.Instance.respostaCerta;

            lblAcertos.Text = ($"Voce teve: \n {acertos} acertos");

            var erros = 5 - Respostas.Instance.respostaCerta;
            lblErros.Text = ($"E {erros} erros");

            var porcentagem = Porcentagem(acertos);

            if (porcentagem >= 70)
            {
                texto = $"Parabéns, resultado: \n {porcentagem.ToString()}% de aproveitamento";
            }
            else if (porcentagem == 70)
            {
                texto = $"Na média, resultado: \n {porcentagem.ToString()}% de aproveitamento";
            }
            else if (porcentagem <= 70)
            {
                texto = $"Estude mais, resultado: \n {porcentagem.ToString()}% de aproveitamento";
            }

            lblPorcentagem.Text = texto;
        }

        private void lblAcertos_Click(object sender, EventArgs e)
        {
            
        }
        private void lblErros_Click(object sender, EventArgs e)
        {
            
        }
        private double Porcentagem(double acertos)
        {
            return (acertos / 5) * 100;
        }
    }
}
