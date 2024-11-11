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
    public partial class frm_categorias : Form
    {
        public frm_categorias()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_categoria_Click(object sender, EventArgs e)
        {
            //pegando os dados do formulario
            string categoria = txt_categoria.Text;


            //instanciando o objeto UsuarioController
            CategoriaController controleCategoria = new CategoriaController();

            //inserindo o usuario
            bool resultado = controleCategoria.AddCategoria(categoria);

            if (resultado)
            {
                MessageBox.Show("Cadastro efetuado com sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possivel cadastrar");
            }

            DataTable tabela = controleCategoria.GetCategorias();
            dgvCategoria.DataSource = tabela;
        }

        private void btn_fechar_categoria_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoriaController controleCategoria = new CategoriaController();
            DataTable tabela = controleCategoria.GetCategorias();
            dgvCategoria.DataSource = tabela;
        }

        private void frm_categorias_Load(object sender, EventArgs e)
        {
            CategoriaController controleCategoria = new CategoriaController();
            DataTable tabela = controleCategoria.GetCategorias();
            dgvCategoria.DataSource = tabela;
        }

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
