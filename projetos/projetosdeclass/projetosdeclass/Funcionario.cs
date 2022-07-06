using System;
using System.Globalization;

namespace projetosdeclass {
    public class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double imposto;
        


        public double SalarioLiquido() {
            return SalarioBruto - imposto;
        }
        public double AumentarSalario(double porcentagem) {
           return SalarioBruto += (SalarioBruto * porcentagem / 100.0); 
           

        }


        override public string ToString() {
            return "Funcionário: " + Nome +
                ", " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

