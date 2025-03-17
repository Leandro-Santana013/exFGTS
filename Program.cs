// See https://aka.ms/new-console-template for more information
Console.WriteLine("digite seu salário pra calcular o FGTS: ");
double salario = double.Parse(Console.ReadLine());
double fgts = salario * 0.08;
Console.WriteLine($"O valor do FGTS é: {fgts}");
