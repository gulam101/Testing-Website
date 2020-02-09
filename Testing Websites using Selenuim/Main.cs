using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Program
  {
     static void Main(string[] args)
     {
        string URL = "https://www.google.com/";
        string ID = "lga";

        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl(URL);

        IWebElement GoogleURL = driver.FindElement(By.Id(ID));

     }
 }
