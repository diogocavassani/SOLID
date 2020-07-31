using System;

namespace Solid.Lsp.Violacao
{
    public class Retangulo
    {
        public virtual int Altura { get; set; }
        public virtual int Largura { get; set; }
        public int  Area { get{return Altura * Largura;} }
    }
}
