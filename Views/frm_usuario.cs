using ProjetoAgenda.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda.Views
{
    public partial class frm_usuario : Form
    {
        public frm_usuario()
        {
            InitializeComponent();
        }

        private void AttDataGrid()
        {
            UsuarioController controleCategoria = new UsuarioController();
            DataTable tabela = controleCategoria.GetUsuario();
            dgv_usuario.DataSource = tabela;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string senha = txt_nova_senha.Text;

            string usuarios = Convert.ToString(dgv_usuario.SelectedRows[0].Cells[0].Value);
            UsuarioController atualizarSenha = new UsuarioController();
            bool resultado = atualizarSenha.AttSenha(senha, usuarios);

            if (resultado)
            {
                MessageBox.Show("Senha alterada com sucesso");
            }

            else
            {
                MessageBox.Show("Erro ao alterar senha");
            }

            AttDataGrid();

        }

        private void btn_fechar_categoria_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_usuario_Load(object sender, EventArgs e)
        {
            UsuarioController controleUsuario = new UsuarioController();
            DataTable tabela = controleUsuario.GetUsuario();
            dgv_usuario.DataSource = tabela;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            string usuario = Convert.ToString(dgv_usuario.SelectedRows[0].Cells[1].Value);
            UsuarioController categoria = new UsuarioController();
            bool resultado = categoria.DltUsuario(usuario);

            AttDataGrid();
        }

        private void dgv_usuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
