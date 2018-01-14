namespace GradeManagement.Core
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Windows.Forms;
    using System.Xml.Serialization;

    public class Verw
    {
        private string Speicherpfad = Path.Combine(Application.StartupPath, Properties.Settings.Default.Dateiname);

        public Verw()
        {
            IndexFach = IndexJahr = -1;
            Fächer = new List<Fach>();
            IndexJahr = 0;
        }

        #region Properties
        public int IndexFach
        {
            get;
            set;
        }

        public int IndexJahr
        {
            get;
            set;
        }

        public List<Fach> Fächer
        {
            get;
            set;
        }

        [XmlIgnore]
        public Fach AktuellesFach
        {
            get
            {
                return FachSelected ? Fächer[IndexFach] : null;
            }
            set
            {
                if (IndexFach >= 0 && IndexFach < Fächer.Count)
                {
                    Fächer[IndexFach] = value;
                }
            }
        }

        [XmlIgnore]
        public string KleineNoten
        {
            get
            {
                if (IsSelected)
                {
                    return AktuellesFach.NotenKlein[IndexJahr].NotenString;
                }
                else
                {
                    return string.Empty;
                }
            }
            set
            {
                if (IsSelected)
                {
                    AktuellesFach.NotenKlein[IndexJahr].NotenString = value;
                }
            }
        }

        [XmlIgnore]
        public string GroßeNoten
        {
            get
            {
                if (IsSelected)
                {
                    return AktuellesFach.NotenGroß[IndexJahr].NotenString;
                }
                else
                {
                    return string.Empty;
                }
            }
            set
            {
                if (IsSelected)
                {
                    AktuellesFach.NotenGroß[IndexJahr].NotenString = value;
                }
            }
        }

        [XmlIgnore]
        public double FachSchnitt
        {
            get
            {
                double
                   d1 = KleineNotenSchnitt,
                   d2 = GroßeNotenSchnitt;
                if (!FachSelected || !HalbjahrSelected || (double.IsNaN(d1) && double.IsNaN(d2)))
                {
                    return 0;
                }
                else
                {

                    if (!double.IsNaN(d1) && double.IsNaN(d2))
                    {
                        return d1;
                    }
                    else if (double.IsNaN(d1) && !double.IsNaN(d2))
                    {
                        return d2;
                    }


                    if (AktuellesFach.Doppelwertig)
                    {
                        Notensammlung nsTmp = new Notensammlung();
                        nsTmp.NotenString = KleineNoten + "," + GroßeNoten + "," + GroßeNoten;
                        return nsTmp.ArithmetischesMittel();
                    }
                    else
                    {
                        return (d1 + d2) / 2;
                    }
                }
            }
        }

        [XmlIgnore]
        public bool FachSelected
        {
            get
            {
                return IndexFach >= 0 && IndexFach < Fächer.Count;
            }
        }

        [XmlIgnore]
        public bool HalbjahrSelected
        {
            get
            {
                return IndexJahr >= 0 && IndexJahr < Fach.HalbjahreCount;
            }
        }

        [XmlIgnore]
        public bool IsSelected
        {
            get
            {
                return HalbjahrSelected && FachSelected;
            }
        }

        [XmlIgnore]
        public double KleineNotenSchnitt
        {
            get
            {
                if (IsSelected)
                {
                    return AktuellesFach.NotenKlein[IndexJahr].ArithmetischesMittel();
                }
                else
                {
                    return 0;
                }
            }
        }

        [XmlIgnore]
        public double GroßeNotenSchnitt
        {
            get
            {
                if (IsSelected)
                {
                    return AktuellesFach.NotenGroß[IndexJahr].ArithmetischesMittel();
                }
                else
                {
                    return 0;
                }
            }
        }

        [XmlIgnore]
        private bool IsEmpty
        {
            get
            {
                return IsSelected && (AktuellesFach.NotenGroß[IndexJahr].Noten.Count + AktuellesFach.NotenKlein[IndexJahr].Noten.Count == 0);
            }
        }

        #endregion

        public int Add(string name, bool doppel)
        {
            Fach f = new Fach();
            f.Inizialize();
            f.Name = name;
            f.Doppelwertig = doppel;
            int ind = GetIndex(f.Name);
            Fächer.Insert(ind, f);
            return ind;
        }

        public int Change(string name, bool doppel)
        {
            if (AktuellesFach != null)
            {
                AktuellesFach.Name = name;
                AktuellesFach.Doppelwertig = doppel;
                Fach tmp = new Fach();
                tmp = AktuellesFach;
                Fächer.RemoveAt(IndexFach);
                int ind = GetIndex(tmp.Name);
                Fächer.Insert(ind, tmp);
                IndexFach = ind;
                return ind;
            }
            else
            {
                return -1;
            }
        }

        private int GetIndex(string fachname)
        {
            List<string> tmp = new List<string>();
            for (int i = 0; i < Fächer.Count; i++)
            {
                tmp.Add(Fächer[i].Name);
            }

            int tmpI = tmp.BinarySearch(fachname);
            if (tmpI < 0)
            {
                tmpI = ~tmpI;
            }

            return tmpI;
        }

        public void Delete()
        {
            if (AktuellesFach != null)
            {
                Fächer.RemoveAt(IndexFach);
                IndexFach = -1;
            }
        }

        public void Save()
        {
            Serialisieren<Verw>(this, Speicherpfad);
        }

        public void Load()
        {
            Verw tmp = new Verw();
            tmp = Deserialisieren<Verw>(Speicherpfad);
            if (tmp != null)
            {
                this.Fächer = tmp.Fächer;
                this.IndexJahr = tmp.IndexJahr;
                this.IndexFach = tmp.IndexFach;
            }
        }

        public void ClearEinträge()
        {
            for (int j = 0; j < 4; j++)
            {
                IndexJahr = j;
                for (int i = 0; i < Fächer.Count; i++)
                {
                    IndexFach = i;
                    GroßeNoten = KleineNoten = "";
                }
            }
        }

        private List<string> Exportieren()
        {
            List<string> ausg = new List<string>();
            int tmpInd = IndexFach;
            if (IsSelected)
            {
                for (int i = 0; i < Fächer.Count; i++)
                {
                    IndexFach = i;
                    ausg.Add(AktuellesFach.Name + "\n");
                    ausg.Add("einwertige Noten: " + KleineNoten + "\n");
                    ausg.Add("doppelwertige Noten: " + GroßeNoten + "\n");
                    ausg.Add("Schnitt: " + Notensammlung.ConvertToString(FachSchnitt, 4) + "\n");
                    ausg.Add(new string('-', 8));
                }
            }
            IndexFach = tmpInd;
            return ausg;
        }

        public void Exportieren(string path)
        {
            File.WriteAllLines(path, Exportieren().ToArray());
        }

        public string GetStats()
        {
            int tmpIFach = IndexFach;
            string ausg = "";

            if (Fächer.Count == 0) return ausg;

            #region Schnitte
            {
                Notensammlung nsKl = new Notensammlung(), nsGr = new Notensammlung();
                double tmpMaxAlleFächer = 0, tmpMaxCount = Fächer.Count, dLK, dKA;
                for (int i = 0; i < Fächer.Count; i++)
                {
                    nsKl.NotenString += "," + Fächer[i].NotenKlein[IndexJahr].NotenString;
                    nsGr.NotenString += "," + Fächer[i].NotenGroß[IndexJahr].NotenString;
                    IndexFach = i;
                    if (IsEmpty)
                    {
                        tmpMaxCount--;
                    }
                    else
                    {
                        tmpMaxAlleFächer += FachSchnitt;
                    }
                }
                dLK = nsKl.ArithmetischesMittel(false);
                dKA = nsGr.ArithmetischesMittel(false);

                ausg += "Schnitte:\n";
                ausg += " LKs: " + Notensammlung.ConvertToString(dLK, 4) + " " + Notensammlung.EinheitNoten + "\n";
                ausg += " Klausuren: " + Notensammlung.ConvertToString(dKA, 4) + " " + Notensammlung.EinheitNoten + "\n";
                ausg += " Gesamt (50:50 LkSchnitt und Klausuren): " + Notensammlung.ConvertToString((dLK + dKA) / 2, 4) + " " + Notensammlung.EinheitNoten + "\n";
                if (tmpMaxCount != 0)
                    ausg += " Gesamt (Fächerschnitte Mittelwert): " + Notensammlung.ConvertToString(tmpMaxAlleFächer / tmpMaxCount, 4) + " " + Notensammlung.EinheitNoten + "\n";
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
                    IndexFach = i;
                    if (IsEmpty) continue;
                    schnitt2 = FachSchnitt;
                    int ind = schnitte.BinarySearch(schnitt2);
                    ind = ind < 0 ? ~ind : ind;
                    schnitte.Insert(ind, schnitt2);
                    fächers.Insert(ind, Notensammlung.ConvertToString(schnitt2, 2, false) + " " + Notensammlung.EinheitNoten + " :: " + Notensammlung.GetNoteMitZeichen(schnitt2) + " :: " + Fächer[i].Name);
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
                for (int i = 0; i < Fächer.Count; i++)
                {
                    IndexFach = i;
                    foreach (double item in Fächer[i].NotenKlein[IndexJahr].Noten)
                        pkCounts[(int)item]++;
                    foreach (double item in Fächer[i].NotenGroß[IndexJahr].Noten)
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
                for (int i = 0; i < Fächer.Count; i++)
                {
                    IndexFach = i;
                    if (!IsEmpty && Math.Round(FachSchnitt, 0, MidpointRounding.AwayFromZero) < 5)
                        unterpunktetes.Add(Fächer[i].Name);//+ " (" + Math.Round(schnitt, 2) + " " + Notensammlung.EinheitNoten + ")");
                }
                ausg += "Unterpunktete Fächer:\n";
                if (unterpunktetes.Count != 0)
                    foreach (var item in unterpunktetes)
                        ausg += " " + item + "\n";
                else ausg += " keine\n";
            }
            ausg += "\n";
            #endregion
            IndexFach = tmpIFach;
            return ausg.Trim();
        }

        public string GetSicherheit(bool lk)
        {
            // bei 0-5 KMK -> 13 KMK
            // bei 6-10 KMK -> 14 KMK
            if (IsSelected)
            {
                string ausg = string.Empty;
                List<double> durchschnitte = new List<double>(), indx = new List<double>();
                Notensammlung ns = new Notensammlung();
                double tmpD, tmpI;

                ns = lk ? AktuellesFach.NotenKlein[IndexJahr] : AktuellesFach.NotenGroß[IndexJahr];
                indx = ns.Noten;

                for (int i = Notensammlung.NotenMin; i <= Notensammlung.NotenMax; i++)
                {
                    indx.Add(i);
                    durchschnitte.Add(Math.Round(FachSchnitt, 0, MidpointRounding.AwayFromZero));
                    indx.RemoveAt(ns.Noten.Count - 1);
                }

                durchschnitte.Add(-1);
                tmpD = durchschnitte[0];
                tmpI = 0;
                for (int i = 0; i < durchschnitte.Count; i++)
                {
                    if (tmpD != durchschnitte[i])
                    {
                        ausg += "bei " + tmpI + (((tmpI == i - 1) ? string.Empty : "-" + (i - 1).ToString()) + " -> " + tmpD + "\n");
                        tmpI = i;
                        tmpD = durchschnitte[i];
                    }
                }

                return ausg;
            }
            else
            {
                return string.Empty;
            }
        }

        private void Serialisieren<T>(T obj, string file)
        {
            using (FileStream fs = new FileStream(file, FileMode.Create))
            {
                new XmlSerializer(typeof(T)).Serialize(fs, obj);
            }
        }

        private T Deserialisieren<T>(string file)
        {
            if (!File.Exists(file))
            {
                return default(T);
            }
            else
            {
                using (FileStream fs = new FileStream(file, FileMode.Open))
                {
                    return (T)(new XmlSerializer(typeof(T))).Deserialize(fs);
                }
            }
        }
    }
}