using System;
namespace StaticExercise
{
    public class TempConverter
    {
        public static double fahToCel(double temp)
        {
            double Celsius = (temp - 32) / 1.8;
            return Celsius;
        }

        public static double celToFah(double temp)
        {
            double Fahrenheit = (temp * 9) / 5 + 32;
            return Fahrenheit;
        }
    }
}
