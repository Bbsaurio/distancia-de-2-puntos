using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace distancia_de_2_puntos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("inserta el valor de la coordenada de x2");
            double x2=  double.Parse(Console.ReadLine());
            System.Console.WriteLine("inserta el valor de la coordenada de x1");
            double x1= double.Parse(Console.ReadLine());
            double Z=x2 - x1;
            double R1 = Math.Pow(Z,2);
            System.Console.WriteLine("inserte el valor de la coordenada de y2");
            double Y2= double.Parse(Console.ReadLine());
            System.Console.WriteLine("ingrese el valor de la coordenada de y1");
            double Y1=double.Parse(Console.ReadLine());
            double W=Y1 - Y2;
            double R2= Math.Pow(W,2);
            double D= R1 + R2;  
            double S=Math.Sqrt(D);
            System.Console.WriteLine("El resultado es:"+S);
            Console.ReadKey();
        }
    }
}
