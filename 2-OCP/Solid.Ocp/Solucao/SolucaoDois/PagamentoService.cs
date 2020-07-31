using System;

namespace Solid.Ocp.Solucao.SolucaoDois
{
    public class PagamentoService
    {
        public void Pagar()
        {
            var pagamento = new Pagamento();
            pagamento.Pagar(200);

            var pagamentoCartaoCredito = new PagamentoCartaoCredito();
            pagamentoCartaoCredito.Pagar(200);

        }
    }
}
