using System;

namespace Modelos {

  class Impressora {

    public static void Imprimir(Object obj) {
      public static void Imprimir(Texto texto){
        Console.WriteLine("-----------------------------------------------;");
        Console.WriteLine(texto.Informe());
        Console.WriteLine("-----------------------------------------------");
      }
      public static void 
    }

    private static void Imprimir(Pessoa pessoa) {
      Console.WriteLine(
        "Nome: " + pessoa.Nome + "\n" +
        "CPF: " + pessoa.Cpf
      );
    }

    private static void Imprimir(Contato contato) {
      Console.WriteLine(
       contato.Informar()
      );
    }

    private static void Imprimir(Professor professor) {
      Console.WriteLine(
        "Codigo: " + professor.Codigo
      );
    }
    
    private static void Imprimir(Aluno aluno) {
      Console.WriteLine(
        "Matricula: " + aluno.Matricula + "\n" +
        "Periodo: " + aluno.Periodo
      );
    }

    private static void Imprimir(Disciplina disciplina) {
      Console.WriteLine(
        "Nome: " + disciplina.Nome + "\n" +
        "Semestre: " + disciplina.Semestre
      );
    }
    
  }

}