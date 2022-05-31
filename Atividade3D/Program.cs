Console.WriteLine("Digite o valor do produto:");
int vv = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a comissão do funcionario");
int qc = Convert.ToInt32(Console.ReadLine());

double comissao = vv * qc/100;

Console.WriteLine($"A comissão do funcionario é: {comissao} reais");