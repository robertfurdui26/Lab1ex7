using System;

namespace Lab1ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ex7
           Scrieti un program care va verifica daca un numar citit de la tastatura este par sau
           impar
            In cazul in care numarul este par, programul va afisa “par” iar in caz contrar, “impar”.
            Google :even and odd number*/

            Console.WriteLine("Introduceti un numar: ");
            int numar = int.Parse(Console.ReadLine());

            if(numar % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }
        }
    }
}