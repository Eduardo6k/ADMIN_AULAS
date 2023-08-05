using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crm_Dev.Menu
{
    public partial class Form_PegarDadosAula : Form
    {
        form_Aula dados;
        public Form_PegarDadosAula(form_Aula fA)
        {
            dados = fA;
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dados.item[0] = getMat.Text.ToString();
            dados.item[1] = textBox2.Text.ToString();
            dados.item[2] = textBox3.Text.ToString();
            dados.item[3] = maskedTextBox4.Text.ToString();
            foreach(string i in dados.item)
            {
                if(i == "")
                {
                    MessageBox.Show("algums campos estão vazios!", "desculpa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                }
                else
                {
                    dados.listView1.Items.Add(new ListViewItem(dados.item));
                    this.Close();
                }
            }
            
        }


        private void getMat_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (getMat.Focused)
                {
                    textBox2.Focus();

                }

            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (textBox2.Focused)
                {
                    textBox3.Focus();

                }

            }
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox3.Focused)
                {
                    maskedTextBox4.Focus();

                }

            }
        }

        private void maskedTextBox4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (maskedTextBox4.Focused)
                {
                    button1.Focus();

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


