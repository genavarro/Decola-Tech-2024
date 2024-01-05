using ExemploExplorando.Models;


Pessoa p1 = new Pessoa(nome: "Geovanna", sobrenome: "Navarro");
Pessoa p2 = new Pessoa("Guilherme", "Borges");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();