namespace Notenverwaltung
{
    using System.Collections.Generic;

    public class Fach
    {
        public const short HalbjahreCount = 4;

        public Fach()
        {
            Doppelwertig = true;
            Name = string.Empty;
            NotenGroß = new List<Notensammlung>();
            NotenKlein = new List<Notensammlung>();
        }

        public void Inizialize()
        {
            NotenGroß.Clear();
            NotenKlein.Clear();
            for (int i = 0; i < HalbjahreCount; i++)
            {
                NotenGroß.Add(new Notensammlung());
                NotenKlein.Add(new Notensammlung());
            }
        }

        public string Name
        {
            get;
            set;
        }

        public bool Doppelwertig
        {
            get;
            set;
        }

        public List<Notensammlung> NotenGroß
        {
            get;
            set;
        }

        public List<Notensammlung> NotenKlein
        {
            get;
            set;
        }
    }
}