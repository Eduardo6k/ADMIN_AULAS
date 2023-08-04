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
    public partial class form_Aula : UserControl
    {

        public string[] item = new string[4];
        public form_Aula()
        {
            InitializeComponent();

        }

        private void IC_ADICIONAR_Click(object sender, EventArgs e)
        {
            Form_PegarDadosAula tela = new Form_PegarDadosAula(this);
            tela.ShowDialog();
            
        }

        private void IC_DELETAR_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Checked)
                {
                    listView1.Items.RemoveAt(item.Index);
                }
            }
        }
    }
}
