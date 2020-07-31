using System;
using System.Net.Mail;
using Solid.Dip.Solucao.Interface;

namespace Solid.Dip.Solucao
{
    public class EmailService : IEmailService
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
