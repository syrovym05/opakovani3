using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            return ((DateTime.Now - datumNastupu).Days)/30;
        }
        int Celkem()
        {
            return PocetMesicu() * plat;
        }

        public void ZvysOsobni(int x)
        {
            ohodnoceni += x;
            if (ohodnoceni > 10000) vedouci = true;

        }

        public void PridejOdprHod(int x)
        {

            if (pocetHodin + x >= 100)
            {
                pocetHodin = 100;
                MessageBox.Show("Pracujes vice nez 100 hodin, potřebuješ relaxovat!!");
            }
            else pocetHodin += x;
        }

        public void Relaxace(int x)
        {
            pocetHodin = 0;
        }

        public override string ToString()
        {
            return String.Format("titul: {0}\njmeno: {1}\nplat: {2}\npocet mesicu: {3}\nohodnoceni: {4}\nrocni plat: {5}\ncelkovy plat: {6}\nodpacovane hodiny: {7}\nVedouci: {8}",Titul,Jmeno, plat, PocetMesicu(), ohodnoceni, RocniPlat(),Celkem(),pocetHodin, vedouci ? "Ano" : "Ne");
        }

    }
}
