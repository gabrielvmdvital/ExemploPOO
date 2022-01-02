using System;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa 
    {
        public int nota { get; set; }

    public override void apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome} e sou um aluno nota {nota}");
        }


    }
}