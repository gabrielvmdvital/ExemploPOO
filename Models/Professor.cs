using System;
namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public double salario { get; set; }

        public override void apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome} e ganho {salario}");
        }

    }
}