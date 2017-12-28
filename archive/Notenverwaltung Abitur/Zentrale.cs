using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1;

public class Zentrale
{
    string _saveFile = Application.StartupPath + "\\fächer.xml";
    int _xmlIndexHJ = 0, _xmlIndexFach = -1;
    public int XmlIndexHJ { get { return _xmlIndexHJ; } set { _xmlIndexHJ = value; } }
    public int XmlIndexFach { get { return _xmlIndexFach; } set { _xmlIndexFach = value; } }

    List<Fach> _fächer = new List<Fach>();
    public List<Fach> Fächer { get { return _fächer; } set { _fächer = value; } }

    public void AddFach(Fach f)
    {
        _fächer.Add(f);
        for (int i = 0; i < Do.Kurshalbjahre.Length; i++)
            _fächer[_fächer.Count - 1].Kurshalbjahre.Add(new Kurshalbjahr());
    }
    public void RemoveFach(int index)
    {
        _fächer.RemoveAt(index);
    }
    public void Save()
    {
        XmlSerialisierung<Zentrale>.Serialisieren(this, _saveFile);
    }
    public void Load()
    {
        if (System.IO.File.Exists(_saveFile))
        {
            Zentrale z = XmlSerialisierung<Zentrale>.Deserialisieren(_saveFile);
            this._xmlIndexHJ = z._xmlIndexHJ;
            this._xmlIndexFach = z._xmlIndexFach;
            this._fächer = z._fächer;
        }
    }

}
