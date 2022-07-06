using System;
using System.Globalization;

namespace projetosdeclass {
    public class Aluno {
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double Notafinal() {
            return Nota1 + Nota2 + Nota3;
        }
        public bool Aprovado() {
            if (Notafinal() >= 60) {

                return true;
            }
            else {
                return false;
            }
        }
        public double Notarest() {
            if (Aprovado()) {
                return 0.0;
            }
            else {
                return 60.0 - Notafinal();
            }
        }
        override public string ToString() {
            return "Nota final: " + Notafinal().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
