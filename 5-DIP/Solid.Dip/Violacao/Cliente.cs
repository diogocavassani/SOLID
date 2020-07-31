using System;
using Solid.Dip.Solucao;

namespace Solid.Dip.Violacao
{
    public class Cliente
    {
         public int ClientId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool Validar()
        {
            return Email.ValidarEmail() && Cpf.ValidarCpf();
        }
    }
}
