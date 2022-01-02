using System;
using ExemploPOO.Models;
using ExemploPOO.Interfaces;
using ExemploPOO.Helper;


namespace ExemploPOO
{
    class Program
    {


        static void Main(string[] args)
        {
            FileHelper helper = new FileHelper();

            var caminho = "C:\\Users\\victo\\OneDrive\\Área de Trabalho\\testedotnet";
            var caminhoPathComb = Path.Combine(caminho, "pasta teste3", "sub pasta teste3");
            var caminhoArquivo = Path.Combine(caminho, "arquivoTeste-Stream.txt");
            var novoCaminho = Path.Combine(caminho, "Nova pasta", "arquivoTeste-Stream.txt");
            var listaString = new List<string> {"linha 0", "linha 1", "linha 2"};
            var listaString2 = new List<string> {"linha 3", "linha 4", "linha 5"};

            // helper.ListarDiretorios(caminho);
            // helper.ListarArquivosDiretorios(caminho);
            // helper.CriarDiretorio(caminhoPathComb);
            // helper.ApagarDiretorio(caminhoPathComb, true);
            // helper.CriarArquivoTexto(caminhoArquivo, "Teste de escrita de arquivo");
           //  helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            // helper.AdicionarTextoStream(caminhoArquivo, listaString2);
           // helper.LerArquivoStream(caminhoArquivo);
           // helper.MoverArquivo(caminhoArquivo, novoCaminho);
           // helper.CopiarArquivo(novoCaminho, caminhoArquivo, false);
          //  helper.DeletarArquivo(novoCaminho);


            // ICalculadora calc = new Calculadora();

            // System.Console.WriteLine(calc.Somar(10, 20));

            // Computador comp = new Computador();

            // System.Console.WriteLine(comp.ToString());
            // Corrente c = new Corrente();
            // c.Creditar(100);

            // c.ExibirSaldo();

            // Calculadora cal = new Calculadora();

            // System.Console.WriteLine($"Resultado da primeira soma: {cal.Somar(10,20)}");
            // System.Console.WriteLine($"Resultado da segunda soma: {cal.Somar(10,20,30)}");

            // retangulo r = new retangulo();
            
            // r.DefinirMedidas(10, 20);
            // System.Console.WriteLine($"Área: {r.ObterArea()}");


            // Aluno a1 = new Aluno();
            // a1.Nome = "Bob";
            // a1.Idade = 20;
            // a1.Documento = "123456789";
            // a1.nota = 10;
            // a1.apresentar();

            // Professor p1 = new Professor();

            // p1.Nome = "Marcelo";
            // p1.Documento = "123445678";
            // p1.salario = 2000;
            // p1.Idade = 30;
            // p1.apresentar();


            // Pessoa p1 = new Pessoa();
            // p1.Nome = "Maria";
            // p1.Idade = 22;
            
            // p1.apresentar();

            // Pessoa p2 = new Pessoa();
            // p2.Nome = "João";
            // p2.Idade = 22;

            // p2.apresentar();


        }

    }



}