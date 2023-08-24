using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZorebasCompanny
{

    public class Caixa
    {
       private double saldo;

        
        public void clientecompra(double valor) { this.saldo += valor; }
        public double trocoparaoclient(double valordado, double valordacompra) {
            double trouco = valordado - valordacompra;
            this.saldo += valordacompra;
            return trouco; 
        }
        public void SetSaldo(double saldo)
        {
            this.saldo = saldo;
        }

    }
}
