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

        //Goes to the specified URL link
        driver.Navigate().GoToUrl(URL);

        //Calls our element
        IWebElement GoogleURL = driver.FindElement(By.Id(ID));

     }
 }
