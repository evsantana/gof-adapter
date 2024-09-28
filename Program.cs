// See https://aka.ms/new-console-template for more information
using Adapter.Adapter;
using Adapter.Target;

Console.WriteLine("Hello, World!");

string[,] alunosArray = new string[5,4]
{
    {"101", "Maria", "Artes", "1000"},
    {"101", "Maria", "Artes", "2000"},
    {"101", "Maria", "Artes", "3000"},
    {"101", "Maria", "Artes", "4000"},
    {"101", "Maria", "Artes", "5000"},
};

ITarget target = new AlunoAdapter();

Console.WriteLine("SistemaMensalidades passa o array de string para o Adapter\n");

target.ProcessaCalculoMensalidade(alunosArray);
Console.ReadKey();