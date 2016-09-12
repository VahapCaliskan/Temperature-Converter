using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aus welcher Grad-Einheit möchtest du konvertieren?");
            Console.WriteLine("1. Fahrenheit\n2. Celsius\n3. Kelvin\n4. Rankine");
            Console.WriteLine("Bitte gebe die entsprechende Ziffer ein (1-4)");
            string sFrom = Console.ReadLine();
            Console.WriteLine("In welche Grad-Einheit möchtest du konvertieren?");
            Console.WriteLine("1. Fahrenheit\n2. Celsius\n3. Kelvin\n4. Rankine");
            Console.WriteLine("Bitte gebe die entsprechende Ziffer ein (1-4)");
            string sTo = Console.ReadLine();
            Console.WriteLine("Bitte gebe den Wert ein:");
            double dDegree = Double.Parse(Console.ReadLine());
            if (sFrom == sTo) {
                string sUnit = "NaN";
                if (sFrom == "1") { sUnit = "°F"; }
                else if (sFrom == "2") { sUnit = "°C"; }
                else if (sFrom == "3") { sUnit = "K"; }
                else if (sFrom == "4") { sUnit = "°R"; }
                Console.WriteLine(dDegree.ToString() + sUnit);
            }
            else if (sFrom == "1" && sTo == "2") { Console.WriteLine(FahrenheitToCelsius(dDegree)); }
            else if (sFrom == "1" && sTo == "3") { Console.WriteLine(FahrenheitToKelvin(dDegree)); }
            else if (sFrom == "1" && sTo == "4") { Console.WriteLine(FahrenheitToRankine(dDegree)); }
            else if (sFrom == "2" && sTo == "1") { Console.WriteLine(CelsiusToFahrenheit(dDegree)); }
            else if (sFrom == "2" && sTo == "3") { Console.WriteLine(CelsiusToKelvin(dDegree)); }
            else if (sFrom == "2" && sTo == "4") { Console.WriteLine(CelsiusToRankine(dDegree)); }
            else if (sFrom == "3" && sTo == "1") { Console.WriteLine(KelvinToFahrenheit(dDegree)); }
            else if (sFrom == "3" && sTo == "2") { Console.WriteLine(KelvinToCelsius(dDegree)); }
            else if (sFrom == "3" && sTo == "4") { Console.WriteLine(KelvinToRankine(dDegree)); }
            else if (sFrom == "4" && sTo == "1") { Console.WriteLine(RankineToFahrenheit(dDegree)); }
            else if (sFrom == "4" && sTo == "2") { Console.WriteLine(RankineToCelsius(dDegree)); }
            else if (sFrom == "4" && sTo == "3") { Console.WriteLine(RankineToKelvin(dDegree)); }
            Console.Read();
        }
        static string CelsiusToFahrenheit(double dCelsius) { return (dCelsius * 9 / 5 + 32).ToString() + "°F"; }
        static string CelsiusToKelvin(double dCelsius) { return (dCelsius + 273.15).ToString() + "K"; }
        static string CelsiusToRankine(double dCelsius) { return ((dCelsius + 273.15) * 9 / 5).ToString() + "°R"; }
        static string FahrenheitToCelsius(double dFahrenheit) { return ((dFahrenheit - 32) * 5 / 9).ToString() + "°C"; }
        static string FahrenheitToKelvin(double dFahrenheit) { return ((dFahrenheit + 459.67) * 5 / 9).ToString() + "K"; }
        static string FahrenheitToRankine(double dFahrenheit) { return (dFahrenheit + 459.67).ToString() + "°R"; }
        static string RankineToFahrenheit(double dRankine) { return (dRankine - 459.67).ToString() + "°F"; }
        static string RankineToCelsius(double dRankine) { return ((dRankine - 491.67) * 5 / 9).ToString() + "°C"; }
        static string RankineToKelvin(double dRankine) { return (dRankine * 5 / 9).ToString() + "K"; }
        static string KelvinToFahrenheit(double dKelvin) { return (dKelvin * 9 / 5 - 459.67).ToString() + "°F"; }
        static string KelvinToCelsius(double dKelvin) { return (dKelvin - 273.15).ToString() + "°C"; }
        static string KelvinToRankine(double dKelvin) { return (dKelvin * 9 / 5).ToString() + "°R"; }
    }
}
