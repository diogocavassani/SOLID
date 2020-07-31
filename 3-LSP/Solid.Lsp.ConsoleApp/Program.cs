using System;
using Solid.Lsp.Solucao;

namespace Solid.Lsp.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var retangulo = new Retangulo(10,5);
            var quarado = new Quadrado(10,10);

            Console.WriteLine("Retangulo");
            CalculoArea.ObterArea(retangulo);
            Console.WriteLine("-----------------");
            Console.WriteLine("Quadrado");
            CalculoArea.ObterArea(quarado);

        }
    }
}
