using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoUnipResort.Classes;

namespace GestaoUnipResort.Forms.Quartos
{
    public partial class FormAdicionarQuarto : Form
    {
        public FormAdicionarQuarto()
        {
            InitializeComponent();
        }

        private void btnSelecionarImagem_Click(object sender, EventArgs e)
        {
            try
            {
                ofdImagem.FileName = "img";
                ofdImagem.Title = "Selecione uma foto";
                ofdImagem.Filter = "JPEG|*.JPG|PNG|*.png";

                if(ofdImagem.ShowDialog() == DialogResult.OK)
                {

                    pboxQuarto.Image = new Bitmap(ofdImagem.FileName);

                }
            }

            catch(Exception)
            {

                MessageBox.Show("Ocorreu um erro, tente novamente ou contate o desenvolvedor", "Atenção");

            }
            
        }

        private void FormAdicionarQuarto_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            try
            {
                
            }

            catch(Exception)
            {

                

            }
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
