using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace Solid.Srp.Violacao
{
    public class Cliente
    {
        public int ClientId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataCadastro { get; set; }

        public string AdicionarCliente(string assuntoEmail, string mensagemEmail)
        {
            if (!Email.Contains("@"))
                return "Cliente com e-mail inválido";
            if (Cpf.Length != 11)
                return "Cliente com Cpf Inválido";

            using (var com = new SqlConnection())
            {
                var cmd = new SqlCommand();

                com.ConnectionString = "MinhaConectionString";
                cmd.Connection = com;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CLIENTE (NAME, EMAIL, CPF, DATACADASTRO) VALUES (@nome, @email, @cpf, @datacadastro)";

                cmd.Parameters.AddWithValue("nome", Nome);
                cmd.Parameters.AddWithValue("email", Nome);
                cmd.Parameters.AddWithValue("cpf", Nome);
                cmd.Parameters.AddWithValue("dataCadastro", Nome);

                com.Open();
                cmd.ExecuteNonQuery();
            }

            var smtpClient = new SmtpClient
            {
            Port= 25,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Host = "smtp.google.com"
        };

        smtpClient.Send(new MailMessage("teste@teste.com", Email)
            {
                Subject = assuntoEmail,
                Body = mensagemEmail
            });
            return "Cliente cadastrado com sucesso!";
        }
    }
}