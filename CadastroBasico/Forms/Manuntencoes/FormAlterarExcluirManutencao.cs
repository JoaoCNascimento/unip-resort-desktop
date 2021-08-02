using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoUnipResort.Forms.Manutencoes
{
    public partial class FormAlterarExcluirManutencao : Form
    {
        public FormAlterarExcluirManutencao()
        {
            InitializeComponent();
        }

        private void FormAlterarExcluirManutencao_Load(object sender, EventArgs e)
        {
            radioBtnHotel.Checked = true;
        }

        private void radioBtnQuartos_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnQuartos.Checked == true)
            {
                labelAndar.Visible = true;
                labelQuarto.Visible = true;
                textBoxAndar.Visible = true;
                textBoxQuarto.Visible = true;
            }

            if (radioBtnQuartos.Checked == false)
            {
                labelAndar.Visible = false;
                labelQuarto.Visible = false;
                textBoxAndar.Visible = false;
                textBoxQuarto.Visible = false;
            }
        }
    }
}
