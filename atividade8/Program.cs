Console.Write("Digite o primeiro numero: ");
double n1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o segundo numero: ");
double n2 = Convert.ToDouble(Console.ReadLine());

double v = n1 - n2;

if( v < 0){
    Console.WriteLine($"Valor negativo! O valor é: {v}");
}else if(v > 0){
    Console.WriteLine($"Valor positivo! O valor é: {v}");
}else {
    Console.WriteLine("Valor Zero!");
}