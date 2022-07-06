using System;
using System.Globalization;

namespace projetosdeclass {
    public class Retengulo {
        public double Largura;
        public double Altura;
       

        public double Area() {
            return Largura * Altura;
        }
        public double Perimetro() {
            return (Largura + Altura) * 2;
        }
        public double Diagonal() {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
             

        }
        override public string ToString() {
            return "A largura é: " + Largura
                + " A altura é: " + Altura
                + " A area do retângulo é: "
                + Area().ToString("F2", CultureInfo.InvariantCulture)
                + " O perimetro é: "
                + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + " Diagonal é: "
                + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
