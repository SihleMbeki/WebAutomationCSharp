using System.ComponentModel.DataAnnotations;

namespace CommonsUtility
{
    public static class RandGenerator
    {
        public static string RandomNumber(int lenght = 10)
        {
            string randomNumbers =null;
            var random = new Random();
            for(int x=0; x < lenght; x++)
            {
                randomNumbers = random.Next(0, 9).ToString();
            }
            return randomNumbers;
        }

    }
}