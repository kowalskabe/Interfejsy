using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsy
{
    #region KodAplikacji
    class Katalog
    {
        private string dzialTematyczny = null;

        public List<Pozycja> listaPozycji = new List<Pozycja>();

        public Katalog() { }

        public Katalog(string dzialTematyczny_)
        {
            // TODO do 21 kwietnia
        }

        public void DodajPozycje(Pozycja poz)
        {
            // TODO do 21 kwietnia
        }

        public void WypiszWszystkiePozycje()
        {
            // TODO do 21 kwietnia
        }

        public void ZnajdzPozycje(int id, int rokWydania, string tytul, string wydawnictwo)
        {
            // TODO do 21 kwietnia
        }

    }
    abstract class Pozycja
    {
        internal protected string tytul = null;
        internal protected int id = 0;
        internal protected string wydawnictwo = null;
        internal protected int rokWydania = 0;

        public Pozycja()
        {

        }

        public Pozycja(string tytul, int id, string wydawnictwo, int rokWydania)
        {
            this.tytul = tytul;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
        }

        public abstract void WypiszInfo();
    }
    class Ksiazka : Pozycja
    {
        private List<Autor> listaAutorow = new List<Autor>();


        private int liczbaStron = 0;

        public override void WypiszInfo()
        {
            Console.WriteLine("### Ksiazka ###");
            if (listaAutorow.Count > 0) Console.WriteLine($"Dzielo napisalo: {listaAutorow.Count} autorów");
            Console.WriteLine($"Tytul: {this.tytul}");
            Console.WriteLine($"Liczba stron : {this.liczbaStron}");
            Console.WriteLine($"Rok Wydania: {this.rokWydania}");
            Console.WriteLine($"Wydawnictwo: {this.wydawnictwo}");
            Console.WriteLine($"Id: {this.id}\n");
        }
        public Ksiazka()
        {

        }

        public Ksiazka(string tytul_, int id_, string wydawnictwo_, int rokWydania_, int liczbaStron_) :
            base(tytul_, id_, wydawnictwo_, rokWydania_)
        {
            this.id = id_;
            this.tytul = tytul_;
            this.rokWydania = rokWydania_;
            this.liczbaStron = liczbaStron_;
            this.wydawnictwo = wydawnictwo_;
        }
        public void DodajAutora(Autor a)
        {
            if (a != null)
            {
                listaAutorow.Add(a);
            }
        }

    }
    class Czasopismo : Pozycja
    {
        private int numer = 0;

        public override void WypiszInfo()
        {
            Console.WriteLine($"### Czasopismo ###");
            Console.WriteLine($"Id: {this.id}");
            Console.WriteLine($"Rok Wydania: {this.rokWydania}");
            Console.WriteLine($"Wydawnictwo: {this.wydawnictwo}");
            Console.WriteLine($"Numer: {this.numer}");
            Console.WriteLine($"Tytul: {this.tytul}\n");
        }

        public Czasopismo() { }

        public Czasopismo(string tytul_, int id_, string wydawnictwo_, int rokWydania_, int numer_) :
            base(tytul_, id_, wydawnictwo_, rokWydania_)
        {
            this.id = id_;
            this.numer = numer_;
            this.wydawnictwo = wydawnictwo_;
            this.tytul = tytul_;
            this.rokWydania = rokWydania_;
        }

    }
    class Autor
    {
        private string imie = null;
        private string nazwisko = null;

        public Autor()
        {
        }

        public Autor(string imie_, string nazwisko_)
        {
            this.imie = imie_;
            this.nazwisko = nazwisko_;
        }

    }
    #endregion
    #region Testy
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\tWitamy w Katalogu!");

            var KatalogHorror = new Katalog("wszystko");
            var KatalogKomedie = new Katalog("komedie");

            //[<=>]Pozycje w katalogach:
            //[*]Książki:
            var HansKloss = new Ksiazka("Hans Kloss", 0, "Polskie", 1999, 100);
            //=>Autorzy:
            var HansK = new Autor("Hans", "Kloss");

            var HarryPotter = new Ksiazka("Harry Poter", 1, "Wielka Brytania", 2005, 400);
            //=>Autorzy:
            var JKRowling = new Autor("J.K.", "Rowling");

            var Biblia = new Ksiazka("Biblia", 2, "-nieznane-", 0, 200);
            //=>Autorzy:

            //[*]Czasopisma:
            var BatMan2001 = new Czasopismo("Batman", 0, "Marvel", 2001, 1);

            //Operacje na bibliotece


            KatalogHorror.DodajPozycje(HansKloss);
            KatalogHorror.DodajPozycje(HarryPotter);
            KatalogHorror.DodajPozycje(Biblia);
            KatalogHorror.DodajPozycje(BatMan2001);




            /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
            //[<=>]Katalogi w bibliotece:
            var KatalogRomans = new Katalog("romans");
            //[<=>]Pozycje w bibliotece:

            //[*]Książki:

            //[*]Czasopisma:


            ;
            Console.WriteLine("\n$$ Wyświetlenie autorów przed dodaniem $$");
            KatalogHorror.WypiszWszystkiePozycje();

            HansKloss.DodajAutora(HansK);
            HarryPotter.DodajAutora(JKRowling);
            Console.WriteLine("\n$$ Wyświetlenie autorów po dodaniu $$");
            KatalogHorror.WypiszWszystkiePozycje();
            //"Hans Kloss", 0, "Polskie", 1999, 100)
            KatalogHorror.ZnajdzPozycje(0, 1999, "Hans Kloss", "Polskie");

            // Sprwadzenie co kryje się w katalogu komedie
            Console.WriteLine("\n $$ Pozycje w Katalogu Komedie $$");
            KatalogKomedie.WypiszWszystkiePozycje();



            Console.ReadKey();
        }
    }
    #endregion
}
