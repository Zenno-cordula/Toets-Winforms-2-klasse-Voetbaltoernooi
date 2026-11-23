using System;
using System.Collections.Generic;
using System.Text;

namespace _1._1
{
    internal class Speler
    {
		//properties
		private int doelpunten;

		public int Doelpunten
		{
			get { return doelpunten; }
		}

        public string Naam { get; set; }
        public int Rugnummer { get; set; }

		//constructors
		public Speler()
		{
			doelpunten = 0;
		}

		public Speler(string naam, int rugnummer)
		{
			doelpunten = 0;
			Naam = naam;
			Rugnummer = rugnummer;
		}

		//methodes
		public void ScoorDoelpunt()
		{
			doelpunten++;
		}

        public override string ToString()
        {
            return $"{Rugnummer} - {Naam} (doelpunten: {Doelpunten})";
        }




    }
}
