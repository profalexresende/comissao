using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comissaoVendedor
{
    class Vendedor
    {
        public string nome { get; set; }
        public double salarioBase { get; set; }

        public Vendedor()
        {
            this.nome = "";
            this.salarioBase = 0;
        }

        public Vendedor(string nome, double salario)
        {
            this.nome = nome;
            this.salarioBase = salario;
        }

        public double calculoComissao(double valorVendido)
        {
            return valorVendido * 0.1;
        }
    }
}
