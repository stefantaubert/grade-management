using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Notenverwaltung
{
    public class Verwaltung
    {
        static string _path = Application.StartupPath + "\\noten.xml";
        const string NichtMgl = "nicht durch eine Arbeit möglich";
        public const short HalbjahreCount = 4;

        public int FachIndex { get; set; }
        public int HalbjahrIndex { get; set; }
        public List<Halbjahr> Halbjahre { get; set; }
        public List<string> Fächer { get; set; }
        public List<bool> Doppelwertig { get; set; }

        private bool HjSelected { get { return (HalbjahrIndex >= 0 && HalbjahrIndex < Halbjahre.Count); } }

        [System.Xml.Serialization.XmlIgnore]
        public List<Notensammlung> KleineNoten
        {
            get
            {
                //  return 9 == 0 ? null : KleineNoten;
                if (HjSelected) return Halbjahre[HalbjahrIndex].KleineNoten;
                else return null;
            }
            set
            {
                if (HjSelected) Halbjahre[HalbjahrIndex].KleineNoten = value;
            }
        }
        [System.Xml.Serialization.XmlIgnore]
        public List<Notensammlung> GroßeNoten
        {
            get
            {
                if (HjSelected) return Halbjahre[HalbjahrIndex].GroßeNoten;
                else return null;
            }
            set
            {
                if (HjSelected) Halbjahre[HalbjahrIndex].GroßeNoten = value;
            }
        }

        int Rounden(double zahl) { return (int)(Math.Round(zahl, 0, MidpointRounding.AwayFromZero)); }

        public void Inizialize(bool halbjahreLaden)
        {
            Fächer = new List<string>();
            Doppelwertig = new List<bool>();
            Halbjahre = new List<Halbjahr>();
            if (halbjahreLaden)
                for (int i = 0; i < HalbjahreCount; i++)
                    Halbjahre.Add(new Halbjahr());//{ Name = (i + 1).ToString() + ". Halbjahr" });
            HalbjahrIndex = 0;
            FachIndex = -1;
        }
        private static void Serialisieren<T>(T obj, string file)
        {
            using (FileStream fs = new FileStream(file, FileMode.Create))
                new XmlSerializer(typeof(T)).Serialize(fs, obj);
        }
        private static bool Deserialisieren<T>(string file, ref T test)
        {
            bool ex = File.Exists(file);
            if (!ex) test = default(T);
            else using (FileStream fs = new FileStream(file, FileMode.Open))
                    test = (T)(new XmlSerializer(typeof(T))).Deserialize(fs);
            return ex;
        }

        //public double FachSchnitt(int hjInd, int ind)
        //{
        //    double d1 = Halbjahre[hjInd].KleineNoten[ind].GetMittel(), d2 = Halbjahre[hjInd].GroßeNoten[ind].GetMittel();
        //    if (!double.IsNaN(d1) && double.IsNaN(d2)) return d1;
        //    else if (double.IsNaN(d1) && !double.IsNaN(d2)) return d2;
        //    if (Doppelwertig[ind])
        //    {
        //        Notensammlung nsTmp = new Notensammlung();
        //        nsTmp.NotenString = Halbjahre[hjInd].KleineNoten[ind].NotenString + "," + Halbjahre[hjInd].GroßeNoten[ind].NotenString + "," + Halbjahre[hjInd].GroßeNoten[ind].NotenString;
        //        return nsTmp.GetMittel();
        //    }
        //    else return (d1 + d2) / 2;
        //}
        //public double FachSchnitt(double max1, double count1, double max2, double count2, bool doppel)
        //{
        //    double d1 = max1 / count1, d2 = max2 / count2;
        //    if (!double.IsNaN(d1) && double.IsNaN(d2)) return d1;
        //    else if (double.IsNaN(d1) && !double.IsNaN(d2)) return d2;
        //    if (doppel)
        //    {
        //        return (max1 + 2 * max2) / (max1 + 2 * count2);
        //    }
        //    else return (d1 + d2) / 2;
        //}
        private double FachSchnitt(string lk, string ka, bool doppel)
        {
            double d1 = Notensammlung.ArithmetischesMittel(lk), d2 = Notensammlung.ArithmetischesMittel(ka);
            if (!double.IsNaN(d1) && double.IsNaN(d2)) return d1;
            else if (double.IsNaN(d1) && !double.IsNaN(d2)) return d2;
            if (doppel)
            {
                Notensammlung nsTmp = new Notensammlung();
                nsTmp.NotenString = lk + "," + ka + "," + ka;
                return nsTmp.ArithmetischesMittel();
            }
            else return (d1 + d2) / 2;
        } // kann weg
        private double FachSchnitt(Notensammlung lk, Notensammlung ka, bool doppel)
        {
            double d1 = lk.ArithmetischesMittel(), d2 = ka.ArithmetischesMittel();
            bool nan1 = double.IsNaN(d1), nan2 = double.IsNaN(d2);
            if (nan1 && nan2) return 0;
            else if (!nan1 && nan2) return d1;
            else if (nan1 && !nan2) return d2;
            else return doppel ? new Notensammlung() { NotenString = lk.NotenString + "," + ka.NotenString + "," + ka.NotenString }.ArithmetischesMittel() : (d1 + d2) / 2;
            //if (doppel)
            //{
            //    // Notensammlung nsTmp = new Notensammlung() { NotenString = lk.NotenString + "," + ka.NotenString + "," + ka.NotenString }.GetMittel();
            //    //nsTmp.NotenString = lk.NotenString + "," + ka.NotenString + "," + ka.NotenString;
            //    //return nsTmp.GetMittel();
            //    return new Notensammlung() { NotenString = lk.NotenString + "," + ka.NotenString + "," + ka.NotenString }.GetMittel();
            //}
            //else return (d1 + d2) / 2;
        }
        public double FachSchnitt(int ind)
        {
            return FachSchnitt(KleineNoten[ind], GroßeNoten[ind], Doppelwertig[ind]);
            //double d1 = KleineNoten[ind].GetMittel(), d2 = GroßeNoten[ind].GetMittel();
            //if (double.IsNaN(d1) && double.IsNaN(d2)) return 0;
            //if (!double.IsNaN(d1) && double.IsNaN(d2)) return d1;
            //else if (double.IsNaN(d1) && !double.IsNaN(d2)) return d2;
            //if (Doppelwertig[ind])
            //{
            //    Notensammlung nsTmp = new Notensammlung();
            //    nsTmp.NotenString = KleineNoten[ind].NotenString + "," + GroßeNoten[ind].NotenString + "," + GroßeNoten[ind].NotenString;
            //    return nsTmp.GetMittel();
            //}
            //else return (d1 + d2) / 2;
        }

        public string GetSicherheitsSpektrum(int ind)
        {
            int akt = Rounden(FachSchnitt(ind));
            string ausg = "", lk = "", ka = "";
            while (akt <= Notensammlung.NotenMax)
            {
                GetSich(ind, ref lk, ref ka, akt);
                if (lk == NichtMgl && ka == NichtMgl) break;
                ausg += "für " + akt + Notensammlung.EinheitNoten + ": \n";
                ausg += "nächste LK:" + lk + "\n";
                ausg += "nächste KA:" + ka + "\n\n";
                akt++;
            }
            return ausg;
        } // kann weg
        void GetSich(int ind, ref string lk, ref string ka, int note)
        {
            List<int> tmpLK = new List<int>(), tmpKA = new List<int>();
            //double durchschnitt = FachSchnitt(Halbjahre[HalbjahrIndex].KleineNoten[ind], Halbjahre[HalbjahrIndex].GroßeNoten[ind], Doppelwertig[ind]);
            //int d = Rounden(durchschnitt);

            for (int i = Notensammlung.NotenMin; i <= Notensammlung.NotenMax; i++)
            {
                double schnittTmpLK = FachSchnitt(Halbjahre[HalbjahrIndex].KleineNoten[ind].NotenString + "," + i, Halbjahre[HalbjahrIndex].GroßeNoten[ind].NotenString, Doppelwertig[ind]);
                double schnittTmpKA = FachSchnitt(Halbjahre[HalbjahrIndex].KleineNoten[ind].NotenString, Halbjahre[HalbjahrIndex].GroßeNoten[ind].NotenString + "," + i, Doppelwertig[ind]);
                if (Rounden(schnittTmpLK) == note)
                    tmpLK.Add(i);
                if (Rounden(schnittTmpKA) == note)
                    tmpKA.Add(i);
            }
            if (tmpLK.Count == 0) lk = NichtMgl;
            else lk = tmpLK.Count == 1 ? tmpLK[0].ToString() : tmpLK[0].ToString() + "-" + tmpLK[tmpLK.Count - 1].ToString();

            if (tmpKA.Count == 0) ka = NichtMgl;
            else ka = tmpKA.Count == 1 ? tmpKA[0].ToString() : tmpKA[0].ToString() + "-" + tmpKA[tmpKA.Count - 1].ToString();

            //else if (tmpLK.Count == 1) lk = tmpLK[0].ToString();
            //else lk = tmpLK[0].ToString() + "-" + tmpLK[tmpLK.Count - 1].ToString();
        } // kann weg

        public string GetSich2(int ind)
        {
            // nächste LK: 0-5 KMK -> 13 KMK
            // nächste LK: 6-10 KMK -> 14 KMK

            double
                // ges1 = Notensammlung.Summe(Halbjahre[HalbjahrIndex].KleineNoten[ind].Noten),
                // ges2 = Notensammlung.Summe(Halbjahre[HalbjahrIndex].GroßeNoten[ind].Noten),
                // count1 = Halbjahre[HalbjahrIndex].KleineNoten[ind].Noten.Count,
                // count2 = Halbjahre[HalbjahrIndex].GroßeNoten[ind].Noten.Count,
                // s1 = ges1 / count1,
                // s2 = ges2 / count2,
             s = FachSchnitt(ind)
                // sTmp = FachSchnitt(ges1, count1, ges2, count2, Doppelwertig[ind])
            ;

            Notensammlung ns = new Notensammlung(), ns2 = new Notensammlung();
            ns = Halbjahre[HalbjahrIndex].KleineNoten[ind];
            ns2 = Halbjahre[HalbjahrIndex].GroßeNoten[ind];

            double d1, d2;
            List<double> d1es = new List<double>(), d2es = new List<double>();

            for (int i = 0; i <= 15; i++)
            {
                // Lks
                ns.Noten.Add(i);
                d1 = FachSchnitt(ns, ns2, Doppelwertig[ind]);
                d1es.Add(Rounden(d1));
                ns.Noten.RemoveAt(ns.Noten.Count - 1);

                // Klausuren
                ns2.Noten.Add(i);
                d2 = FachSchnitt(ns, ns2, Doppelwertig[ind]);
                d2es.Add(Rounden(d2));
                ns2.Noten.RemoveAt(ns2.Noten.Count - 1);
            }

            d1es.Add(-1);
            d2es.Add(-1);
            string ausg = "";
            double tmpD = d1es[0], tmpI = 0;
            ausg += "nächste LK:\n";
            for (int i = 0; i < d1es.Count; i++)
            {
                if (tmpD != d1es[i])
                {
                    ausg += ((tmpI == i - 1) ? "bei " + tmpI : "bei " + tmpI + "-" + (i - 1).ToString()) + " -> " + tmpD + "\n";
                    tmpI = i;
                    tmpD = d1es[i];
                }
            }
            ausg += "\n";
            ausg += "nächste KA:\n";
            tmpD = d2es[0];
            tmpI = 0;
            for (int i = 0; i < d2es.Count; i++)
            {
                if (tmpD != d2es[i])
                {
                    ausg += ((tmpI == i - 1) ? "bei " + tmpI : "bei " + tmpI + "-" + (i - 1).ToString()) + " -> " + tmpD + "\n";
                    tmpI = i;
                    tmpD = d2es[i];
                }
            }
            return ausg.Trim();
        }

        public void Save() { Serialisieren(this, _path); }
        public void Load()
        {
            Verwaltung v = new Verwaltung();
            if (Deserialisieren(_path, ref v))
            {
                Fächer = v.Fächer;
                Doppelwertig = v.Doppelwertig;
                Halbjahre = v.Halbjahre;
                HalbjahrIndex = v.HalbjahrIndex;
                FachIndex = v.FachIndex;
            }
        }

        public void FachAdd(string name, bool doppelwertig)
        {
            Fächer.Add(name);
            Doppelwertig.Add(doppelwertig);
            foreach (var item in Halbjahre)
            {
                item.KleineNoten.Add(new Notensammlung());
                item.GroßeNoten.Add(new Notensammlung());
            }
        }
        public void FachChange(int ind, string name, bool doppelwertig)
        {
            Fächer[ind] = name;
            Doppelwertig[ind] = doppelwertig;
        }
        public void FachDelete(int ind)
        {
            Fächer.RemoveAt(ind);
            Doppelwertig.RemoveAt(ind);
            foreach (var item in Halbjahre)
            {
                item.KleineNoten.RemoveAt(ind);
                item.GroßeNoten.RemoveAt(ind);
            }
        }

        public string GetStats()
        {
            string ausg = "";
            Halbjahr hj = Halbjahre[HalbjahrIndex];

            #region Schnitte
            {
                double ges = 0, a = 0, b = 0, ca = 0, cb = 0;
                foreach (var item in hj.KleineNoten)
                    foreach (var item2 in item.Noten)
                    {
                        ca++;
                        a += item2;
                    }
                foreach (var item in hj.GroßeNoten)
                    foreach (var item2 in item.Noten)
                    {
                        cb++;
                        b += item2;
                    }
                ges = ((a / ca) + (b / cb)) / 2;
                a /= ca;
                b /= cb;
                ausg += "Schnitte:\n";
                ausg += " LKs: " + Math.Round(a, 4) + " " + Notensammlung.EinheitNoten + "\n";
                ausg += " Klausuren: " + Math.Round(b, 4) + " " + Notensammlung.EinheitNoten + "\n";
                ausg += " Gesamt: " + Math.Round(ges, 4) + " " + Notensammlung.EinheitNoten + "\n";
                ausg += "\n";
            }
            #endregion

            #region Fächerübersicht
            {
                //15,03 KMK :: 1+ :: Mathe
                // 1,03 KMK :: 1- :: Mathe
                //15,03 KMK :: 1  :: Mathe
                List<string> fächers = new List<string>();
                List<double> schnitte = new List<double>();

                double schnitt2 = 0;
                for (int i = 0; i < Fächer.Count; i++)
                {
                    schnitt2 = FachSchnitt(i);
                    int ind = schnitte.BinarySearch(schnitt2);
                    ind = ind < 0 ? ~ind : ind;
                    schnitte.Insert(ind, schnitt2);
                    fächers.Insert(ind, Notensammlung.ConvertToString(schnitt2, 2, false) + " " + Notensammlung.EinheitNoten + " :: " + Notensammlung.GetNoteMitZeichen(schnitt2) + " :: " + Fächer[i]);
                }
                ausg += "Stand der Fächer:\n";
                fächers.Reverse();
                for (int i = 0; i < fächers.Count; i++)
                {
                    ausg += " " + fächers[i] + "\n";
                }
                ausg += "\n";
            }
            #endregion

            #region Anzahl Punkte
            {
                int[] pkCounts = new int[Notensammlung.NotenMax + 1];
                for (int i = 0; i < hj.GroßeNoten.Count; i++)
                {
                    foreach (double item in hj.GroßeNoten[i].Noten)
                        pkCounts[(int)item]++;
                    foreach (double item in hj.KleineNoten[i].Noten)
                        pkCounts[(int)item]++;
                }
                ausg += "Anzahl der Kmks:\n";
                for (int i = 0; i < pkCounts.Length; i++)
                {
                    ausg += " " + ((pkCounts.Length - 1 - i).ToString().Length < 2 ? " " : "") + (pkCounts.Length - 1 - i).ToString() + " " + Notensammlung.EinheitNoten + ": " + pkCounts[pkCounts.Length - 1 - i].ToString() + "x\n";
                }
                ausg += "\n";
            }
            #endregion

            #region Unterpunktetes
            {
                List<string> unterpunktetes = new List<string>();
                double schnitt = 0;
                for (int i = 0; i < Fächer.Count; i++)
                    if (Math.Round(schnitt = FachSchnitt(i), 0) < 5)
                        unterpunktetes.Add(Fächer[i]);//+ " (" + Math.Round(schnitt, 2) + " " + Notensammlung.EinheitNoten + ")");

                ausg += "Unterpunktete Fächer:\n";
                if (unterpunktetes.Count != 0)
                    foreach (var item in unterpunktetes)
                        ausg += " " + item + "\n";
                else ausg += " keine\n";
            }
            ausg += "\n";
            #endregion

            return ausg;
        }
    }
}