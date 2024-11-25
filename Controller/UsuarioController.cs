using MySql.Data.MySqlClient;
using Mysqlx.Expr;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controller
{
    internal class UsuarioController
    {
        public bool AddUsuario(string nome, string usuario, string telefone, string senha)
        {

            try
            {
                //cria a conexao, estou utilzando a classe ConexaoDB q esta dentro da pasta DATA
                MySqlConnection conexao = ConexaoDB.CriarConexao();

                //comando sql que sera executado
                string sql = $@"INSERT INTO tbUsuarios (nome, usuario, telefone, senha) VALUES (@nome, @usuario, @telefone, @senha); 
                create user '{@usuario}'@'%' identified by '{@senha}'; grant select, insert on *.* to '{usuario}'@'%';";

               

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
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao cadastrar: {erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }



        }
        public bool ValidarLogin(string usuario, string senha)
        {

            try
            {
                MySqlConnection conexao = ConexaoDB.CriarConexao();

                string sql = @" select * from tbusuarios
                                    where usuario = @usuario
                                    and binary senha = @senha";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@senha", senha);

                MySqlDataReader resultado = comando.ExecuteReader();

                if (resultado.Read())
                {
                    conexao.Close();
                    return true;
                }
                else
                {
                    conexao.Close();
                    return false;
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao verificiar usuario.");
                return false;
            }

        }

        public DataTable GetUsuario()
        {
            //criando uma conexao vazia
            MySqlConnection conexao = null;

            try
            {
                //inserindo a conexao usando a conexaodb q eu ja havia criado
                conexao = ConexaoDB.CriarConexao();

                //montei o select que retorna todas as categorias
                string sql = @"select nome AS 'Nome', usuario AS 'Usuário' from tbusuarios;";

                //abri a conexao
                conexao.Open();

                //criei um adaptador
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexao);

                //criei uma tabela vazia
                DataTable tabela = new DataTable();

                //pedindo para o adaptador preencher a tabela
                adaptador.Fill(tabela);

                //retorno a tabela preenchida
                return tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"ERRO AO RECUPERAR CATEGORIAS: {erro.Message}");
                return new DataTable();
            }

            finally
            {
                conexao.Close();
            }

        }
        public bool DltUsuario(string usuario)

        {
            MySqlConnection conexao = null;

            try
            {
                //cria a conexao, estou utilizando a classe ConexaoDB q esta dentro da pasta DATA
                conexao = ConexaoDB.CriarConexao();

                //comando sql que sera executado
                string sql = "DELETE FROM tbusuarios WHERE usuario=@usuario;";

                //abri a conexao com o banco
                conexao.Open();

                //esse cara é o responsavel por executar o comando sql
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@usuario", usuario);

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
                MessageBox.Show($"Erro ao excluir usuario: {erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            finally
            {
                conexao.Close();
            }

        }

        public bool AttSenha(string senha, string usuario)
        {
            MySqlConnection conexao = null;
            try
            {
                //cria a conexao, estou utilizando a classe ConexaoDB q esta dentro da pasta DATA
                conexao = ConexaoDB.CriarConexao();

                //comando sql que sera executado
                string sql = @"update tbusuarios set senha = (@senha) where usuario = (@usuario);​";

                //abri a conexao com o banco
                conexao.Open();

                //esse cara é o responsavel por executar o comando sql
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@senha", senha);
                comando.Parameters.AddWithValue("@usuario", usuario);

                //executando no banco de dados
                int linhasAfetadas = comando.ExecuteNonQuery();


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
                MessageBox.Show($"Erro ao alterar senha: {erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            finally
            {
                conexao.Close();
            }

        }
    }
}
    
