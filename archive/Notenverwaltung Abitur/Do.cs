using System;
using System.Collections.Generic;
using System.Text;

public static class Do
{
    public static int MaxPunkte = 15;
    public static string[] Kurshalbjahre = new string[] { "Kurshalbjahr 12/I", "Kurshalbjahr 12/II", "Kurshalbjahr 13/I", "Kurshalbjahr 13/II" };
    public static string GE = "P";
    public static string MakeRegular(string text)
    {
        if (text.Contains(","))
        {
            int lengthVorkomma = text.Substring(0, text.IndexOf(",")).Length;
            return text + new String('0', lengthVorkomma + 3 - text.Length);
        }
        else return text + ",00";
    }
}
