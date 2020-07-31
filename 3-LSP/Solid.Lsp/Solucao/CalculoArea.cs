using System;

namespace Solid.Lsp.Solucao
{
    public class CalculoArea
    {
        public static void ObterArea(Paralelogramo paralelogramo)
        {
            Console.WriteLine($"{paralelogramo.Altura} x {paralelogramo.Largura}");
            Console.WriteLine($"Resultado = {paralelogramo.Area}");
        }
    }
}
