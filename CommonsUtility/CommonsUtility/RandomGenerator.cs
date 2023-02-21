using System.ComponentModel.DataAnnotations;

namespace CommonsUtility
{
    public static class RandomGenerator
    {
        public static string RandomNumber(int lenght = 10)
        {
            string randomNumbers ="";
            var random = new Random();
            for(int x=0; x < lenght; x++)
            {
                randomNumbers += random.Next(0, 9).ToString();
            }
            return randomNumbers;
        }

        public static Guid guid()
        {
            return Guid.NewGuid();
        }

        public static string dateRandom()
        {
            var now = DateTime.Now;
            return now.ToString("yyyy-MM-dd HH:mm").Replace("-","_").Replace(" ","_").Replace(":","");
        }
    }
}