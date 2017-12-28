using System;
using System.Collections.Generic;
using System.Text;

public class Kurshalbjahr
{
    List<Arbeit> _arbeiten = new List<Arbeit>();
    public List<Arbeit> Arbeiten { get { return _arbeiten; } set { _arbeiten = value; } }

    Wert _klausurschema = Wert.doppelwertig;
    public Wert Klausurschema { get { return _klausurschema; } set { _klausurschema = value; } }

    public int GetAnzahlGleicherPunkte(int punkte)
    {
        int ausg = 0;
        foreach (var item in _arbeiten)
            if (item.Punkte == punkte)
                ausg++;
        return ausg;
    }
    public double PunkteDurchschnittLK
    {
        get
        {
            double anz = 0, gesP = 0;
            foreach (var item in _arbeiten)
            {
                if (item.Wertigkeit == Wert.einwertig)
                {
                    anz++;
                    gesP += item.Punkte;
                }
            }
            if (gesP == 0) return 0;
            return gesP / anz;
        }
    }
    public double PunkteDurchschnittKA
    {
        get
        {
            double anz = 0, gesP = 0;
            foreach (var item in _arbeiten)
            {
                if (item.Wertigkeit != Wert.einwertig)
                {
                    anz++;
                    gesP += item.Punkte;
                }
            }
            if (gesP == 0) return 0;
            return gesP / anz;
        }
    }

    public double PunkteDurchschnitt
    {
        get
        {
            if (ArbeitenCount == 0) return 0;
            if (_klausurschema == Wert.hälfte)
            {
                double gesPKlein = 0, gesArbKlein = 0, drchKlei = 0, gesPGroß = 0, gesArbGroß = 0, drchGroß = 0, ausg = 0;
                foreach (var item in _arbeiten)
                {
                    if (item.Wertigkeit == Wert.einwertig)
                    {
                        gesPKlein += item.Punkte;
                        gesArbKlein++;
                    }
                    else if (item.Wertigkeit == Wert.hälfte)
                    {
                        gesPGroß += item.Punkte;
                        gesArbGroß++;
                    }
                    else
                    { /*fail*/}
                }
                if (gesArbKlein != 0) drchKlei = gesPKlein / gesArbKlein;
                if (gesArbGroß != 0) drchGroß = gesPGroß / gesArbGroß;

                if (gesArbGroß != 0 && gesArbKlein != 0)
                    ausg = (drchKlei + drchGroß) / 2;
                else if (gesArbGroß == 0 && gesArbKlein == 0)
                    ausg = 0;
                else if (gesArbGroß != 0)
                    ausg = drchGroß;
                else if (gesArbKlein != 0)
                    ausg = drchKlei;
                else
                { /*fail*/}

                return Math.Round(ausg, 2);
            }
            else
            {
                double gesArb = 0, gesP = 0, ausg = 0;
                foreach (var item in _arbeiten)
                {
                    if (item.Wertigkeit == Wert.einwertig)
                    {
                        gesArb++;
                        gesP += item.Punkte;
                    }
                    else if (item.Wertigkeit == Wert.doppelwertig)
                    {
                        gesArb += 2;
                        gesP += 2 * item.Punkte;
                    }
                    else
                    { /*fail*/}
                }
                if (gesArb != 0) ausg = gesP / gesArb;
                else ausg = 0;
                return Math.Round(ausg, 2);
            }
        }
    }
    public string Zensur
    {
        get
        {
            Arbeit arb = new Arbeit();
            arb.Punkte = (int)Math.Round(PunkteDurchschnitt, 0);
            return arb.Zensur;
        }
    }

    public int ProzentWissen
    {
        get
        {
            return (int)Math.Round((double)PunkteMax / 100 * (double)PunkteErreicht, 0);
        }
    }
    public int PunkteMax
    {
        get
        {
            int ausg = 0;
            foreach (var item in _arbeiten)
            {
                if (item.Wertigkeit == Wert.doppelwertig)
                    ausg += 2;
                else ausg++;
            }
            return ausg * Do.MaxPunkte;
        }
    }
    public double PunkteErreicht
    {
        get
        {
            double ausg = 0;
            foreach (var item in _arbeiten)
            {
                if (item.Wertigkeit == Wert.doppelwertig)
                    ausg += item.Punkte * 2;
                else ausg += item.Punkte;
            }
            return ausg;
        }
    }
    public int ArbeitenCount
    {
        get
        {
            return _arbeiten.Count;
        }
    }
    public bool Unterpunktet
    {
        get { return _arbeiten.Count > 0 && Math.Round(PunkteDurchschnitt, 0) < 5; }
    }
}
