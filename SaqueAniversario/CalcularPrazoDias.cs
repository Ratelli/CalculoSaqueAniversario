// public static int CalcularPrazoDias(int mesAniversario)
// {
//     DateTime dataAtual = DateTime.Now;
//     int anoAtual = dataAtual.Year;

//     //Para travar o dia de aniversario sempre no dia 1, que é o dia que o fgts quita o saldo devedor
//     DateTime proximoAniversario = new DateTime(anoAtual, mesAniversario, 1);

//     if (proximoAniversario <= dataAtual)
//     {
//         proximoAniversario = proximoAniversario.AddYears(1);
//     }
//     return (proximoAniversario - dataAtual).Days;
// }