using System;

namespace Solid.Ocp.Violacao.ViolacaoUm
{
    public class DebitoConta
    {
        public void Debitar(decimal valor, string conta, TipoContaEnum tipoConta)
        {
            if(tipoConta == TipoContaEnum.Corrente)
            {

            }

            if(tipoConta == TipoContaEnum.Poupanca)
            {
                
            }
        }
    }
}
