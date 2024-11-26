using ProjetoAgenda.Controller;
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

namespace ProjetoAgenda.Views
{
    public partial class frm_categorias : Form
    {
        public frm_categorias()
        {
            InitializeComponent();
        }

        private void AttDataGrid()
        {
            CategoriaController controleCategoria = new CategoriaController();
            DataTable tabela = controleCategoria.GetCategorias();
            dgvCategoria.DataSource = tabela;
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

            AttDataGrid();

            if (resultado)
            {
                MessageBox.Show("Cadastro efetuado com sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possivel cadastrar");
            }


        }

        private void btn_fechar_categoria_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void txt_categoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(dgvCategoria.SelectedRows[0].Cells[0].Value);
            CategoriaController categoria = new CategoriaController();
            bool resultado = categoria.DltCategoria(codigo);

            AttDataGrid();


        }


        private void btn_alterar_categoria_Click_1(object sender, EventArgs e)
        {
            string categoria_alterada = txt_categoria.Text;

            int cod_categoria = Convert.ToInt32(dgvCategoria.SelectedRows[0].Cells[0].Value);
            CategoriaController atualizarCategoria = new CategoriaController();
            bool resultado = atualizarCategoria.AttCategoria(categoria_alterada, cod_categoria);

            if (resultado)
            {
                MessageBox.Show("Categoria alterada com sucesso!");
            }

            else
            {
                MessageBox.Show("Erro ao alterar categoria!");
            }

            AttDataGrid();
        }
    }
}

