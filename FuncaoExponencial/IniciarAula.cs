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
    public partial class IniciarAula : form_Fundo
    {
        public IniciarAula()
        {
            InitializeComponent();
        }

        private void IniciarAula_Load(object sender, EventArgs e)
        {

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Introducao newIntroducao = new Introducao();
            newIntroducao.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_menu newMenu = new form_menu();
            newMenu.Show();
            Hide();
        }
    }
}
