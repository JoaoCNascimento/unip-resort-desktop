using GestaoUnipResort.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoUnipResort.Classes
{
    class Funcionario : Pessoa
    {

        static string Route = "funcionario";

        public string Cargo { get; set; }
        public double Salario { get; set; }
        public double CargaHoraria { get; set; }
        public DateTime DataContratacao { get; set; } 
        public Login Login { get; set; }

        public Funcionario (
            long id
            ,string nome
            ,string cpf
            ,string rg,
            string telefone
            ,DateTime nascimento
            ,string cep
            ,string sexo
            ,string email_pessoal
            ,string logradouro
            ,string bairro
            ,string numero
            ,string cidade
            ,string estado
            ,string complemento
            ,string cargo
            ,double salario
            ,double cargaHoraria
            ,DateTime dataContratacao
            ,Login login
        ) : base(id, nome, cpf, rg, telefone, nascimento, cep, sexo, email_pessoal, logradouro, bairro, numero, cidade, estado, complemento)
        {
            this.Cargo = cargo;
            this.Salario = salario;
            this.CargaHoraria = cargaHoraria;
            this.DataContratacao = dataContratacao;
            this.Login = login;
        }

        public static List<Funcionario> ListarFuncionarios()
        {
            API api = new API();
            return JsonConvert.DeserializeObject<List<Funcionario>>(api.getMethod(Route));
        }
    }
}
