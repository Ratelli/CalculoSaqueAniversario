double CalculoAntecipacao(double saqueSemJuros, int mesAniversario)
{
    double taxaMensal = 0.0179; // 1,79% ao mês
    double taxaDiaria = Math.Pow(1 + taxaMensal, 1.0 / 30) - 1;
    int prazoDias = CalcularPrazoDias(mesAniversario);
    double vp = saqueSemJuros / Math.Pow(1 + taxaDiaria, prazoDias);
    double tarifa = saqueSemJuros * (0.0038 + 0.000082 * (prazoDias / 30.0));
    return vp - tarifa;
}

int CalcularPrazoDias(int mesAniversario)
{
    DateTime dataAtual = DateTime.Now;
    int anoAtual = dataAtual.Year;

    //Para travar o dia de aniversario sempre no dia 1, que é o dia que o fgts quita o saldo devedor
    DateTime proximoAniversario = new DateTime(anoAtual, mesAniversario, 1);

    if (proximoAniversario <= dataAtual)
    {
        proximoAniversario = proximoAniversario.AddYears(1);
    }
    return (proximoAniversario - dataAtual).Days;
}

// Console.Write("Digite o saldo inicial do FGTS: ");
// double saldo = double.Parse(Console.ReadLine());

// Console.Write("Digite o mês do seu aniversário (1 a 12): ");
// int mesAniversario = int.Parse(Console.ReadLine());

// var saquePorAno = new ListaGenerica<double>(10);

// Console.WriteLine("\nSimulação do Saque-Aniversário por 10 anos:\n");

// for (int ano = 1; ano <= 10; ano++)
// {
//     double saque = CalculoSaqueAniversario.CalculoSaque(saldo);
//     saque = Math.Round(saque, 2); // arredonda para 2 casas decimais
//     saquePorAno.Adicionar(saque);
//     saldo -= saque; // desconta o saque do saldo

//     Console.WriteLine($"Ano {ano}: Saque = R$ {saque:F2}, Saldo Restante = R$ {saldo:F2}");
// }

// Console.WriteLine(saquePorAno.Ler(0));
// Console.WriteLine(saquePorAno.Ler(1));
// Console.WriteLine(saquePorAno.Ler(2));
// Console.WriteLine(saquePorAno.Ler(3));
// Console.WriteLine(saquePorAno.Ler(4));
// Console.WriteLine(saquePorAno.Ler(5));
// Console.WriteLine(saquePorAno.Ler(6));
// Console.WriteLine(saquePorAno.Ler(7));
// Console.WriteLine(saquePorAno.Ler(8));
// Console.WriteLine(saquePorAno.Ler(9));





//CODIGO CHAT GPT
Console.Write("Digite o saldo inicial do FGTS: ");
double saldo = double.Parse(Console.ReadLine());

Console.Write("Digite o mês do seu aniversário (1 a 12): ");
int mesAniversario = int.Parse(Console.ReadLine());

var saquePorAno = new ListaGenerica<double>(10);

Console.WriteLine("\nSimulação do Saque-Aniversário por 10 anos:\n");

for (int ano = 1; ano <= 10; ano++)
{
    double saque = CalculoSaqueAniversario.CalculoSaque(saldo);
    saque = Math.Round(saque, 2); // garante 2 casas decimais
    saquePorAno.Adicionar(saque);

    saldo -= saque; // desconta do saldo

    Console.WriteLine($"Ano {ano}: Saque = R$ {saque:F2}, Saldo Restante = R$ {saldo:F2}");
}

// Agora calcula antecipação para cada saque armazenado
Console.WriteLine("\nSimulação de Antecipação dos Saques:\n");

for (int i = 0; i < saquePorAno._contador; i++)
{
    double saqueSemJuros = saquePorAno.Ler(i);
    double antecipado = CalculoAntecipacao(saqueSemJuros, mesAniversario);

    Console.WriteLine($"Ano {i + 1}: Saque sem juros = R$ {saqueSemJuros:F2}, Valor antecipado = R$ {antecipado:F2}");
}
