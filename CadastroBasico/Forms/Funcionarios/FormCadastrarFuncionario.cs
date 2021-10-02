using GestaoUnipResort.Classes;
using GestaoUnipResort.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoUnipResort.Forms.Funcionarios
{
    public partial class FormCadastrarFuncionario : Form
    {
        public FormCadastrarFuncionario()
        {
            InitializeComponent();
        }

        private void FormCadastrarFuncionario_Load(object sender, System.EventArgs e)
        {

            tipBtnSalvar.SetToolTip(this.btnSalvar, "Clique para salvar o cadastro");
            tipBtnLimpar.SetToolTip(this.btnLimpar, "Clique para limpar os campos preenchidos");
        }

        private void textBoxTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDataNascimento_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBoxCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBoxRG_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtEmailContato_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSalario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSenha2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
