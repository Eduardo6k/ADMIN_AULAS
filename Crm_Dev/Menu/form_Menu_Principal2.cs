using ADMIN_AULAS.Menu;
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
    public partial class form_Menu_Principal2 : Form
    {
        public form_Menu_Principal2()
        {
            InitializeComponent();

        }

        //ABRIR FORMULARIOS
        private void OpenForm(Form formulario)
        {
            if (formulario != null)
            {

            }

        }
        private void IB_AULA_Click(object sender, EventArgs e)
        {

            TabPage tabAulas = new TabPage();
            form_Aula aula = new form_Aula();


            tabControl_Centro.TabPages.Clear();
            tabAulas.Name = "aulas";
            tabAulas.Text = "suas aulas estão nesta aba!";
            tabAulas.Controls.Add(aula);
            tabControl_Centro.TabPages.Add(tabAulas);





        }

        private void IB_NOTAS_Click(object sender, EventArgs e)
        {


            tabControl_Centro.TabPages.Clear();
            TabPage tabNotas = new TabPage();
            form_Notas notas = new form_Notas();
            tabNotas.Name = "notas";
            tabNotas.Text = "suas notas!!";
            tabNotas.Controls.Add(notas);
            tabControl_Centro.TabPages.Add(tabNotas);


        }
    }
}
