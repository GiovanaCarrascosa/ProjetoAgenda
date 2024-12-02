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
    public partial class frm_tela_agenda : Form
    {
        public frm_tela_agenda()
        {
            InitializeComponent();
        }

        private void AttDataGrid()
        {
            CategoriaController controleCategoria = new CategoriaController();
            DataTable tabela = controleCategoria.GetCategorias();
            dgv_contato.DataSource = tabela;
        }


        private void frm_tela_agenda_Load(object sender, EventArgs e)
        {
            CategoriaController controleCategoria = new CategoriaController();
            DataTable tabela = controleCategoria.GetCategorias();
            cmbCategoria.DataSource = tabela;
            cmbCategoria.DisplayMember = "categoria";
            cmbCategoria.DisplayMember = "cod_categoria";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            string contato = txt_contato.Text;


            //instanciando o objeto UsuarioController
            ContatoController controleContato = new ContatoController();

            //inserindo o usuario
            bool resultado = controleContato.AddContato(nome);

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

        //private void AttDataGrid()
        //{
        //    throw new NotImplementedException();
      //}
    }
    
}
