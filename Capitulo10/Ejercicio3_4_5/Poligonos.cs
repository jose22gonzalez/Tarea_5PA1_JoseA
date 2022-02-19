using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_5PA1_JoseA.Capitulo10.Ejercicio3_4_5
{
    public class Poligonos
    {
        public int Lado1 { get; set; }
        public int Lado2 { get; set; }
        public int Lado3 { get; set; }


        public Poligonos(int lado1, int lado2, int lado3)
        {
            Lado1 = lado1;
            Lado2 = lado2;
            Lado3 = lado3;
        }

        public bool ValidarValores(int lado1, int lado2, int lado3)
        {
            bool paso = false;
           if(lado1 > 0 && lado2 > 0 && lado3 > 0)
           {
               paso = true;
           }else{
               paso = false;
           }

           return paso;
        }

        public override string ToString()
        {
            int perimetro = Lado1 + Lado2 + Lado3;
            return perimetro.ToString();
        }
    }

}