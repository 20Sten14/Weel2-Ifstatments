using System;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaha vanust
            //Kui kasutaha on vanem , kui 18 siis konsoolis kuvatakse"oled piisavalt vana"
            //Kui kasutaha on noorem, kui 18, suus konsoolis kuvatakse "oled liiga noor"
            //Kui kasutaja on 18, siis konsoolis kuvatakse "oledgi 18"

            Console.WriteLine("kui vana sa oled");

            int Age = Int32.Parse(Console.ReadLine());

            if (Age > 18)
            {
                Console.WriteLine("Oled piisavalt vana :D");

            }
            else if (Age < 18)
            {
                Console.WriteLine("Kahjuks oled liiga noor!");
            }
            else
            {
                Console.WriteLine("Oledki 18.");
            }
            
            {
                Console.WriteLine("Ilusat päeva ;D");
            }
        }
        
    }
}
