using System;
using System.Collections.Generic;
using System.Text;
using WindowsFormsApplication1;

public class Fach
{
    string _name;
    public string Name { get { return _name; } set { _name = value; } }

    List<Kurshalbjahr> _kurshalbjahre = new List<Kurshalbjahr>();// { new Kurshalbjahr(), new Kurshalbjahr(), new Kurshalbjahr(), new Kurshalbjahr() };
    public List<Kurshalbjahr> Kurshalbjahre { get { return _kurshalbjahre; } set { _kurshalbjahre = value; } }

    Wert _klausurschema = Wert.doppelwertig;
    public Wert Klausurschema
    {
        get { return _klausurschema; }
        set
        {
            if (_klausurschema != value)
            {
                foreach (var item in _kurshalbjahre)
                {
                    item.Klausurschema = value;
                    for (int i = 0; i < item.Arbeiten.Count; i++)
                        if (item.Arbeiten[i].Wertigkeit == _klausurschema)
                            item.Arbeiten[i].Wertigkeit = item.Klausurschema;
                }
            }
            _klausurschema = value;
        }
    }

    public Kurshalbjahr AlleArbeiten
    {
        get
        {
            Kurshalbjahr kh = new Kurshalbjahr();
            kh.Klausurschema = _klausurschema;
            foreach (var item in _kurshalbjahre)
                kh.Arbeiten.AddRange(item.Arbeiten);
            return kh;
        }
    }

    public void Add(Arbeit arb, int indexKurshalbjahr)
    {
        //if (indexKurshalbjahr < 0 || indexKurshalbjahr >= _kurshalbjahre.Count) 
        //    indexKurshalbjahr = 0;
        _kurshalbjahre[indexKurshalbjahr].Arbeiten.Add(arb);
    }
    public void Remove(int indexNote, int indexKurshalbjahr)
    {
        //if ((indexKurshalbjahr >= 0 && indexKurshalbjahr < _kurshalbjahre.Count) &&
        //    (indexNote >= 0 && indexNote < _kurshalbjahre[indexKurshalbjahr].Arbeiten.Count))
        //{
        _kurshalbjahre[indexKurshalbjahr].Arbeiten.RemoveAt(indexNote);
        //}
        //else
        //{ }
    }
}