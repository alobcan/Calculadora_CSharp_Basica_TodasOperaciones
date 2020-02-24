using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int res=0;
            Console.WriteLine("Ingrese la operacion");
            string input = Console.ReadLine();
            if (input.Contains('+'))
            {
                var digitos = input.Split('+');
                res = int.Parse(digitos[0]) + int.Parse(digitos[1]);
            }
            else if (input.Contains('-'))
            {
                var digitos = input.Split('-');
                res = int.Parse(digitos[0]) - int.Parse(digitos[1]);
            }
            else if (input.Contains('*'))
            {
                var digitos = input.Split('*');
                res = int.Parse(digitos[0]) * int.Parse(digitos[1]);
            }
            else if (input.Contains('/'))
            {
                var digitos = input.Split('/');
                res = int.Parse(digitos[0]) / int.Parse(digitos[1]);
            }
            else Console.WriteLine("Operacion invalida");

            Console.WriteLine("El resultado es: " + res);
            Console.ReadKey();
        }
    }
}
