// See https://aka.ms/new-console-template for more information

using CommonsUtility;
using NLog.Web;
using System.Reflection.Metadata;
using WebDriverUtility;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Output:" + RandomGenerator.RandomNumber(lenght: 5));
        Console.WriteLine("Output:" + RandomGenerator.RandomNumber());
        Console.WriteLine("Output:" + RandomGenerator.guid().ToString());
        Console.WriteLine("Output:" + RandomGenerator.dateRandom());
        Console.WriteLine("Output:" + DefaultNames.fileNames.Reports);

        var logger = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
        try
        {
            logger.Debug("Init main");
            logger.Error("test");
        }
        catch (System.Exception)
        {
            NLog.LogManager.Shutdown();
        }

        WebDriverUtility.WebDriverUtility.createDriver();
        WebDriverUtility.WebDriverUtility.LoadPage("https://www.google.com/");

}
}