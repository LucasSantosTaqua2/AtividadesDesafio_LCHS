Console.Write("Digite sua altura para calcular o peso ideal: ");
double h = Convert.ToDouble(Console.ReadLine());

double pi = (72.7 * h) - 58;

Console.WriteLine($"Seu peso ideal é {pi}");