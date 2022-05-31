Console.WriteLine("Digite a idade do aluno mais novo:");
int idademin = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite a idade do aluno mais velho:");
int idademax = Convert.ToInt32(Console.ReadLine());
double idademedia = 0.0;

idademedia = (idademin + idademax) / 2;

Console.WriteLine($"A idade média é:  {idademedia}");