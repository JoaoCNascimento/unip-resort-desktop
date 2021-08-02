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
    public partial class FormConsultarFuncionarios : Form
    {
        public FormConsultarFuncionarios()
        {
            InitializeComponent();
        }

        private void FormConsultarFuncionarios_Load(object sender, EventArgs e)
        {

        }

        private void cbOrdenarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Define os tipos de sorts da tabela
            ListSortDirection ascending, descending;
            ascending = ListSortDirection.Ascending;
            descending = ListSortDirection.Descending;

            if (cbOrdenarPor.SelectedItem.ToString() == "Nome (Alfabética)")
            {
                //dataGridViewFuncionarios.Sort(nOMEDataGridViewTextBoxColumn, ascending);
            }

            /*----------------------------------------------------------------------------*/

            if (cbOrdenarPor.SelectedItem.ToString() == "ID Crescente")
            {
                //dataGridViewFuncionarios.Sort(iDDataGridViewTextBoxColumn, ascending);
            }
            if(cbOrdenarPor.SelectedItem.ToString() == "ID Decrescente")
            {
                //dataGridViewFuncionarios.Sort(iDDataGridViewTextBoxColumn, descending);
            }

            /*----------------------------------------------------------------------------*/

            if (cbOrdenarPor.SelectedItem.ToString() == "Data de nascimento crescente")
            {
                //dataGridViewFuncionarios.Sort(nASCIMENTODataGridViewTextBoxColumn, ascending);
            }
            if(cbOrdenarPor.SelectedItem.ToString() == "Data de nascimento decrescente")
            {
                //dataGridViewFuncionarios.Sort(nASCIMENTODataGridViewTextBoxColumn, descending);
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
    }
}
