﻿using System;

namespace Aula1105_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            a.Nome = "Godofredo"; //set
            //a.Cpf = "12345678909"; comentado por causa do "private set"
            Console.WriteLine("Aluno:" + a.Nome); // get

            Aluno b = new Aluno("Ju", "123");
            Aluno c = new Aluno("Marcinho");

        }
    }
}
