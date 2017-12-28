using System;
using System.Collections.Generic;
using System.Text;

namespace Notenverwaltung
{
    public class Schulfach
    {
        public Notensammlung _kleineNoten = new Notensammlung(),
               _großeNoten = new Notensammlung();

        public string _name = "";
        public bool _doppelwertig = true;

        public void Inizialize(string bez, bool doppelwertig)
        {
            _name = bez;
            _doppelwertig = doppelwertig;
        }

        public double alleNotenRetMittel()
        {
            Notensammlung ns = new Notensammlung();
            if (_doppelwertig)
            {
                //ns.Noten.AddRange(_kleineNoten.Noten);
                //for (int i = 0; i < 2; i++)
                //    ns.Noten.AddRange(_großeNoten.Noten);
            }
            else
            {
                //ns.Noten.Add(_kleineNoten.Mittel);
                //ns.Noten.Add(_großeNoten.Mittel);
            }
            return 0;//ns.Mittel;
        }


        //    List<byte> _kleineNoten = new List<byte>();

    }
}
