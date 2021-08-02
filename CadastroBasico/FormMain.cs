using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using GestaoUnipResort.Forms.Funcionarios;
using GestaoUnipResort.Forms.Quartos;
using GestaoUnipResort.Forms.Relatorios;
using GestaoUnipResort.Forms.Manutencoes;
using GestaoUnipResort.Forms.Usuarios;
using GestaoUnipResort.Forms.Emails;


namespace GestaoUnipResort
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        /*MOVER FORM ATRAVÉS DA BARRA*/
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelGrip_MouseDown(object sender, MouseEventArgs e)
        {
            panelGrip.BackColor = Color.FromArgb(48, 48, 48);

            if(this.WindowState == FormWindowState.Maximized)
            {

                btnRestaurar.Visible = false;
                btnMaximizar.Visible = true;

            }

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

            panelGrip.BackColor = Color.FromArgb(51,51,51);
        }

        /*------------------------------------------------------------*/

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelConteiner_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            esconderPanel(btnFuncionarios, panelSubMenuFuncionarios);
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            FormCadastrarFuncionario frm = new FormCadastrarFuncionario() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            abrirForm(frm);
        }

        private void btnConsultarFuncionarios_Click(object sender, EventArgs e)
        {
            FormConsultarFuncionarios frm = new FormConsultarFuncionarios() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            abrirForm(frm);
        }

        private void btnExcluirAlterarFuncionarios_Click(object sender, EventArgs e)
        {
            FormEditarExcluirFuncionario frm = new FormEditarExcluirFuncionario() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            abrirForm(frm);
        }

        private void btnCargosFunc_Click(object sender, EventArgs e)
        {
            FormCargos frm = new FormCargos() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            abrirForm(frm);
        }

        /*END BUTTON FUNCIONARIOS*/

        private void btnQuartos_Click(object sender, EventArgs e)
        {
            esconderPanel(btnQuartos, panelSubMenuQuartos);
        }

        private void btnCadastrarQuarto_Click(object sender, EventArgs e) 
        {
            FormAdicionarQuarto frm = new FormAdicionarQuarto() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            abrirForm(frm);
        }

        private void btnConsultarQuarto_Click(object sender, EventArgs e)
        {
            FormConsultarQuartos frm = new FormConsultarQuartos() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            abrirForm(frm);
        }

        private void btnExcluirAlterarQuarto_Click(object sender, EventArgs e)
        {
            FormEditarExcluirQuartos frm = new FormEditarExcluirQuartos() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            abrirForm(frm);
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            FormCategoria frm = new FormCategoria() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            abrirForm(frm);
        }

        /*END BUTTON QUARTOS*/

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            esconderPanel(btnRelatorios, panelSubMenuRelatorios);
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            FormRelatorios frm = new FormRelatorios() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            abrirForm(frm);
        }

        private void btnEscreverRelatorio_Click(object sender, EventArgs e)
        {
            FormEditor frm = new FormEditor() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            abrirForm(frm);
        }

        /*END BUTTON RELATORIOS*/

        private void btnEmails_Click(object sender, EventArgs e)
        {
            esconderPanel(btnEmails, panelSubMenuEmail);
        }

        private void btnEmailFuncionarios_Click(object sender, EventArgs e)
        {
            FormEmailFuncionario frm = new FormEmailFuncionario() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            abrirForm(frm);
        }

        private void btnEmailClientes_Click(object sender, EventArgs e)
        {
            FormEmailClientes frm = new FormEmailClientes() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            abrirForm(frm);
        }

        /*END BUTTON EMAILS*/

        private void btnManutencao_Click(object sender, EventArgs e)
        {
            esconderPanel(btnManutencao, panelSubMenuManutencao);
        }

        private void btnAgendarManutencao_Click(object sender, EventArgs e)
        {
            FormAgendarManutencao frm = new FormAgendarManutencao() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            abrirForm(frm);
        }

        private void btnConsultarManutencao_Click(object sender, EventArgs e)
        {
            FormConsultarManutencoes frm = new FormConsultarManutencoes() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            abrirForm(frm);
        }


        private void btnCancelarManutencao_Click(object sender, EventArgs e)
        {
            FormAlterarExcluirManutencao frm = new FormAlterarExcluirManutencao() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            abrirForm(frm);
        }

        /*END BUTTON MANUTENCAO*/

        private void btnUsers_Click(object sender, EventArgs e)
        {
            esconderPanel(btnUsers, panelSubMenuUsuarios);
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FormAdicionarUsuario frm = new FormAdicionarUsuario() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            abrirForm(frm);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        /*END BUTTON USUARIOS*/

        private void btnDeslogar_Click(object sender, EventArgs e)
        {
            DialogResult Encerramento = MessageBox.Show("Deseja realmente sair da aplicação?", "Atenção", MessageBoxButtons.YesNo);

            if (Encerramento.ToString() == "Yes")
            {
                Application.Exit();
            }
        }

        public void hidemenu(Button c)
        {
            if(c != btnFuncionarios)
            {
                btnFuncionarios.Enabled = false;
                btnFuncionarios.IconColor = Color.FromArgb(51, 51, 51);
                btnFuncionarios.ForeColor = Color.FromArgb(51, 51, 51);
            }
            
            if(c != btnQuartos)
            {
                btnQuartos.Enabled = false;
                btnQuartos.IconColor = Color.FromArgb(51, 51, 51);
                btnQuartos.ForeColor = Color.FromArgb(51, 51, 51);
            }

            if (c != btnEmails)
            {
                btnEmails.Enabled = false;
                btnEmails.IconColor = Color.FromArgb(51, 51, 51);
                btnEmails.ForeColor = Color.FromArgb(51, 51, 51);
            }

            if(c != btnDeslogar)
            {
                btnDeslogar.Enabled = false;
                btnDeslogar.IconColor = Color.FromArgb(51, 51, 51);
                btnDeslogar.ForeColor = Color.FromArgb(51, 51, 51);
            }

            if(c != btnRelatorios)
            {
                btnRelatorios.Enabled = false;
                btnRelatorios.IconColor = Color.FromArgb(51, 51, 51);
                btnRelatorios.ForeColor = Color.FromArgb(51, 51, 51);

            }

            if (c != btnManutencao)
            {
                btnManutencao.Enabled = false;
                btnManutencao.IconColor = Color.FromArgb(51, 51, 51);
                btnManutencao.ForeColor = Color.FromArgb(51, 51, 51);
            }

            if(c != btnUsers)
            {
                btnUsers.Enabled = false;
                btnUsers.IconColor = Color.FromArgb(51, 51, 51);
                btnUsers.ForeColor = Color.FromArgb(51, 51, 51);
            }
            
        }

        public void show()
        {
            panelSubMenuFuncionarios.Visible = false;
            panelSubMenuQuartos.Visible = false;
            panelSubMenuRelatorios.Visible = false;
            panelSubMenuEmail.Visible = false;
            panelSubMenuManutencao.Visible = false;
            panelSubMenuUsuarios.Visible = false;

            btnFuncionarios.Enabled = true;
            btnFuncionarios.IconColor = Color.White;
            btnFuncionarios.ForeColor = Color.White;

            btnQuartos.Enabled = true;
            btnQuartos.IconColor = Color.White;
            btnQuartos.ForeColor = Color.White;

            btnEmails.Enabled = true;
            btnEmails.IconColor = Color.White;
            btnEmails.ForeColor = Color.White;

            btnDeslogar.Enabled = true;
            btnDeslogar.IconColor = Color.White;
            btnDeslogar.ForeColor = Color.White;

            btnRelatorios.Enabled = true;
            btnRelatorios.IconColor = Color.White;
            btnRelatorios.ForeColor = Color.White;

            btnManutencao.Enabled = true;
            btnManutencao.IconColor = Color.White;
            btnManutencao.ForeColor = Color.White;

            btnUsers.Enabled = true;
            btnUsers.IconColor = Color.White;
            btnUsers.ForeColor = Color.White;
        }

        public void esconderPanel(Button btn, Panel panel)
        {
            if (panel.Visible == false)
            {
                panel.Visible = true;
                hidemenu(btn);
            }

            else
            {
                panel.Visible = false;
                show();
            }
        }

        private void abrirForm(Form frm)
        {
            if (this.panelConteiner.Controls.Count > 0)
            {
                this.panelConteiner.Controls.RemoveAt(0);
                this.panelConteiner.Controls.Add(frm);
                frm.Show();
                show();
            }

            else
            {
                this.panelConteiner.Controls.Add(frm);
                frm.Show();
                show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(this.panelConteiner.Controls.Count>(0))
            {
                this.panelConteiner.Controls.RemoveAt(0);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
        }
    }
}
