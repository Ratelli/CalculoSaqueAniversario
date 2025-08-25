
// public static double CalculoAntecipacao(double saqueSemJuros, int mesAniversario)
// {
//     double taxaMensal = 0.0179; // 1,79% ao mês
//     double taxaDiaria = Math.Pow(1 + taxaMensal, 1.0 / 30) - 1;
//     int prazoDias = CalcularPrazoDias(mesAniversario);
//     double vp = saqueSemJuros / Math.Pow(1 + taxaDiaria, prazoDias);
//     double tarifa = saqueSemJuros * (0.0038 + 0.000082 * (prazoDias / 30.0));
//     return vp - tarifa;
// }