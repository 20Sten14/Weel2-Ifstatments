using System;

namespace PersonalityTest
{
    class Program
    {

        static void Main(string[] args)
        {
            //Programm küsib kasutaha käest tema lemmik värvi
            //kui kasutaja sisestab "punane", konsool kuvab "oled romantiline"
            //kui kasutaja sisestab "sinine", konsool kuvab "oled töökas"
            //kui kasuaha sisestab "roheline", konsool kuvab "Oled looduse sõber"
            //kui kasutaha sisestab midagi muud, konsool kuvab "oled maun"


            Console.WriteLine("Mis on sinu lemmik värv?");
            String Usercolor = Console.ReadLine().ToLower();

            if (Usercolor == "punane")
            {
                Console.WriteLine("Sa oled romantiline!");
            }
            if (Usercolor == "sinine")
            {
                Console.WriteLine("Sa oled töökas");
            }
            if (Usercolor == "roheline")
            {
                Console.WriteLine("sa oled looduse sõber aka PEDE");
            }
            else 
            {
                Console.WriteLine("Ei");
            }

        }
    }
}
