using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda
{
    public partial class frm_tela_cadastro : Form


    {
        public frm_tela_cadastro()
        {
            InitializeComponent();
        }

        private void habilitarBotaoCadastro()
        {
            // se o usuario for diferente de vazio e a quantidade de caracteres for maior ou igual a 8, o botao de cadastrar é ativado
            if (txt_nome.Text != "" && txt_usuario2.Text != "" && txt_senha2.Text.Length >= 8 && txt_senha22.Text == txt_senha2.Text)
            {
                btn_cadastrar.Enabled = true;

            }
            // se não, o botao nao é ativado
            else
            { btn_cadastrar.Enabled = false; }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoCadastro();
        }

        private void txt_usuario2_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoCadastro();
        }

        private void txt_telefone_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoCadastro();
        }

        private void txt_senha2_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoCadastro();
        }

        private void txt_senha22_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoCadastro();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = ConexaoDB.CriarConexao();

            //abrindo conexao
            conexao.Open();

            //criando o comando SQL para inserir o usuário 

            string sql = $"INSERT INTO tbusuarios(nome, usuario, telefone, senha) VALUES (@nome, @usuario, @telefone, @senha";
                
            //criando o comando
            MySqlCommand comando = new MySqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@nome", txt_nome.Text);
            comando.Parameters.AddWithValue("@usuario", txt_usuario2.Text);
            comando.Parameters.AddWithValue("@telefone", txt_telefone.Text);
            comando.Parameters.AddWithValue("@senha", txt_senha2.Text);

            //executando a instrução SQL no banco
            comando.ExecuteNonQuery();

            //fechando a conexao com o banco
            conexao.Close();

            MessageBox.Show("Cadastro efetudo com sucesso! \n Você já pode realizar o login");
            this.Close();


        }
    }
}
