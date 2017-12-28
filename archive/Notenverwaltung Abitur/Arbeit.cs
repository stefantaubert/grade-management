using System;
using System.Text;

public class Arbeit
{
    string[] _notenarray = new string[]{
                    "6","5-","5","5+","4-", "4","4+","3-","3","3+","2-","2","2+","1-","1","1+"
                };
    string _bez;
    public string Thema { get { return _bez; } set { _bez = value; } }
    double _punkte = 0;
    public double Punkte { get { return _punkte; } set { _punkte = value; } }
    DateTime _datum = DateTime.Now;
    public DateTime Datum { get { return _datum; } set { _datum = value; } }
    Wert _wertigkeit = Wert.einwertig;
    public Wert Wertigkeit { get { return _wertigkeit; } set { _wertigkeit = value; } }

    public string Zensur
    {
        get
        {
            return _notenarray[(int)Math.Round(_punkte, 0)];
        }
    }
}
