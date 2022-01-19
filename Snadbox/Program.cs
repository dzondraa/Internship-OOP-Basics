using System;
using System.Collections.Generic;

namespace Snadbox
{
    class Program
    {

        //                                              ___________________________________
        //                                             | Flyer                             |
        //                                             |-----------------------------------|
        //                                             | abstract string GetFlyResults()   |
        //                                             | void WriteResult(string)          |
        //                                             |___________________________________|

        //                                                               ||
                                                  //    ___________________________________
                                                  //   | Bird                              |
                                                  //   |-----------------------------------|
                                                  //   | overrid string GetFlyResults()    |
                                                  //   |___________________________________|



        #region DefinisanjeKlasa

        public interface IFlyable
        {
            void Fly();
            
        }


        public interface IWalkable
        {
            void Walk(string color);

        }


        // Dodavanje funkcionalnosti odredjenom tipu pomocu interfejsa
        // * Opisujemo sta sve objekat te klase moze da uradi (Leti, Da se oboji, itd)
        public abstract class Flyer : IFlyable
        { 
            public void Fly()
            {
                // FLY
            }

            public abstract string GetFlyResults();

            public void WriteResult()
            {
                Console.WriteLine("RESULT: " + this.GetFlyResults());
            }
        }

        // Ptica moze da leti i ima sve osobine letaca, ali smo je dodatno opisali i dodali novu funkcionalnost 'hodanja'
        // -> Implementira IWalkable

        public class Bird : Flyer, IWalkable
        {
            public override string GetFlyResults()
            {
                return "Bird flying";
            }

            public void Walk(string color)
            {
                Console.WriteLine("My color is: " + color);
            }
        }


        public class Plane : Flyer
        {
            public override string GetFlyResults()
            {
                return "Plane flying";
            }
        }

        #endregion



        static void Main(string[] args)
        {

            #region DemonstracijaPonasanjaObjekata
            Flyer flyer1 = new Bird();
            Flyer flyer2 = new Plane();


            // Pravimo listu letaca [ svi oni koju mogu da lete, mogu da budu u listi i da lete na svoj nacin ]
            List<IFlyable> listOfColoredObejcts = new List<IFlyable>();

            listOfColoredObejcts.Add(new Plane());
            listOfColoredObejcts.Add(new Bird());


            listOfColoredObejcts[0].Fly();

            // Svi letaci mogu da ispisu na konzolu, to je definisano jos na visem nivou abstrakcije
            // u abstraktnoj klasi (nema potrebe da svako implementira to na svoj nacin. U tom slucaju bi kod bio redudantan)
            flyer1.WriteResult();
            flyer2.WriteResult();
            #endregion

            #region ValueAndRefereneTypes
            // VALUE AND REFERENCE TYPES + BOXING
            string initialString = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";  
            int broj = 1;

            //address #asdasf
            //changeString(str);

            // BOXING AND UNBOXING
            Object boxedBroj = (Object)broj;
            int brojUnboxed = (int)boxedBroj;

            // NOVA KOPIJA SA NOVOM ADRESOM SE PROSLEDJUJE
            void changeNum(int broj)
            {
                broj++;
            }


            // PROSLEDJUJE SE SAMO REFERENCA (pokazuje na istu memoriju)
            void changeString(string str)
            {
                initialString = str;
            }
            
            // PROMENA VREDNOSTI
            changeNum(broj);
            changeString("Darko");

            // NOVE VREDNOSTI
            Console.WriteLine("NEW INT VALUE: " + broj);
            Console.WriteLine("NEW STRING VALUE: " + initialString);

            #endregion


        }


    }
}
