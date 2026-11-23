using System;
using System.Collections.Generic;
using System.Text;

namespace _1._1
{
    internal class Ploeg
    {
        //properties
        private List<Speler> spelers = new List<Speler>();

        public List<Speler> Spelers
        {
            get { return spelers; }
        }

        public string PloegNaam { get; set; }

        //constructors
        public Ploeg()
        {

        }
        public Ploeg(string ploegNaam)
        {
            PloegNaam = ploegNaam;
        }

        //methodes
        public override string ToString()
        {
            return PloegNaam;
        }

        public int BerekenTotaalDoelpunten()
        {
            int resultaat = 0;
            foreach (Speler item in spelers)
            {
                resultaat += item.Doelpunten;
            }
            return resultaat;
        }

        public Speler GeefTopschutter()
        {
            Speler objSpeler = new Speler();
            foreach (Speler item in spelers)
            {
                if (objSpeler.Doelpunten < item.Doelpunten)
                {
                    objSpeler = item;
                }
            }
            return objSpeler;
        }

        public void VerwijderSpeler(int index)
        {
            if (spelers.Contains(spelers.ElementAt(index)))
            {
                spelers.RemoveAt(index);
            }
        }
        
        public void VoegSpelerToe(string naam, int rugnummer)
        {
            Speler objSpeler = new Speler(naam, rugnummer);
            spelers.Add(objSpeler);
        }




    }
}
