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

namespace GestaoUnipResort.Forms.Funcionarios
{
    public partial class FormConsultarFuncionarios : Form
    {
        public FormConsultarFuncionarios()
        {
            InitializeComponent();
        }

        private void FormConsultarFuncionarios_Load(object sender, EventArgs e)
        {
            setDataGridView();
        }

        private void cbOrdenarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Define os tipos de sorts da tabela
            ListSortDirection ascending, descending;
            ascending = ListSortDirection.Ascending;
            descending = ListSortDirection.Descending;

            if (cbOrdenarPor.SelectedItem.ToString() == "Nome (Alfabética)")
            {
                dataGridViewFuncionarios.Sort(dataGridViewFuncionarios.Columns[1], ascending);
            }

            /*----------------------------------------------------------------------------*/

            if (cbOrdenarPor.SelectedItem.ToString() == "ID Crescente")
            {
                dataGridViewFuncionarios.Sort(dataGridViewFuncionarios.Columns[0], ascending);
            }

            /*----------------------------------------------------------------------------*/

            if (cbOrdenarPor.SelectedItem.ToString() == "ID Decrescente")
            {
                dataGridViewFuncionarios.Sort(dataGridViewFuncionarios.Columns[0], descending);
            }

            /*----------------------------------------------------------------------------*/

            if (cbOrdenarPor.SelectedItem.ToString() == "Data de nascimento crescente")
            {
                dataGridViewFuncionarios.Sort(dataGridViewFuncionarios.Columns[5], ascending);
            }
            if(cbOrdenarPor.SelectedItem.ToString() == "Data de nascimento decrescente")
            {
                dataGridViewFuncionarios.Sort(dataGridViewFuncionarios.Columns[5], descending);
            }

            /*----------------------------------------------------------------------------*/
            if (cbOrdenarPor.SelectedItem.ToString() == "Data de contratação mais recente")
            {
               // dataGridViewFuncionarios.Sort(cONTRATACAODataGridViewTextBoxColumn, descending);
            }
            if(cbOrdenarPor.SelectedItem.ToString() == "Data de contratação menos recente")
            {
                //dataGridViewFuncionarios.Sort(cONTRATACAODataGridViewTextBoxColumn, ascending);
            }

            /*----------------------------------------------------------------------------*/

            if (cbOrdenarPor.SelectedItem.ToString() == "Salário Decrescente")
            {
               // dataGridViewFuncionarios.Sort(sALARIODataGridViewTextBoxColumn, descending);
            }
            if (cbOrdenarPor.SelectedItem.ToString() == "Salário Crescente")
            {
               // dataGridViewFuncionarios.Sort(sALARIODataGridViewTextBoxColumn, ascending);
            }

        }

        private void dataGridViewFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void setDataGridView()
        {
            List<Funcionario> fLista = Funcionario.ListarFuncionarios();

            dataGridViewFuncionarios.Columns.Add("id", "id");
            dataGridViewFuncionarios.Columns.Add("nome", "nome");
            dataGridViewFuncionarios.Columns.Add("cpf", "cpf");
            dataGridViewFuncionarios.Columns.Add("rg", "rg");
            dataGridViewFuncionarios.Columns.Add("telefone", "telefone");
            dataGridViewFuncionarios.Columns.Add("nascimento", "nascimento");
            dataGridViewFuncionarios.Columns.Add("cep", "cep");
            dataGridViewFuncionarios.Columns.Add("logradouro", "rua");
            dataGridViewFuncionarios.Columns.Add("bairro", "bairro");
            dataGridViewFuncionarios.Columns.Add("numero", "numero");
            dataGridViewFuncionarios.Columns.Add("cidade", "cidade");
            dataGridViewFuncionarios.Columns.Add("estado", "estado");
            dataGridViewFuncionarios.Columns.Add("complemento", "complemento");
            dataGridViewFuncionarios.Columns.Add("cargo", "cargo");
            dataGridViewFuncionarios.Columns.Add("carga_horaria", "carga horária");
            dataGridViewFuncionarios.Columns.Add("salario", "salario");
            dataGridViewFuncionarios.Columns.Add("dataContratacao", "data de contratação");
            dataGridViewFuncionarios.Columns.Add("login", "login");

            if (fLista != null && fLista.Count > 0)
            {
                foreach (Funcionario f in fLista)
                {
                    dataGridViewFuncionarios.Rows.Add(f.Id, f.Nome, f.Cpf, f.Rg, f.Telefone, f.Nascimento.ToString("dd/MM/yyyy"), f.Cep, f.Logradouro, f.Bairro, f.Numero, f.Cidade, f.Estado, f.Complemento, f.Cargo, f.CargaHoraria, f.Salario, f.DataContratacao.ToString("dd/MM/yyyy"), f.Login.Email);
                }
            }
            else
            {
                dataGridViewFuncionarios.Rows.Add("---", "---", "---", "---", "---", "---", "---", "---", "---", "---", "---", "---", "---", "---", "---", "---", "---");
            }


            dataGridViewFuncionarios.AllowUserToAddRows = false;
            dataGridViewFuncionarios.AllowUserToDeleteRows = false;
            dataGridViewFuncionarios.AllowUserToOrderColumns = true;
            dataGridViewFuncionarios.AllowDrop = false;
            dataGridViewFuncionarios.AllowUserToResizeColumns = false;
            //dataGridViewFuncionarios.Columns
            dataGridViewFuncionarios.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
    }
}
