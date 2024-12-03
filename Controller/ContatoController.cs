using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using ProjetoAgenda.VariableGlobal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controller
{
    internal class ContatoController
    {
        public bool AddContato(string nome, string telefone, string categoria)
        {
            MySqlConnection conexao = null;

            try
            {
                //cria a conexao, estou utilizando a classe ConexaoDB q esta dentro da pasta DATA
                conexao = ConexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);

                //comando sql que sera executado
                string sql = "INSERT INTO tbcontatos (nome, telefone, categoria) VALUES (@nome, @telefone, @categoria);";

                //abri a conexao com o banco
                conexao.Open();

                //esse cara é o responsavel por executar o comando sql
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //estou trocando o valor dos @ pelas informações que serao cadastradas
                //essas informações vieram dos parametros da função
           
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@categoria", categoria);
                


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
                MessageBox.Show($"Erro ao cadastrar contato: {erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            finally
            {
                conexao.Close();
            }
        }

        public DataTable GetContato()
        {
            //criando uma conexao vazia
            MySqlConnection conexao = null;

            try
            {
                //inserindo a conexao usando a conexaodb q eu ja havia criado
                conexao = ConexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);

                //montei o select que retorna todas as categorias
                string sql = $@"select cod_contato, nome, telefone, categoria from tbcontatos where usuario LIKE '{UserSession.usuario}@%'";

                //abri a conexao
                conexao.Open();

                //criei um adaptador
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexao);
                //MySqlCommand comando = new MySqlCommand(sql, conexao);




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

        public bool DltContato(int cod_contato)

        {
            MySqlConnection conexao = null;

            try
            {
                //cria a conexao, estou utilizando a classe ConexaoDB q esta dentro da pasta DATA
                conexao = ConexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);

                //comando sql que sera executado
                string sql = "DELETE FROM tbcontatos WHERE cod_contato=@cod_contato;";

                //abri a conexao com o banco
                conexao.Open();

                //esse cara é o responsavel por executar o comando sql
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@cod_contato", cod_contato);

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
                MessageBox.Show($"Erro ao excluir contato: {erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            finally
            {
                conexao.Close();
            }

        }

        public bool AttContato(int cod_contato, string nome, string telefone, string categoria)
        {
            MySqlConnection conexao = null;
            try
            {
                //cria a conexao, estou utilizando a classe ConexaoDB q esta dentro da pasta DATA
                conexao = ConexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);

                //comando sql que sera executado
                string sql = "UPDATE tbcontatos SET nome = @nome, telefone = @telefone, categoria = @categoria WHERE cod_contato = @cod_contato;";

                //abri a conexao com o banco
                conexao.Open();

                //esse cara é o responsavel por executar o comando sql
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@cod_contato", cod_contato);
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@categoria", categoria);
                

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
                MessageBox.Show($"Erro ao alterar categoria: {erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

    }
}
