using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var cel = TempConverter.fahToCel(32);
            var fah = TempConverter.celToFah(32);

            Console.WriteLine("The conversion of 32 degrees celcius to fahrenheit is " + cel);
            Console.WriteLine("The conversion of 32 degrees fahrenheit to celcius is " + fah);
        }

        
    }
}
