using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoUnipResort.Classes
{
    class Pessoa
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Telefone { get; set; }
        public DateTime Nascimento { get; set; }
        public string Cep { get; set; }
        public string Sexo { get; set; }
        public string EmailPessoal { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Complemento { get; set; }

        public Pessoa(long id, string nome, string cpf, string rg, string telefone, 
            DateTime nascimento, string cep, string sexo, string emailPessoal, string logradouro, 
            string bairro, string numero, string cidade, string estado, string complemento)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            Telefone = telefone;
            Nascimento = nascimento;
            Cep = cep;
            Sexo = sexo;
            EmailPessoal = emailPessoal;
            Logradouro = logradouro;
            Bairro = bairro;
            Numero = numero;
            Cidade = cidade;
            Estado = estado;
            Complemento = complemento;
        }
    }
}
