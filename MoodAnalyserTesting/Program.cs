using System;

namespace MoodAnalyserTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to mood Analyser problem");
            string message = "";
        MoodAnalyser mood1= new MoodAnalyser(message);
            Console.WriteLine("Given mood is " + message);
            Console.WriteLine("The retured value is : " +mood1.AnalyzeMood());
        }
    }
}
