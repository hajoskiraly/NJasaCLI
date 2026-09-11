using System;
using System.Globalization;

namespace NJasaCLI
{

    
        public class beolvasas
        {
            public string nev { get; set; }
            public int ev { get; set; }
            public string celpont { get; set; }
            public int legenyseg { get; set; }
            public bool sikeres { get; set; }
            public string leiras { get; set; }
            public double koltseg { get; set; }
            public double hasznosteher { get; set; }
            public string kockazatiszint { get; set; }

            public beolvasas(string sor)
            {
                string[] adatok = sor.Split(';');
                this.nev = adatok[0];
                this.ev = int.Parse(adatok[1]);
                this.celpont = adatok[2];
                this.legenyseg = int.Parse(adatok[3]);
            var sikeres = adatok[4];
            if (string.Equals(sikeres, "Igen")) this.sikeres = true;
            else if (string.Equals(sikeres, "Nem")) this.sikeres = false;
                this.leiras = adatok[5];
                this.koltseg = double.Parse(adatok[6], CultureInfo.GetCultureInfo("hu-HU"));
                this.hasznosteher = double.Parse(adatok[7], CultureInfo.GetCultureInfo("hu-HU"));

                
            }
        

    }
}
