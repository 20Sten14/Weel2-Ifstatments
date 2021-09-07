using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm palub sisestada numbrit
            //programm kontrollib numbrit
            //Kui number on positiivne, konsool kuvab "number on positiivne"
            //kui number on nehatiivne, konsool kubvab "number on negatiivne"
            //kui sisetatud number on 0 siis konsool kuvab "null"
            //NB! INT32.Parse asemel kasutame Convert.ToInt32(Console.Readline());        


            Console.WriteLine("Palun sisetada mingi positiivne või negatiivne number.");

            int Number = Convert.ToInt32(Console.ReadLine());


            if (Number > 0)

            {
                Console.WriteLine("Number on positiivne!");

            }
            else if (Number < 0)
            {
                Console.WriteLine("Number on negatiivne!");

            }
            else
            {
                Console.WriteLine("Null!");
            }
        }
    }
}
