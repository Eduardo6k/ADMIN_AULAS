namespace Crm_Dev
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //ENTRAR NO APP
        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (txb_nome.Text.Equals("admin") && txb_senha.Text.Equals("admin"))
                {

                    //logar no app
                   // Hide();
                  //  MENU menu = new MENU();
                  //  menu.Show();


                }
                else
                {
                    MessageBox.Show(
                        "SENHA OU USUARIO INCORRETOS",
                        "DESCULPE",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DESCULPE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //mudando foco do txb
        private void txb_nome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txb_senha.Focus();
            }
        }



        //ABRINDO TELA DE CADASTRO
        private void bnt_Cadastro_Click(object sender, EventArgs e)
        {
            Hide();
            frm_TelaCadastro TelaCadastro = new frm_TelaCadastro();
            TelaCadastro.Show();

        }

        //mudando a cor do background dos txbs {inicio
        private void txb_nome_MouseEnter(object sender, EventArgs e)
        {
            txb_nome.BackColor = Color.Wheat;
        }

        private void txb_nome_MouseLeave(object sender, EventArgs e)
        {
            txb_nome.BackColor = Color.White;
        }
        // fim }


        //tratamento de entrada de dados do nome do usuário
        private void txb_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            int tecla = (int)e.KeyChar;
            
            if (!char.IsLetterOrDigit(e.KeyChar) && tecla != 08)
            {
                e.Handled = true;
                lbl_User.Text = "DIGITE APENAS LETRAS E NUMEROS";
            }
            else if (char.IsLetterOrDigit(e.KeyChar)  || tecla == 08)
            {
                lbl_User.Text = string.Empty;
            }
        }
    }
}