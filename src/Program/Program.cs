using System;

namespace Compuertas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<AND> Compuertas = new List<AND>();
            AND and1 = new AND ("And-1", false);
            Compuertas = and1.AgregarMetodo(and1.Nombre, and1.Valor, Compuertas);
            Console.WriteLine(Compuertas[0].Nombre + " - " + Compuertas[0].Valor);
            Compuertas = and1.AgregarMetodo(and1.Nombre, true, Compuertas);
            Console.WriteLine(Compuertas[0].Nombre + " - " + Compuertas[0].Valor);
        }
    }
}