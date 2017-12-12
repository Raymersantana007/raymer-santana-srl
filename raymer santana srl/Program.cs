using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raymer_santana_srl
{
    class Program
    {
        static void Main(string[] args)


 
        {

            Console.WriteLine(" Nombre: Raymer Santana Luciano      -------->16-SIIT-1-083");
            Console.WriteLine(" Nombre: Jhon torres lorenzo----------------->16-SIIT-1-049");
            Console.WriteLine(" Nombre: Richardson sainte     -------------->16-SIIT-1-006");



            int nota1, nota2, nota3, nota4, suma, promedio;
            Console.WriteLine("Ingrese la primera nota:");
            nota1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota:");
            nota2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la tercera nota:");
            nota3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cuarta nota:");
            nota4 = Convert.ToInt32(Console.ReadLine());
            suma = nota1 + nota2 + nota3 + nota4;
            promedio = suma / 4;
           
            
            Console.WriteLine("El total de la nota es: {0} y el promedio es:{1}", suma, promedio);

            // blucle for de pontencia
            int k = 1;

            Console.WriteLine("intruduce la potencia deseada");
            int.TryParse(Console.ReadLine(), out k);

            for (int n = 1; n <= 20; n++)

            {
                double h = Math.Pow(n, k);
                Console.WriteLine(n + " ^ " + k + " = " + h);


            }


            Console.ReadKey();
        }
    }
}
