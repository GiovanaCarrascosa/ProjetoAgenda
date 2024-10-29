using MySql.Data.MySqlClient;
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
        public bool AddUsuario(string nome, string usuario string telefone string senha)
        {
            MySqlConnection conxao = ConexaoDB.CriarConexao();
        }
    }
}
