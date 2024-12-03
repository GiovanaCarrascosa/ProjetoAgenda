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
            ContatoController controleCategoria = new ContatoController();
            DataTable tabela = controleCategoria.GetContato();
            dgv_contato.DataSource = tabela;
        }


        private void frm_tela_agenda_Load(object sender, EventArgs e)
        {
            CategoriaController controleCategoria = new CategoriaController();
            DataTable tabela = controleCategoria.GetCategorias();
            cmbCategoria.DataSource = tabela;
            cmbCategoria.DisplayMember = "categoria";
            AttDataGrid();

        }

        //private void frm_tela_agenda_Load(object sender, EventArgs e)
        //{
        //    ContatoController controleContato = new ContatoController();
        //    DataTable tabela = controleContato.GetCategorias();
        //    cmbCategoria.DataSource = tabela;
        //    cmbCategoria.DisplayMember = "categoria";
        //    cmbCategoria.DisplayMember = "cod_categoria";

        //}

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            string contato = txt_contato.Text;
            string telefone = txt_telefone.Text;
            string categoria = cmbCategoria.Text;

            //instanciando o objeto UsuarioController
            ContatoController controleContato = new ContatoController();


            //inserindo o usuario
            bool resultado = controleContato.AddContato(contato, telefone, categoria);


            if (resultado)
            {
                MessageBox.Show("Cadastro efetuado com sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possivel cadastrar");
            }
            AttDataGrid();


        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(dgv_contato.SelectedRows[0].Cells[0].Value);
            ContatoController contato = new ContatoController();
            bool resultado = contato.DltContato(codigo);

            AttDataGrid();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            int cod_contato = Convert.ToInt32(dgv_contato.SelectedRows[0].Cells[0].Value);
            string contato = txt_contato.Text;
            string telefone = txt_telefone.Text;
            string categoria = cmbCategoria.Text;

            
            ContatoController atualizarContato = new ContatoController();
            atualizarContato.AttContato(cod_contato, contato, telefone, categoria);

            AttDataGrid();
        }

        //private void AttDataGrid()
        //{
        //    throw new NotImplementedException();
        //}
    }

}
