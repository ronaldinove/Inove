/*using System;
using System.Collections.Generic;
using MySqlConnector;

namespace I9site.Models
{

    public class OrcamentosRepository
    {
        //BANCO DE DADOS

        private const string DadosConexao = "Database= inove; Data Source=localhost; User Id=root;";

        public void TestarConexao(){
            MySqlConnection Conexao = new MySqlConnection (DadosConexao);
            Conexao.Open();
            Console.WriteLine("Banco de dados funcionando!");
            Conexao.Close();
        }

    }

}*/