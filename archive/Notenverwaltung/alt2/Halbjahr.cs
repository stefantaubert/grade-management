using System;
using System.Collections.Generic;
using System.Text;

namespace Notenverwaltung
{
    public class Halbjahr
    {
        public List<Notensammlung> KleineNoten { get; set; }
        public List<Notensammlung> GroßeNoten { get; set; }
        public Halbjahr()
        {
            KleineNoten = new List<Notensammlung>();
            GroßeNoten = new List<Notensammlung>();
        }
    }
}
