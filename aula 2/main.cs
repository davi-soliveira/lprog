using System;

class aula2{
  public struct Aluno{
    public string matricula;
    public int periodo;
  }
  public struct Disciplina {
    public string nome;
    public int semestre;
  }
  public static bool Matricular(
    Aluno aluno,
    Disciplina disciplina
    ){
    return aluno.periodo == disciplina.semestre;
  }
  public static void Main(string[] args){
    Aluno aluno = new Aluno{
      matricula = "0",
      periodo = 1
    };
    Disciplina disciplina = new Disciplina{
      nome="programação",
      Semestre = 3
    };
    bool matricular = Matricular(aluno,disciplina);
    Console.WriteLine(matricular);
  }
}