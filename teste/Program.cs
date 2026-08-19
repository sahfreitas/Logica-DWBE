int dia, mes, ano;

Console.WriteLine("Digite o ano de nascimento:");
ano = int.Parse(Console.ReadLine());

while (ano < 1906 || ano > 2026)
{
    Console.WriteLine("Ano inválido!");
    Console.WriteLine("Digite novamente o ano de nascimento:");
    ano = int.Parse(Console.ReadLine());
}


Console.WriteLine("Digite o mês de nascimento:");
mes = int.Parse(Console.ReadLine());

while (mes < 1 || mes > 12 || (ano == 2026 && mes > 8))
{
    Console.WriteLine("Mês inválido!");
    Console.WriteLine("Digite novamente o mês:");
    mes = int.Parse(Console.ReadLine());
}


Console.WriteLine("Digite o dia de nascimento:");
dia = int.Parse(Console.ReadLine());

int maxDias;

if (mes == 2)
{
    if (ano % 400 == 0 || (ano % 4 == 0 && ano % 100 != 0))
    {
        maxDias = 29;
    }
    else
    {
        maxDias = 28;
    }
}

else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
{
    maxDias = 30;
}

else
{
    maxDias = 31;
}


while (dia < 1 || dia > maxDias)
{
    Console.WriteLine("Dia inválido!");
    Console.WriteLine("Digite novamente o dia de nascimento:");
    dia = int.Parse(Console.ReadLine());
}


Console.WriteLine();
Console.WriteLine("Data de nascimento válida!");
Console.WriteLine($"Data: {dia}/{mes}/{ano}");
