using ProjetoAgenda.VariableGlobal;
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
    public partial class frm_telaprincipal : Form
    {
        public frm_telaprincipal()
        {
            InitializeComponent();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_categorias telacategoria = new frm_categorias();
            telacategoria.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_usuario telausuario = new frm_usuario();
            telausuario.ShowDialog();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tela_agenda telaagenda = new frm_tela_agenda();
            telaagenda.ShowDialog();
        }

        private void frm_telaprincipal_Load(object sender, EventArgs e)
        {
            lblmensagem.Text = $"Seja bem vinde {UserSession.nome}!";
        }

   
    }
}
