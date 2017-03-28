using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cw4p02
{
   public interface ITelefon {
         void wybierzNumer();
         void wyslijWiadomosc();
         void pokazTyp();
    }

    class ZwyklyTelefon:ITelefon { 
        
      public void  wybierzNumer()
        {
 	        Console.WriteLine("Wybierz numer");
        }

        public void  wyslijWiadomosc()
        {
 	        Console.WriteLine("Wysyłam wiadomosc");
        }

        public void  pokazTyp()
        {
 	        Console.WriteLine("Pokaz typ");
        }
}

    class Dekorator:ITelefon {

        protected ZwyklyTelefon _telefon;

        public Dekorator(ZwyklyTelefon _telefon) {
            this._telefon = _telefon;
        }

        public void  wybierzNumer()
        {
            _telefon.wybierzNumer();
        }

        public void  wyslijWiadomosc()
        {
            _telefon.wyslijWiadomosc();
        }

        public void  pokazTyp()
        {
            _telefon.pokazTyp();
        }
}

    class Smartphone : Dekorator {

        private string rodzajTelefonu;

        public Smartphone(ZwyklyTelefon zwykly, string rodzajTelefonu):base (zwykly) {
            this.rodzajTelefonu = rodzajTelefonu;
            this._telefon = zwykly;
        }

        public void dotknijEkran() {
            Console.WriteLine("Dotykasz ekran");
        }

        public void ładujBezprzewodowo() {
            Console.WriteLine("Ładuje bezprzewodowo");
        }

    
    }

    class Program
    {

        static void Main(string[] args)
        {
            ZwyklyTelefon zwyklyTelefon = new ZwyklyTelefon();
            zwyklyTelefon.pokazTyp();
            zwyklyTelefon.wybierzNumer();
            zwyklyTelefon.wyslijWiadomosc();

            Smartphone nowySmartfon = new Smartphone(zwyklyTelefon,"LG");
            nowySmartfon.ładujBezprzewodowo();
            nowySmartfon.dotknijEkran();

            
            Console.ReadKey();
        }
    }
}
