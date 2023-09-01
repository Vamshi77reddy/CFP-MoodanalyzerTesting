using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserTesting
{
    public class MoodAnalyzerCustomException : Exception
    {
        public enum ExceptionType
        {
            EMPTY_MESSAGE,
            NULL_MESSAGE,
          
        }
        public readonly ExceptionType Type;
        public MoodAnalyzerCustomException(ExceptionType type, string message) : base(message)
        {
            this.Type = type;
        }
        
    }
}
