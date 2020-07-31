using System;

namespace Solid.Lsp.Violacao
{
    public class CalculoArea
    {
        public static void ObterArea(Retangulo retangulo)
        {
            Console.WriteLine($"{retangulo.Altura} x {retangulo.Largura}");
            Console.WriteLine($"Resultado = {retangulo.Area}");
        }
    }
}
