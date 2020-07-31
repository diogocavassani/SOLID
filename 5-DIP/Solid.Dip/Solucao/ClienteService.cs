using System;
using Solid.Dip.Solucao.Interface;

namespace Solid.Dip.Solucao
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IEmailService _emailService;
        public ClienteService(IClienteRepository clienteRepository, IEmailService emailService)
        {
            _clienteRepository = clienteRepository;
            _emailService = emailService;
        }
        public string Adicionar(Cliente cliente)
        {
            if(cliente.Validar())
                return "Cliente inválido";

            _clienteRepository.Adicionar(cliente);
            _emailService.Enviar(cliente.Email,"Bem vindo", "Você foi cadastrado com sucesso");

            return "Cliente cadastrado com sucesso";
        }
    }

    public class Main
    {
        private readonly IClienteService _clienteService;
        public Main(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }
        public void AdicionarCliente()
        {
            var clienteService = new ClienteService(new ClienteRepository(), new EmailService());
            clienteService.Adicionar(new Cliente());
        }
    }
}
