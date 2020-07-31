using System;
using System.Net.Mail;

namespace Solid.Srp.Solucao
{
    public class EmailService
    {
        public void Enviar(string para, string assunto, string mensagemEmail)
        {
            var smptClient = new SmtpClient
            {
                Port = 75,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            smptClient.Send(new MailMessage("teste@teste.com", para)
            {
                Subject = assunto,
                Body = mensagemEmail
            });
        }
    }
}
