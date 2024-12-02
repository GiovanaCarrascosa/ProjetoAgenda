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
    internal class CategoriaController
    {
        public bool AddCategoria(string categoria)
        {
            MySqlConnection conexao = null;

            try
            {
                //cria a conexao, estou utilizando a classe ConexaoDB q esta dentro da pasta DATA
                conexao = ConexaoDB.CriarConexao(UserSession.usuario,UserSession.senha);

                //comando sql que sera executado
                string sql = "INSERT INTO categorias (categoria) VALUES (@categoria);";

                //abri a conexao com o banco
                conexao.Open();

                //esse cara é o responsavel por executar o comando sql
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                //estou trocando o valor dos @ pelas informações que serao cadastradas
                //essas informações vieram dos parametros da função
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
                MessageBox.Show($"Erro ao cadastrar categoria: {erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            finally
            {
                conexao.Close();
            }
        }

        public DataTable GetCategorias()
        {
            //criando uma conexao vazia
            MySqlConnection conexao = null;

            try
            {
                //inserindo a conexao usando a conexaodb q eu ja havia criado
                conexao = ConexaoDB.CriarConexao(UserSession.usuario,UserSession.senha);

                //montei o select que retorna todas as categorias
                string sql = $@"select cod_categoria, categoria, usuario from categorias where usuario LIKE '{UserSession.usuario}@%'";

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

        public bool DltCategoria(int cod_categoria)

        {
            MySqlConnection conexao = null;

            try
            {
                //cria a conexao, estou utilizando a classe ConexaoDB q esta dentro da pasta DATA
                conexao = ConexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);

                //comando sql que sera executado
                string sql = "DELETE FROM categorias WHERE cod_categoria=@cod_categoria;";

                //abri a conexao com o banco
                conexao.Open();

                //esse cara é o responsavel por executar o comando sql
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@cod_categoria", cod_categoria);

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
                MessageBox.Show($"Erro ao excluir categoria: {erro.Message}", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            finally
            {
                conexao.Close();
            }

        }


        public bool AttCategoria(string categoria, int cod_categoria)
        {
            MySqlConnection conexao = null;
            try
            {
                //cria a conexao, estou utilizando a classe ConexaoDB q esta dentro da pasta DATA
                conexao = ConexaoDB.CriarConexao(UserSession.usuario, UserSession.senha);

                //comando sql que sera executado
                string sql = @"UPDATE categorias SET categoria = @categoria WHERE cod_categoria = @cod_categoria;";

                //abri a conexao com o banco
                conexao.Open();

                //esse cara é o responsavel por executar o comando sql
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@categoria", categoria);
                comando.Parameters.AddWithValue("@cod_categoria", cod_categoria);

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

