using System;
using System.Data;
using System.Data.SqlClient;
using Solid.Dip.Solucao.Interface;

namespace Solid.Dip.Solucao
{
    public class ClienteRepository : IClienteRepository
    {
        public void Adicionar(Cliente cliente)
        {
             using (var con = new SqlConnection())
            {
                var cmd = new SqlCommand();

                con.ConnectionString = "Minhaconexao";
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO CLIENTE (NAME, EMAIL, CPF, DATACADASTRO) VALUES (@nome, @email, @cpf, @datacadastro)";

                
                cmd.Parameters.AddWithValue("nome", cliente.Nome);
                cmd.Parameters.AddWithValue("email", cliente.Email);
                cmd.Parameters.AddWithValue("cpf", cliente.Cpf);
                cmd.Parameters.AddWithValue("dataCadastro", cliente.DataCadastro);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
