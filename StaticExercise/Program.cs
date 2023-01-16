namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

           //var tempInput = Console.ReadLine();
           //FInd a way to use tempInput vs "36" below

           var celsius  =   TempConverter.CelsiusToFahrenheit(36);
           var fahrenheit = TempConverter.FahrenheitToCelsius((celsius * 9) / 5 + 32);

            Console.WriteLine($"Celsius Temp Converted to Fahenrenheit: {fahrenheit}");
            Console.WriteLine($"Original Temp (Celsius): {celsius}");
        }
    }
}

//Create a static class called TempConverter.

//The class should have at least 2 methods, one called FahrenheitToCelsius that will require a double as a parameter and return a double, the other CelsiusToFahrenheit which will also require a double as a parameter and return a double.

//Fill out these methods and call them in your Program.cs file. Make sure they’re accurate!

//For reference: https://github.com/mvdoyle/StaticExercise