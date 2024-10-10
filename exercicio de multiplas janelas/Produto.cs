using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_de_multiplas_janelas
{
    public class Produto
    {
        private static int _contadorId = 0;
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Fabricante { get; set; }
        public decimal PrecoCompra { get; set; }
        public decimal PrecoVenda { get; set; }

        public Produto()
        {
            Id = ++_contadorId; // Incrementa o contador e atribui ao Id
        }
    }
}
 