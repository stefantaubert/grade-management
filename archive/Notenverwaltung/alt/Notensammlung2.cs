using System;
using System.Collections.Generic;
using System.Text;

namespace Notenverwaltung
{
    public class NotensammlungTextSave
    {
        //  List<double> noten = new List<double>();
        // [System.Xml.Serialization.XmlIgnore]
        private List<double> Noten
        {
            get
            {
                List<double> asug = GetNoten(NotenString);
                return asug;
            }
        }

        public NotensammlungTextSave()
        {
            NotenString = "";
        }
        string noten = "";
        public string NotenString
        {
            get
            {
                return noten;
            }
            set
            {
                noten = value;
                string tmp = "";
                for (int i = 0; i < Noten.Count; i++)
                    tmp += Noten[i].ToString() + ",";
                noten = tmp;
            }
        }
        List<double> GetNoten(string text)
        {
            string[] noten = text.Split(',');
            List<double> ausg = new List<double>();
            double note;
            for (int i = 0; i < noten.Length; i++)
            {
                try
                {
                    note = Convert.ToDouble(noten[i].ToString());
                }
                catch { note = -1; }
                if (note < 16 && note >= 0)
                    ausg.Add(note);
            }
            return ausg;
        }

        public double GetMittel() { return ArithmetischesMittel(Noten); }
        public static double ArithmetischesMittel(List<double> werte)
        {
            double summe = 0;
            foreach (double item in werte)
                summe += item;
            return summe / (double)werte.Count;
        }
        public static string ConvertToString(double wert)
        {
            if (double.IsNaN(wert)) return "0,00";
            wert = Math.Round(wert, 2);
            string wer = wert.ToString();
            if (wer.Contains(",")) return wer + new String('0', 3 - wer.Substring(wer.LastIndexOf(',')).Length);
            else return wert.ToString() + ",00";
        }
    }
}
