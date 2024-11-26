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
    }
}
