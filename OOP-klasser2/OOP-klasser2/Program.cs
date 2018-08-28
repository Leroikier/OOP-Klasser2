using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_klasser2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Default constructor opretter instans
            //Person p1 = new Person();

            ////Den her metode er den fortrukket skrive fason.
            ////Den her måde opretter ved hjælp af object initializer
            //Person p2 = new Person { Fornavn = "Karl", Efternavn = "Mar" };

            ////p1 skal have nogle værdier
            //p1.Fornavn = "Karl";
            //p1.Efternavn = "Mar";

            ////Oprettelse af Person objekter i en liste
            ////Første metode opretter "Liste" "people" og adder p1 og p2 til listen
            ////List<Person> people = new List<Person>();
            ////people.Add(p1);
            ////people.Add(p2);

            ////Anden metode opretter "Liste" "people" og tilknytter p1 og p2 direkte til listen
            //List<Person> people = new List<Person> { p1, p2 };

            ////Optimal metode og bruge
            ////Tredje metode Liste Nyliste og Person objekter oprettes samtidigt
            //List<Person> Nyliste = new List<Person>
            //{
            //    new Person() { Fornavn = "Karl", Efternavn = "Mar"},
            //    new Person() { Fornavn = "Ole", Efternavn = "Henriksen" }
            //};

            ////For at udskrive ting fra "NyListe"
            //foreach (var person in Nyliste)
            //{
            //    Console.WriteLine(person.Fornavn + " " + person.Efternavn);
            //}

            ////for at få fat på feks. fornavnet "Ole" som er index nummer 2[1]
            //Console.WriteLine(Nyliste[1].Fornavn);


            //Console.ReadKey();

            try
            {
                Dyr Nytdyr = new Dyr("Hund", 3);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Oprettlse af dyr objekt
            Dyr dyr1 = new Dyr();
            dyr1.Art = "Møghund";

            //Prøv det her hvis ikke = (Catch exception)
            try
            {
                dyr1.Alder = 16;
                Console.WriteLine($"Dyrets art er = {dyr1.Art} \nDyrets alder er = {dyr1.Alder}");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            //Console.WriteLine($"Dyrets art er = {dyr1.Art} \nDyrets alder er = {dyr1.Alder}");

            Console.ReadKey();
        }
    }
}
