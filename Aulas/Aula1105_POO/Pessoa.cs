using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1105_POO
{
    abstract class Pessoa // classe abstracta para impedir que seja criada em qualquer lugar
    {
        // Atributos (utilizar "protected" ao inves de "private" para ficar visivel nas classes que herdar ela "filhas")
        private string nome;

        // Propriedade (não precisa do atributo)
        public string Nome
        {
            get => nome; //get { return nome; }
            set => nome = value; // set {nome = value;}
        }

        public string Cpf { get; private set; } //private para não permitir alterar


        // Construtores "ctro + Tab"
        public Pessoa()
        {

        }
        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public Pessoa( string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;


        }

    }
}
