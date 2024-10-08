namespace ProjetoAgenda
{
    public partial class frm_tela_login : Form
    {
        public frm_tela_login()
        {
            InitializeComponent();
        }
        
        //criando uma fun��o
        // private = s� o frm_login ter� acesso | void = n�o vai retonar nada | 
        private void habilitarBotaoLogin()
        {
            // se o usuario for diferente de vazio e a quantidade de caracteres for maior ou igual a 8, o botao de entrar � ativado
            if (txt_usuario.Text != "" && txt_senha.Text.Length >= 8)
            {
                btn_entrar.Enabled = true;

            }
            // se n�o, o botao nao � ativado
            else
            { btn_entrar.Enabled = false; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_tela_cadastro telacadastro = new frm_tela_cadastro();
            telacadastro.ShowDialog();

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoLogin();
        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoLogin();
        }
    }
}
