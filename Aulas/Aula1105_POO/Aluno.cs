using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1105_POO
{
    class Aluno : Pessoa
    {
       // Construtores "ctro + Tab"

        public Aluno()
        {

        }

        public Aluno(string nome) : base(nome) // base para herdar a classe mãe
        {
            Nome = nome;
        }

        public Aluno(string nome, string cpf) : base (nome, cpf)
            {
          
            }

    }
}
