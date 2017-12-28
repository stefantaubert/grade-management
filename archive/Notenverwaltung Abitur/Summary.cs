using System;
using System.Collections.Generic;
using System.Text;

public static class Summary
{
    /*
Gesamtdurchschnitt: 12,43P = 2+ = 89%
Durchschnitt Klausuren: 13,43P = 2+ = 99%
Durchschnitt Leistungskontrollen: 13,43P = 2+ = 99%

Vorkommen der Punkte:
15P: 2x
14P: 2x
...
1P: 2x
0P: 0x

Fächerreihnfolge (bestes-schlechtestes):
Mathe (12P), Bio (13P), Info (9P), Sport, Kunst, Mathe

Unterpunktete Fächer (6):
1. Deutsch mit 3P (12/I)
2. Deutsch (12/II)
3. Info (13/II)
     */
    public static string MakeSummary(List<Fach> fächers)
    {
        string ausg = "";
        Kurshalbjahr alleArbeiten = new Kurshalbjahr();
        for (int i = 0; i < fächers.Count; i++)
        {
            foreach (var item in fächers[i].Kurshalbjahre)
                alleArbeiten.Arbeiten.AddRange(item.Arbeiten);
        }
        ausg += "Gesamtdurchschnitt: " + GleichungMachen(alleArbeiten.PunkteDurchschnitt);
        ausg += "\nDurchschnitt Leistungskontrollen: " + GleichungMachen(alleArbeiten.PunkteDurchschnittLK);
        ausg += "\nDurchschnitt Klausuren: " + GleichungMachen(alleArbeiten.PunkteDurchschnittKA);
        ausg += "\n\nVorkommen der Punkte:\n";
        for (int i = 0; i < Do.MaxPunkte+1; i++)
            ausg += (Do.MaxPunkte - i).ToString() + Do.GE + ": " + alleArbeiten.GetAnzahlGleicherPunkte(Do.MaxPunkte - i) + "x\n";
        ausg += "\nFächerreihnfolge (bestes-schlechtestes):\n";
        ausg += GetReihnfolgeSkills(fächers);
        ausg += "\n\nUnterpunktete Fächer:";
        int zähler = 0;
        foreach (var item in fächers)
            for (int i = 0; i < item.Kurshalbjahre.Count; i++)
                if (item.Kurshalbjahre[i].Unterpunktet)
                {
                    zähler++;
                    ausg += "\n" + zähler.ToString() + ". " + item.Name + " mit " + Math.Round(item.Kurshalbjahre[i].PunkteDurchschnitt, 0) + Do.GE + " (" + Do.Kurshalbjahre[i].Replace("Kurshalbjahr ", "") + ")";
                }
        if (zähler == 0) ausg += "\nkeine";
        return ausg;
    }
    private static string GleichungMachen(double punnkte)
    {
        Arbeit a = new Arbeit();
        a.Punkte = punnkte;
        return Math.Round(punnkte, 2) + Do.GE + " = " + a.Zensur + " = " + Math.Round(a.Punkte / Do.MaxPunkte * 100, 2).ToString() + "%";
    }
    private static string GetReihnfolgeSkills(List<Fach> fächers)
    {
        string ausg = "";
        List<string> durchschnitte = new List<string>();
        List<int> indexes = new List<int>();

        for (int i = 0; i < fächers.Count; i++)
        {
            durchschnitte.Add(fächers[i].AlleArbeiten.PunkteDurchschnitt.ToString("00.00"));
            indexes.Add(i);
        }
        List<int> sort = GetSortedIndizes(durchschnitte);
        indexes = Zuordnen<int>(sort, indexes);

        for (int i = 0; i < indexes.Count; i++)
        {
            if (i > 0 && !((double)i / 3).ToString().Contains(",")) ausg += "\n";
            ausg += fächers[indexes[indexes.Count - 1 - i]].Name + " (" + Math.Round(fächers[indexes[indexes.Count - 1 - i]].AlleArbeiten.PunkteDurchschnitt, 2).ToString() + Do.GE + "), ";
        }
        return ausg.TrimEnd(' ', ','); ;
    }
    private static List<int> GetSortedIndizes(List<string> a)
    {
        List<int> ausg = new List<int>();
        List<string> tmpA = new List<string>(a);
        for (int i = 0; i < a.Count; i++) tmpA[i] += "_" + i.ToString(); tmpA.Sort();
        for (int i = 0; i < a.Count; i++) ausg.Add(Convert.ToInt32(tmpA[i].Substring(tmpA[i].LastIndexOf("_") + 1, -1 + tmpA[i].Length - tmpA[i].LastIndexOf("_"))));
        return ausg;
    }
    private static List<T> Zuordnen<T>(List<int> sortedSizes, List<T> liste)
    {
        List<T> tmp = new List<T>();
        if (sortedSizes.Count != liste.Count) return tmp;
        for (int i = 0; i < sortedSizes.Count; i++) tmp.Add(liste[sortedSizes[i]]);
        return tmp;
    }
}