using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cw4p01
{

    public class Uczelnia {

       private DateTime DataRekrutacji;
       private static Uczelnia _obiekt;

       private Uczelnia()
       {
           //this.DataRekrutacji = DataRekrutacji;
       }

       public static Uczelnia tworzenieObiektu(DateTime DataRekrutacji)
       {
           //sprawdzamy czy już utworzyliśmy instancję klasy
           if (_obiekt == null)
           {
               //jeśli nie to ją tworzymy
               _obiekt = new Uczelnia();
               _obiekt.DataRekrutacji = DataRekrutacji;
           }
           //zwracamy instancję obiektu zapisanego
           //w stacznym polu naszej klasy
           return _obiekt;
       }

       

        public void RekrutujStudentow() {
            Console.WriteLine("Data następnej rekrutacji to: "+this.DataRekrutacji);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2017,05,15,7,0,0);
            DateTime date2 = new DateTime(2017,06,15,8,0,0);

            Uczelnia UWM = Uczelnia.tworzenieObiektu(date1);
            Uczelnia Stanford = Uczelnia.tworzenieObiektu(date2);

            UWM.RekrutujStudentow();
            Stanford.RekrutujStudentow();

            Console.ReadKey();
        }
    }
}
