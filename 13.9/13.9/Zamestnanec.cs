using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._9
{
    class Zamestnanec
    {
        string titul;
        string jmeno;
        int plat;
        DateTime datumNastupu;
        int ohodnoceni;
        bool vedouci;
        int pocetHodin;

        string Titul
        {
            get => titul;
            set
            {
                titul = value.First().ToString().ToUpper() + value.Substring(1) + "."; 
            }
        
        }

        string Jmeno
        {
            get => jmeno;
            set
            {
                string[] pole = value.Split(' ');
                pole[0] = pole[0].First().ToString().ToUpper() + pole[0].Substring(1);
                pole[1] = pole[1].ToUpper();

                jmeno = pole[0] + " " + pole[1];
                
            }
        }     

        public Zamestnanec(string titul, string jmeno, int plat, DateTime datumNastupu)
        {
            Titul = titul;
            Jmeno = jmeno;
            this.plat = plat;
            this.datumNastupu = datumNastupu;
            ohodnoceni = 0;
            pocetHodin = 0;
        }

        int RocniPlat()
        {
            return plat * 12;

        }

        int PocetMesicu()
        {
            
            return ((DateTime.Now - datumNastupu).Days);

        }
        int Celkem()
        {
            return PocetMesicu() * plat;

        }

        public override string ToString()
        {
            return String.Format("titul: {0}\njmeno: {1}\n plat: {2}\npocet mesicu: {3}\nohodnoceni: {4}\nrocni plat: {5}\ncelkovy plat: {6}\nodpacovane hodiny: {7}\n",Titul,Jmeno, plat, PocetMesicu(), ohodnoceni, RocniPlat(),Celkem(),pocetHodin);
        }

    }
}
