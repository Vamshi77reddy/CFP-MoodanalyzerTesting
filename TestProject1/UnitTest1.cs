using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SadMessageShouldReturnSad()
        {


            string expected = "SAD";
            string message = "i am in sad Mood";
            MoodAnalyser mood = new MoodAnalyser(message);
            string actual = mood.AnalyzeMood();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HappyMessageShouldReturnHappy()
        {
            string expected = "HAPPY";
            string message = "i am in Happy Mood";
            MoodAnalyser mood = new MoodAnalyser(message);
            string actual = mood.AnalyzeMood();
            Assert.AreEqual(expected, actual);
        }
      
    }
}

