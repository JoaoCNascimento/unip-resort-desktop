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
    public partial class FormAgendarManutencao : Form
    {
        public FormAgendarManutencao()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormAgendarManutencao_Load(object sender, EventArgs e)
        {
            // inicializa o radiobtnHotel como checado, ou seja, o padrão.
            radioBtnHotel.Checked = true;
        }

        private void checkNotificar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNotificar.Checked == true)
            {
                gbNotificar.Visible = true;
            }
            if(checkNotificar.Checked == false)
            {
                gbNotificar.Visible = false;
            }
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
