using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoUnipResort.Forms.Relatorios
{
    public partial class FormEditor : Form
    {
        public FormEditor()
        {
            InitializeComponent();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            
        }

        private void arquivoToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            arquivoToolStripMenuItem.ForeColor = Color.FromArgb(41, 41, 41);
        }

        private void arquivoToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            arquivoToolStripMenuItem.ForeColor = Color.White;
        }

        private void richTxtTexto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
