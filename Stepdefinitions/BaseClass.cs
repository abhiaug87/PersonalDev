using OpenQA.Selenium;

namespace PersonalDev.Stepdefinitions
{
    public class BaseClass
    {
        public static IWebDriver Driver { get; set; }


        public static void Sleep(int Seconds)
        {
            Thread.Sleep(Seconds * 1000);
        }
    }
}