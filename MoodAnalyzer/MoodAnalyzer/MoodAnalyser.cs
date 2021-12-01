using System;

namespace MoodAnalyzer
{
    public class MoodAnalyser
    {
        private string message;
        public MoodAnalyser(string Message) 
        {
            this.message = Message;
        }
        /*public string AnalyzeMood(string message) 
        {
            try
            {
                if (this.message.Equals(string.Empty))
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Mood Should Not be Empty");
                if (message.Contains("Sad"))
                    return "Sad";
                else
                    return "Happy";
            }
            catch(NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Mood Should Not be Null");
            }
        }*/
        public string AnalyzeMood(string message)
        {
            try
            {
                if (this.message.Equals(string.Empty))
                    throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Mood Should Not be Null");
                if (message.Contains("Sad"))
                    return "Sad";
                else
                    return "Happy";
            }
            catch (NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Mood Should Not be Null");
            }
        }

    }
}