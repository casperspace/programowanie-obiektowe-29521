// See https://aka.ms/new-console-template for more information



class KontoBankowe
{
    private double saldo;
    public void Wplata(double kwota) { saldo += kwota; }
    public void Wyplata(double kwota) {saldo >= kwota; }
    public double PobierzSaldo() { return saldo; }
}


class Zwierze
{
    public void Jedz() => Console.WriteLine("Zwierzę je");
}
class Pies : Zwierze
{
    public void Szczekaj() => Console.WriteLine("Hau hau!");
}

class Kot : Zwierze
{
    public void Miaucz() => Console.WriteLine("Miau!");
}