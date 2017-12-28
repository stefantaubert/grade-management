namespace Notenverwaltung
{
    using System;
    using System.Collections.Generic;

    public class Notensammlung
    {
        public const short NotenMin = 0, NotenMax = 15;

        public const string EinheitNoten = "KMK";

        private static string[] Notenarray = new string[] { "6 ", "5-", "5 ", "5+", "4-", "4 ", "4+", "3-", "3 ", "3+", "2-", "2 ", "2+", "1-", "1 ", "1+" };

        public List<double> Noten
        {
            get;
            set;
        }

        //[System.Xml.Serialization.XmlIgnore]
        //public double Schnitt { get; set; }

        [System.Xml.Serialization.XmlIgnore]
        public string NotenString
        {
            get
            {
                string ausg = string.Empty;
                for (int i = 0; i < Noten.Count; i++)
                {
                    ausg += Noten[i].ToString() + ",";
                }

                return ausg.TrimEnd(',');
            }
            set
            {
                Noten = new List<double>(GetNoten(value));
            }
        }

        public Notensammlung()
        {
            Noten = new List<double>();
        }

        public double ArithmetischesMittel()
        {
            return ArithmetischesMittel(Noten);
        }

        public double ArithmetischesMittel(bool mitNan)
        {
            double tmp = ArithmetischesMittel();
            if (!mitNan && double.IsNaN(tmp))
            {
                tmp = 0;
            }

            return tmp;
        }

        public static double ArithmetischesMittel(string notenstring)
        {
            return ArithmetischesMittel(GetNoten(notenstring));
        }

        public static double ArithmetischesMittel(List<double> werte)
        {
            double summe = 0;
            foreach (double item in werte)
            {
                summe += item;
            }
            return summe / (double)werte.Count;
        }

        public static string ConvertToString(double w, int dec)
        {
            return ConvertToString(w, dec, true);
        }

        public static string ConvertToString(double w, int dec, bool trimStart)
        {
            string g = string.Empty;

            if (dec > 0)
            {
                g += "." + new string('0', dec);
            }

            if (double.IsNaN(w) || w == 0)
            {
                return (trimStart ? "" : "0") + "0" + g;
            }
            else
            {
                g = "00" + g;
                g = string.Format("{0:" + g + "}", w);
                if (trimStart)
                {
                    g = g.TrimStart('0');
                }

                if (g.StartsWith(","))
                {
                    g = "0" + g;
                }

                return g;
            }
        }

        /// <summary>1,3254</summary>
        public static double GetNote(double punkte)
        {
            return ((-1.0 / 3.0) * punkte) + (17.0 / 3.0);
        }

        /// <summary>1,2,3,4,5,6</summary>
        public static int GetNoteFull(double punkte)
        {
            return Convert.ToInt32(GetNoteMitZeichen(punkte).Substring(0, 1));
        }

        /// <summary>1+,1,1-,...</summary>
        public static string GetNoteMitZeichen(double punkte)
        {
            if (double.IsNaN(punkte)) punkte = 0;
            return Notenarray[(int)Math.Round(punkte, MidpointRounding.AwayFromZero)];
        }

        private static List<double> GetNoten(string text)
        {
            //   string[] noten = text.Split(',');
            List<double> ausg = new List<double>();
            double note;

            foreach (string item in text.Split(','))
            {
                if (Double.TryParse(item, out note) && (note <= NotenMax && note >= NotenMin))
                {
                    ausg.Add(note);
                }
            }

            //    if (Char.IsDigit(item))
            //    {
            //        note = Convert.ToDouble(item);
            //        if (note <= NotenMax && note >= NotenMin)
            //        {
            //            ausg.Add((double)item);
            //        }
            //    }
            //}
            //for (int i = 0; i < noten.Length; i++)
            //{
            //    if (noten[i].Trim() != string.Empty)
            //    {
            //        try
            //        {
            //            note = Convert.ToDouble(noten[i].ToString());
            //        }
            //        catch
            //        {
            //            note = -1;
            //        }

            //        if (note <= NotenMax && note >= NotenMin)
            //        {
            //            ausg.Add(note);
            //        }
            //    }
            //}

            return ausg;
        }
    }
}