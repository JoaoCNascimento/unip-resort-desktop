using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoUnipResort.Classes
{
    class Quarto
    {

        public string foto;
        public string categoria;
        public string descricao;
        public int andar;
        public int numero;
        public float valor;

        public Quarto(string foto, string categoria, string descricao, int andar, int numero, float valor)
        {
            this.foto = foto;
            this.categoria = categoria;
            this.descricao = descricao;
            this.andar = andar;
            this.numero = numero;
            this.valor = valor;
        }
    }
}
