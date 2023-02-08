using System;
using System.Collections.Generic;
using System.IO;

class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public float Nota { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Aluno> alunos = new List<Aluno>();

        // Adicionando nomes, idade e notas
        alunos.Add(new Aluno { Nome = "João", Idade = 18, Nota = 9.5f });
        alunos.Add(new Aluno { Nome = "Maria", Idade = 19, Nota = 8.0f });
        alunos.Add(new Aluno { Nome = "Pedro", Idade = 20, Nota = 7.5f });

        // Gravar dados CSV
        using (StreamWriter writer = new StreamWriter("alunos.csv"))
        {
            writer.WriteLine("Nome,Idade,Nota");
            foreach (Aluno aluno in alunos)
            {
                writer.WriteLine("{0},{1},{2}", aluno.Nome, aluno.Idade, aluno.Nota);
            }
        }

        // Exibir dados
        Console.WriteLine("Nome - Idade - Nota");
        foreach (Aluno aluno in alunos)
        {
            Console.WriteLine("{0}, - {1}, - {2} - ", aluno.Nome, aluno.Idade, aluno.Nota);
        }
    }
}