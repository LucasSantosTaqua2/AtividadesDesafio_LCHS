Console.Write("Digite o primeiro numero: ");
double n1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o segundo numero: ");
double n2 = Convert.ToDouble(Console.ReadLine());

double resto = n1 % n2;

if (n2 == 0){
    Console.WriteLine("Não é possivel realizar divisão por 0!");
}else{
    Console.Write($"O resto da divisão entre {n1} e {n2} é {resto}");
}
