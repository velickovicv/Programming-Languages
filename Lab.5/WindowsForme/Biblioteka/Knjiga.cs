using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
   
    public enum Zanr
    {
        Drama,
        Istorija,
        Fantastika,
        Poezija,
        Nauka
    }
    internal class Knjiga
    {
        private string naslov;
        private string autor;
        private string zanr;
        private int broj;
        private bool izdata;
        private DateTime datum;


        public string Naslov
        {
            get { return naslov; }
            set { naslov = value; }
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public string Zanr
        {
            get { return zanr; }
            set { zanr = value; }
        }
        public int Broj
        {
            get { return broj; }
            set { broj = value; }
        }
        public bool Izdata
        {
            get { return izdata; }
            set { izdata = value; }
        }
        public DateTime Datum
        {
            get { return datum; }
            set { datum = value; }
        }
        
        public Knjiga(string _naslov, string _autor, string _zanr, int _broj, bool _izdata, DateTime _datum)
        {
            naslov = _naslov;
            autor = _autor;
            zanr = _zanr;
            broj = _broj;
            izdata = _izdata;
            datum = _datum;
        }
    }
}
