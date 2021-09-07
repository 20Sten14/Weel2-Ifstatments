using System;

namespace PermanentDrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja sünniaastat
            //Programm kontrollib kasutaja vanust
            //Programm teatab kasutajat, kas ta on piisavalt vana
            //Et juhiluba saada

            Console.WriteLine("Mis aastal sa sündisid?");

            int YearOfBirth = Int32.Parse(Console.ReadLine());
            int Age = 2021 - YearOfBirth;
            Console.WriteLine("Sa oled " + Age);

            if (Age > 18 )

            {
                Console.WriteLine("Oled piisavalt vana!");

            }
            else if (Age < 18)
            {
                Console.WriteLine("Oled liiga noor et saada juhiluba!");

            }
            else
            {
                Console.WriteLine("Juhiloa taotlemine võimalik!");

            }


            





        }
    }
}
