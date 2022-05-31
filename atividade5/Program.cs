Console.Write("Digite a temperatura em graus Fahrenheit para converter em graus Celsius: ");
double tempf = Convert.ToDouble(Console.ReadLine());
double tempc = (tempf - 32) * 5/9;

Console.WriteLine($"A temperatura de {tempf} °F em Celsius é: {tempc} °C");