using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsy2
{
    #region Kod Aplikacji
    interface IZarzadzaniePozycjami
    {
        void ZnajdzPozycjePoTytule(string tytul);

        void ZnajdzPozycjePoId(int id);

        void WypiszWszystkiePozycje();
    }

    class Biblioteka : IZarzadzaniePozycjami
    {

        private string adres = null;

        public List<Bibliotekarz> ListaBibliotekarzy = new List<Bibliotekarz>();
        public List<Katalog> ListaKatalogow = new List<Katalog>();


        public Biblioteka() { }

        public Biblioteka(string adres)
        {
            this.adres = adres;
        }

        public void DodajBibliotekarza(Bibliotekarz b)
        {
            // TODO do 10 maja
        }

        public void WypiszBibliotekarzy()
        {
            // TODO do 10 maja
        }

        public void DodajKatalog(Katalog k)
        {
            // TODO do 10 maja
        }



        public void DodajPozycje(Pozycja p, string _dzialTematyczny)
        {
            var katalog = new Katalog(_dzialTematyczny);

            katalog.DodajPozycje(p);

        }




        public void WypiszWszystkiePozycje()
        {
            // TODO do 10 maja
        }

        public void ZnajdzPozycjePoId(int id)
        {
            // TODO do 10 maja

        }

        public void ZnajdzPozycjePoTytule(string tytul)
        {
            // TODO do 10 maja
        }

    }

    public class Osoba
    {
        protected  string imie = null;
        protected  string nazwisko = null;

        public Osoba() { }

        public Osoba(string _imie, string _nazwisko)
        {
            this.imie = _imie;
            this.nazwisko = _nazwisko;
        }
    }




    public class Bibliotekarz : Osoba
    {
        private string dataZatrudnienia = null;
        private double wynagrodzenie = 0;

        public Bibliotekarz()
        {
        }

        public Bibliotekarz(string _imie, string _nazwisko, string _dataZatrudnienia, double _wynagrodzenie) : base(_imie, _nazwisko)
        {
            DateTime data = Convert.ToDateTime(_dataZatrudnienia);
            this.dataZatrudnienia = data.ToString();

            this.wynagrodzenie = _wynagrodzenie;
            this.imie = _imie;
            this.nazwisko = _nazwisko;
        }

        public void WypiszInfo()
        {
            Console.WriteLine("### Bibliotekarz ###");
            Console.WriteLine($"| Imie: {this.imie}");
            Console.WriteLine($"| Nazwisko: {this.nazwisko}");
            Console.WriteLine($"| Data zatrudnienia: {this.dataZatrudnienia}");
            Console.WriteLine($"| Wynagrodzenie: {this.wynagrodzenie}");
            Console.WriteLine("### --------- ###\n");
        }
    }

    class Katalog : IZarzadzaniePozycjami
    {
        private string dzialTematyczny = null;

        public List<Pozycja> ListaPozycji = new List<Pozycja>();

        public Katalog() { }

        public Katalog(string dzialTematyczny_)
        {
            this.dzialTematyczny = dzialTematyczny_;
        }

        public void DodajPozycje(Pozycja poz)
        {
            // TODO do 10 maja
        }

        public void ZnajdzPozycjePoTytule(string tytul)
        {

            // TODO do 10 maja
        }

        public void ZnajdzPozycjePoId(int id)
        {
            // TODO do 10 maja
        }

        public void WypiszWszystkiePozycje()
        {
            // TODO do 10 maja
        }
    }
    abstract class Pozycja
    {
        protected  string tytul = null;
        protected  int id = 0;
        protected  string wydawnictwo = null;
        protected  int rokWydania = 0;

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
            Console.WriteLine($"| Tytul: {this.tytul}");
            Console.WriteLine($"| Liczba stron : {this.liczbaStron}");
            Console.WriteLine($"| Rok Wydania: {this.rokWydania}");
            Console.WriteLine($"| Wydawnictwo: {this.wydawnictwo}");
            Console.WriteLine($"| Id: {this.id}");
            Console.WriteLine("### --------- ###\n");
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
            // TODO do 10 maja
        }

    }
    class Czasopismo : Pozycja
    {
        private int numer = 0;

        public override void WypiszInfo()
        {
            Console.WriteLine($"### Czasopismo ###");
            Console.WriteLine($"| Id: {this.id}");
            Console.WriteLine($"| Rok Wydania: {this.rokWydania}");
            Console.WriteLine($"| Wydawnictwo: {this.wydawnictwo}");
            Console.WriteLine($"| Numer: {this.numer}");
            Console.WriteLine($"| Tytul: {this.tytul}");
            Console.WriteLine("### ----------- ###\n");
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
    class Autor : Osoba
    {
        private string narodowosc = null;

        public Autor() { }

        public Autor(string _imie, string _nazwisko, string _narodowosc) : base(_imie, _nazwisko)
        {
            this.narodowosc = _narodowosc;
            this.imie = _imie;
            this.nazwisko = _nazwisko;
        }
    }
    #endregion

    #region Testy
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\tWitamy w Bibliotece!");
           
            //[<=>]Biblioteka:
            var BibliotekaMiejska = new Biblioteka("ul. Armii Krajowej");
            //[<=>]Bibliotekarze:
            var Sebastian = new Bibliotekarz("Sebastian", "Bąk", "18-03-2019", 4000);
            //[<=>]Katalogi w bibliotece:
            var KatalogHorror = new Katalog("wszystko");
            var KatalogKomedie = new Katalog("komedie");

            //[<=>]Pozycje w bibliotece:
            //[*]Książki:
            var HansKloss = new Ksiazka("Hans Kloss", 0, "Polskie", 1999, 100);
            //=>Autorzy:
            var HansK = new Autor("Hans", "Kloss", "Polak");

            var HarryPotter = new Ksiazka("Harry Poter", 1, "Wielka Brytania", 2005, 400);
            //=>Autorzy:
            var JKRowling = new Autor("J.K.", "Rowling", "Wielka Brytania");

            var Biblia = new Ksiazka("Biblia", 2, "-nieznane-", 0, 200);
            //=>Autorzy:

            //[*]Czasopisma:
            var BatMan2001 = new Czasopismo("Batman", 0, "Marvel", 2001, 1);

            //Operacje na bibliotece
            BibliotekaMiejska.DodajKatalog(KatalogHorror);
            BibliotekaMiejska.DodajBibliotekarza(Sebastian);
            BibliotekaMiejska.DodajPozycje(HansKloss, "wszystko");
            BibliotekaMiejska.WypiszBibliotekarzy();
            BibliotekaMiejska.WypiszWszystkiePozycje();

            BibliotekaMiejska.ZnajdzPozycjePoId(0);

            KatalogHorror.DodajPozycje(HansKloss);
            KatalogHorror.DodajPozycje(HarryPotter);
            KatalogHorror.DodajPozycje(Biblia);
            BibliotekaMiejska.ZnajdzPozycjePoId(0);
            BibliotekaMiejska.ZnajdzPozycjePoId(1);
            BibliotekaMiejska.ZnajdzPozycjePoId(2);

            KatalogHorror.DodajPozycje(BatMan2001);


            BibliotekaMiejska.DodajKatalog(KatalogKomedie);




            //[<==>]Biblioteka:
            var BibliotekaNieczynna = new Biblioteka("ul. Zamkowa");
            //[<=>]Bibliotekarze:

            //[<=>]Katalogi w bibliotece:
            var KatalogRomans = new Katalog("romans");
            //[<=>]Pozycje w bibliotece:

            //[*]Książki:

            //[*]Czasopisma:

            //Operacje na bibliotece


            Console.WriteLine("\n\t [<==BibliotekaMiejska==>] Wypisz wszystkie pozycje\n#######\n");
            BibliotekaMiejska.WypiszWszystkiePozycje();
            Console.WriteLine("\n$$ [<==BibliotekaMiejska==>] Wypisz wszystkich Bibliotekarzy $$");
            BibliotekaMiejska.WypiszBibliotekarzy();
            Console.WriteLine("\n$$ [<==BibliotekaMiejska==>] Wypisz wszystkie o ID: 0 $$");
            BibliotekaMiejska.ZnajdzPozycjePoId(0);
            Console.WriteLine("\n$$ [<==BibliotekaMiejska==>] Wypisz wszystkie o ID: 4 $$");
            BibliotekaMiejska.ZnajdzPozycjePoId(4);


            Console.WriteLine("\n$$ Znajdz W KatalogHorror pozycje po id: 0 $$");
            KatalogHorror.ZnajdzPozycjePoId(0);
            Console.WriteLine("\n$$ Znajdz W KatalogHorror pozycje po id: 4 $$");
            KatalogHorror.ZnajdzPozycjePoId(4);

            HansKloss.DodajAutora(HansK);
            HarryPotter.DodajAutora(JKRowling);
            Console.WriteLine("\n$$ Wyświetlenie autorów po dodaniu $$");
            KatalogHorror.WypiszWszystkiePozycje();

            // Sprwadzenie co kryje się w katalogu komedie
            Console.WriteLine("\n $$ Pozycje w Katalogu Komedie $$");
            KatalogKomedie.WypiszWszystkiePozycje();


            Console.WriteLine("\n\t [<==BibliotekaNieczynna==>] Wypisz wszystkie pozycje\n#######\n");
            BibliotekaNieczynna.WypiszWszystkiePozycje();
            Console.WriteLine("\n\t [<==BibliotekaNieczynna==>] Wypisz wszystkich bibliotekarzy:");
            BibliotekaNieczynna.WypiszBibliotekarzy();
            Console.WriteLine("\n\t [<==BibliotekaNieczynna==>] Znajdz pozycje o id {0}:");
            BibliotekaNieczynna.ZnajdzPozycjePoId(0);
            Console.WriteLine("\n\t [<==BibliotekaNieczynna==>] Znajdz pozycje o id {}:");
            BibliotekaNieczynna.ZnajdzPozycjePoId(1);


            Console.ReadKey();
        }
    }
    #endregion
}
