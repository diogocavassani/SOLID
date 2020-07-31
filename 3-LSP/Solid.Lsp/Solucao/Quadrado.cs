using System;

namespace Solid.Lsp.Solucao
{
    public class Quadrado : Paralelogramo
    {
        public Quadrado(int altura, int largura) : base(altura, largura)
        {
            if (altura != largura)
                throw new Exception ("A altura do quadrado deve ser igual a largura");
        }
    }
}
