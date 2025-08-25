public static class CalculoSaqueAniversario
{
    public static double CalculoSaque(double saldo)
    {
        double percentual = 0.0;
        double adicional = 0.0;

        if (saldo <= 500) { percentual = 0.50; }
        else if (saldo <= 1000) { percentual = 0.40; adicional = 50; }
        else if (saldo <= 5000) { percentual = 0.30; adicional = 150; }
        else if (saldo <= 10000) { percentual = 0.20; adicional = 650; }
        else if (saldo <= 15000) { percentual = 0.15; adicional = 1150; }
        else if (saldo <= 20000) { percentual = 0.10; adicional = 1900; }
        else { percentual = 0.05; adicional = 2900; }

        return (saldo * percentual) + adicional;
    }
}
