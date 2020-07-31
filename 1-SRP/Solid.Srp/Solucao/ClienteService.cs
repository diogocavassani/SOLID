using System;

namespace Solid.Srp.Solucao
{
    public class ClienteService
    {
        public string Adicionar(Cliente cliente)
        {
            if(cliente.Validar())
                return "Cliente inválido";

            var clienteRepository = new ClienteRepository();
            clienteRepository.Adicionar(cliente);

            var emailService = new EmailService();
            emailService.Enviar(cliente.Email,"Bem vindo", "Você foi cadastrado com sucesso");

            return "Cliente cadastrado com sucesso";
        }
    }
}
