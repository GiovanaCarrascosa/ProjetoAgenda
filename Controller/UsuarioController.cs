﻿using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controller
{
    internal class UsuarioController
    {
        public bool AddUsuario(string nome, string usuario, string telefone, string senha)
        {
            //cria a conexao, estou utilzando a classe ConexaoDB q esta dentro da pasta DATA
            MySqlConnection conexao = ConexaoDB.CriarConexao();

            //comando sql que sera executado
            string sql = "INSERT INTO tbUsuarios (nome, usuario, telefone, senha) VALUES (@nome, @usuario, @telefone, @senha);";

            //abri a conexao com o banco
            conexao.Open();

            //esse cara é o responsavel por executar o comando sql
            MySqlCommand comando = new MySqlCommand(sql, conexao);

            //estou trocando o valor dos @ pelas informações que serao cadastradas
            //essas informações vieram dos parametros da função
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@telefone", telefone);
            comando.Parameters.AddWithValue("@senha", senha);

            //executando no banco de dados
            int linhasAfetadas = comando.ExecuteNonQuery();

            conexao.Close();

            if (linhasAfetadas > 0) 
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
