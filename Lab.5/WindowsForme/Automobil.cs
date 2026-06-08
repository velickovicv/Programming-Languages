using System;
using System.Collections.Generic;
using System.IO;

namespace WinFormeVezbanje
{

    public enum VrstaGoriva
    {
        Benzin,
        Dizel,
        Gas
    }

    internal class Automobil
    {
        private string proizvodjac;
        private string model;
        private double zapreminaMotora;

        private DateTime datumProizvodnje;

        private VrstaGoriva gorivo;

        private bool imaAtest;

        public string Proizvodjac
        {
            get { return proizvodjac; }
            set { proizvodjac = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public double ZapreminaMotora
        {
            get { return zapreminaMotora; }
            set { zapreminaMotora = value; }
        }
        public VrstaGoriva Gorivo
        {
            get { return gorivo; }
            set { gorivo = value; }
        }
        public DateTime DatumProizvodnje
        {
            get { return datumProizvodnje; }
            set { datumProizvodnje = value; }
        }
        public bool ImaAtest
        {
            get { return imaAtest; }
            set { imaAtest = value; }
        }

        public Automobil(string proizvodjac, string model, double ZapreminaMotora, DateTime DatumProizvodnje, VrstaGoriva gorivo, bool ImaAtest)
        {
            Proizvodjac = proizvodjac;
            Model = model;
            zapreminaMotora = ZapreminaMotora;
            datumProizvodnje = DatumProizvodnje;
            Gorivo = gorivo;
            imaAtest = ImaAtest;
        }

        public static void upisiUFajl(List<Automobil> automobili, string putanja)
        {
            using (StreamWriter sw = new StreamWriter(putanja))
            {
                foreach(Automobil a in  automobili)
                {
                    sw.WriteLine($"{a.Proizvodjac}|{a.Model}|{a.ZapreminaMotora}|{a.DatumProizvodnje}|{a.Gorivo}|{a.ImaAtest}");
                }
            }
        }
    }
}
