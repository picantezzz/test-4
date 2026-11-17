using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_4
{
    internal class factuur
    {

        public class Factuur
        {
            private string strKlant;
            private string strProduct;
            private int intKlantnr;
            private int intAantal;
           private  double dblPrijs;

            public int Aantal
            {
                get { return intAantal; }
                set { intAantal = value; }
            }

            public Factuur(string klant, string product, int klantnr, int aantal, double prijs)
            {
                strKlant = klant;
                strProduct = product;
                intKlantnr = klantnr;
                intAantal = aantal;
                dblPrijs = prijs;
            }

            public string FactuurTotaal()
            {
                return (intAantal * dblPrijs).ToString();
            }

            public string Overzicht()
            {
                return "Naam klant: " + strKlant + "" +
                       "Klantnummer: " + intKlantnr + "" +
                       "Bestelling: " + intAantal + " " + strProduct + " aan " + dblPrijs + " euro per stuk."; 
            }

            public override string ToString()
            {
                return strKlant + " - " + intKlantnr;
            }
        }
    }
}