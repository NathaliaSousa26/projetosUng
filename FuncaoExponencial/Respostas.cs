using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncaoExponencial
{
    public sealed class Respostas
    {

        private static volatile Respostas instance;
        private static object sync = new Object();

        private Respostas() { }

        public static Respostas Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (sync)
                    {
                        if (instance == null)
                        {
                            instance = new Respostas();
                        }
                    }
                }
                return instance;
            }

        }

        /// <summary>
        /// Propriedade para o ID do usuario
        /// </summary>
        public int respostaCerta { get; set; }

    }
}
