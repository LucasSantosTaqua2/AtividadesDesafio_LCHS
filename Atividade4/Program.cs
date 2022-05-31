Console.Write("Digite a temperatura em graus celsius para converter Fahrenheit: ");
double tempc = Convert.ToDouble(Console.ReadLine());
double tempf = (9*tempc+160) / 5;

Console.WriteLine($"A temperatura de {tempc} °C em Fahrenheit é: {tempf} °F");