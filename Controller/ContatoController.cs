using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using ProjetoAgenda.VariableGlobal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controller
{
    internal class ContatoController
    {
        public bool AddContato(string nome)
        {
            MySqlConnection conexao = null;

            try
            {
                //cria a conexao, estou utilizando a classe ConexaoDB q esta dentro da pasta DATA
                conexao = ConexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);

                //comando sql que sera executado
                string sql = "INSERT INTO tbcontatos (nome) VALUES (@nome);";

                //abri a conexao com o banco
                conexao.Open();

                //esse cara é o responsavel por executar o comando sql
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //estou trocando o valor dos @ pelas informações que serao cadastradas
                //essas informações vieram dos parametros da função
                comando.Parameters.AddWithValue("@nome", nome);


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
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao cadastrar categoria: {erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            finally
            {
                conexao.Close();
            }
        }



    }
}
