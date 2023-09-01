using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserTesting
{
    public class MoodAnalyser
    {
        
            string message;
            public MoodAnalyser(string message)
            {
                this.message = message;
            }
        
            public string AnalyzeMood()
            {
            try
            {
                if (this.message.Equals(string.Empty)) 
                
                    throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be Empty");
                

                if (this.message.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch
            {
                throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be Empty");

            }
        }
        }
}
