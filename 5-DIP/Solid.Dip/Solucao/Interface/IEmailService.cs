using System;

namespace Solid.Dip.Solucao.Interface
{
    public interface IEmailService
    {
        void Enviar(string para, string assunto, string mensagemEmail);
    }
}
