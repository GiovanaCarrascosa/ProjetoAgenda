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
    }
}
