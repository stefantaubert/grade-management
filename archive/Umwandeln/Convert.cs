using System;
using System.Collections.Generic;
using System.Text;
using Notenverwaltung;

namespace Umwandeln
{
    class Convert
    {
        public void Umwandeln()
        {
            Zentrale z = new Zentrale();
            z.Load();
            Verwaltung v = new Verwaltung();
            v.Inizialize(true);
            Arbeit a;
            for (int i = 0; i < z.Fächer.Count; i++)
            {
                v.FachAdd(z.Fächer[i].Name, z.Fächer[i].Klausurschema == Wert.doppelwertig);
                for (int j = 0; j < z.Fächer[i].Kurshalbjahre.Count; j++)
                {
                    v.HalbjahrIndex = j;
                    for (int k = 0; k < z.Fächer[i].Kurshalbjahre[j].Arbeiten.Count; k++)
                    {
                        a = z.Fächer[i].Kurshalbjahre[j].Arbeiten[k];
                        if (a.Wertigkeit == Wert.einwertig)
                            v.KleineNoten[i].Noten.Add(a.Punkte);
                        else
                            v.GroßeNoten[i].Noten.Add(a.Punkte);
                    }
                }
            }
            v.HalbjahrIndex = z.XmlIndexHJ;
            v.FachIndex = z.XmlIndexFach;
            v.Save();
        }
        public void UmwandelnVerw()
        {
            Zentrale z = new Zentrale();
            z.Load();
            Verw v = new Verw();
            for (int i = 0; i < z.Fächer.Count; i++)
            {
                v.IndexFach = v.Add(z.Fächer[i].Name, z.Fächer[i].Klausurschema == Wert.doppelwertig);
                for (int j = 0; j < z.Fächer[i].Kurshalbjahre.Count; j++)
                {
                    v.IndexJahr = j;
                    for (int k = 0; k < z.Fächer[i].Kurshalbjahre[j].Arbeiten.Count; k++)
                    {
                        Arbeit a = z.Fächer[i].Kurshalbjahre[j].Arbeiten[k];
                        if (a.Wertigkeit == Wert.einwertig)
                        {
                            v.AktuellesFach.NotenKlein[v.IndexJahr].Noten.Add(a.Punkte);
                        }
                        else
                        {
                            v.AktuellesFach.NotenGroß[v.IndexJahr].Noten.Add(a.Punkte);
                        }
                    }
                }
            }

            v.IndexJahr = z.XmlIndexHJ;
            v.IndexFach = z.XmlIndexFach;
            v.Save();
        }
    }
}
