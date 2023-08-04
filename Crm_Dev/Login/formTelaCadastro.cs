using Crm_Dev_Lib.Logar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crm_Dev
{
    public partial class frm_TelaCadastro : Form
    {
        bool checar = true;
        public frm_TelaCadastro()
        {
            InitializeComponent();
        }


        //CHECA A FORÇA DA SENHA E EXIBE
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            ChecaForcaSenha verifica = new ChecaForcaSenha();
            ChecaForcaSenha.ForcaDaSenha forca;
            forca = verifica.GetForcaDaSenha(cbx_SenhaCadastro.Text);
            lbl_SenhaOutPut.Text = forca.ToString();
            if (lbl_SenhaOutPut.Text == "Inaceitavel" || lbl_SenhaOutPut.Text == "Fraca")
            {
                lbl_SenhaOutPut.ForeColor = Color.Red;
            }
            else if (lbl_SenhaOutPut.Text == "Aceitavel")
            {
                lbl_SenhaOutPut.ForeColor = Color.Yellow;
            }
            else
            {
                lbl_SenhaOutPut.ForeColor = Color.Green;
            }

        }


        //MOSTRAR SENHA
        private void cbx_VerSenha_Click(object sender, EventArgs e)
        {

            if (cbx_VerSenha.CheckState == CheckState.Checked)
            {
                cbx_SenhaCadastro.PasswordChar = '*';

            }
            else
            {

                cbx_SenhaCadastro.PasswordChar = '\0';

            }

        }


        //BOTÃO CONTINUAR
        private void btn_Continuar_Click(object sender, EventArgs e)

        {
            //CHECAR CPF
            Boolean chek = false;
            chek = ChecarCPF.Valida(msk_tbx_CPF.Text);
            if (chek)
            {
                lbl_CpfOutPut.Text = "CPF VALIDO";
                lbl_CpfOutPut.ForeColor = Color.Green;

                //voltando para o login
                switch (MessageBox.Show("VOLTAR PARA TELA DE LOGIN?", "Logar ou Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        {
                            Close();
                            TelaLogin tela = new TelaLogin();
                            tela.Show();
                            break;
                        }

                    default:
                        Application.Exit();
                        break;
                }
            }
            else
            {
                lbl_CpfOutPut.Text = "CPF INVALIDO";
                lbl_CpfOutPut.ForeColor = Color.Red;

            }



        }

        //cancelar cadastro
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaLogin tela = new TelaLogin();
            tela.Show();
        }
    }
  


}
