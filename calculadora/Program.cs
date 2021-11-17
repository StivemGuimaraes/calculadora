using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            numeros p = new numeros();
            while (p.aux == 1)
            {
                Console.WriteLine("digite 1 para adiçao");
                Console.WriteLine("digite 2 para substração");
                Console.WriteLine("digite 3 para multiplicação");
                Console.WriteLine("digite 4 para divisão");
                p.cal = int.Parse(Console.ReadLine());
                switch (p.cal)
                {
                    case 1:
                        Console.WriteLine("digite 1 numero");
                        p.num1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("digite 2 numero");
                        p.num2 = float.Parse(Console.ReadLine());
                        p.total = p.num1 + p.num2;
                        Console.WriteLine("o total é " + p.total);
                        break;
                    case 2:
                        Console.WriteLine("digite 1 numero");
                        p.num1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("digite 2 numero");
                        p.num2 = float.Parse(Console.ReadLine());
                        p.total = p.num1 - p.num2;
                        Console.WriteLine("o total é " + p.total);
                        break;
                    case 3:
                        Console.WriteLine("digite 1 numero");
                        p.num1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("digite 2 numero");
                        p.num2 = float.Parse(Console.ReadLine());
                        p.total = p.num1 * p.num2;
                        Console.WriteLine("o total é " + p.total);
                        break;
                    case 4:
                        Console.WriteLine("digite 1 numero");
                        p.num1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("digite 2 numero");
                        p.num2 = float.Parse(Console.ReadLine());
                        if (p.num1 == 0 || p.num2 == 0)
                        {
                            Console.WriteLine("o numero que você digitou não pode ser 0");
                        }
                        else
                        {
                            p.total = p.num1 * p.num2;
                            Console.WriteLine("o total é " + p.total);
                        }
                        break;


                }
                Console.WriteLine("digite 1 para continuar ou digite 0 para sair");
                p.aux = int.Parse(Console.ReadLine());
            }
            Console.ReadKey();
            Console.WriteLine("tchau");
        }
    }
}
