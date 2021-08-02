using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoUnipResort.Forms.Quartos
{
    public partial class FormEditarExcluirQuartos : Form
    {
        public FormEditarExcluirQuartos()
        {
            InitializeComponent();
        }

        private void FormConsultarQuartos_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnSelecionarImagem.Enabled = true;
            btnSalvar.Visible = true;
            btnCancelar.Visible = true;
            btnEditar.Visible = false;
            btnExcluir.Visible = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            btnSelecionarImagem.Enabled = false;
            btnSalvar.Visible = false;
            btnCancelar.Visible = false;
            btnEditar.Visible = true;
            btnExcluir.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnSelecionarImagem.Enabled = false;
            btnSalvar.Visible = false;
            btnCancelar.Visible = false;
            btnEditar.Visible = true;
            btnExcluir.Visible = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
