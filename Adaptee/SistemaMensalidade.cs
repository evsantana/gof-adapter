using Adapter.Domain;

namespace Adapter.Adaptee;

public class SistemaMensalidades
{
    public void CalculaMensalidade(List<Aluno> listaAlunos)
    {
        foreach(Aluno aluno in listaAlunos)
        {
            Console.WriteLine($"Aluno {aluno.Nome} " +
                $" - Valor da Mensalidade R$ {aluno.Mensalidade}");
        }
    }
}
