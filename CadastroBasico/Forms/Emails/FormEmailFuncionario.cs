using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoUnipResort.Forms.Emails
{
    public partial class FormEmailFuncionario : Form
    {
        public FormEmailFuncionario()
        {
            InitializeComponent();
        }

        private void FormEmailFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void checkEnviarTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEnviarTodos.Checked == true)
            {
                cbEmails.Enabled = false;
            }

            if (checkEnviarTodos.Checked == false)
            {
                cbEmails.Enabled = true;
            }
        }
    }
}
