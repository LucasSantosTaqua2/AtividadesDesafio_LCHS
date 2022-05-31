Console.WriteLine("Calcular media da nota do aluno!");
Console.Write("Insira a primeira nota: ");
double n1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Insira a segunda nota: ");
double n2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Insira a terceira nota: ");
double n3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Insira a quarta nota: ");
double n4 = Convert.ToDouble(Console.ReadLine());

double media = (n1 + n2 + n3 + n4) / 4;

Console.WriteLine($"A média do aluno é {media}");

if (media > 7 ){
    Console.WriteLine("O aluno foi APROVADO!");
} else{
    Console.WriteLine("O aluno foi REPROVADO");
}