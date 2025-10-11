class KontoBankowe
{
    private double saldo;
    public void Wplata(double kwota) { saldo += kwota; }
    public double PobierzSaldo() { return saldo; }
}