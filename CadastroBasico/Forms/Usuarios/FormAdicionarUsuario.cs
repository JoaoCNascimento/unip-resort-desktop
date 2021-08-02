using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoUnipResort.Forms.Usuarios
{
    public partial class FormAdicionarUsuario : Form
    {
        public FormAdicionarUsuario()
        {
            InitializeComponent();
        }

        private void checkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTodos.Checked) {

                checkFuncionarios.Checked= true;
                checkEmail.Checked= true;
                checkQuartos.Checked= true;
                checkRelatorios.Checked= true;
                checkUsuarios.Checked= true;
                checkManutencao.Checked= true;

                checkFuncionarios.Enabled = false;
                checkEmail.Enabled = false;
                checkQuartos.Enabled = false;
                checkRelatorios.Enabled = false;
                checkUsuarios.Enabled = false;
                checkManutencao.Enabled = false;

            }

            else
            {

                checkFuncionarios.Checked = false;
                checkEmail.Checked = false;
                checkQuartos.Checked = false;
                checkRelatorios.Checked = false;
                checkUsuarios.Checked = false;
                checkManutencao.Checked = false;

                checkFuncionarios.Enabled = true;
                checkEmail.Enabled = true;
                checkQuartos.Enabled = true;
                checkRelatorios.Enabled = true;
                checkUsuarios.Enabled = true;
                checkManutencao.Enabled = true;

            }
        }
    }
}
