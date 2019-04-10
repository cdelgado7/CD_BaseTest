using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;




namespace CD_BaseTest
{
    [TestClass]
     class UnitTest1
    {
        [TestMethod]
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            //IWebDriver driver = new RemoteWebDriver(new Uri("http://mke-seldock.laughlin.com:4444/wd/hub"), DesiredCapabilities.Chrome());


            driver.Url = "https://jdbystaging.wpengine.com/get-approved";

            //Zip needed if cookies/cache are cleared
            //var inputLocation = driver.FindElement(By.Id("dealershipSearch"));
            //inputLocation.SendKeys("53235");

            var Firstname = driver.FindElement(By.Id("nf-field-5"));
            Firstname.SendKeys("Carlos");

            System.Threading.Thread.Sleep(2000);

            var Lastname = driver.FindElement(By.Id("nf-field-6"));
            Lastname.SendKeys("Delgado");

            System.Threading.Thread.Sleep(2000);

            var Email = driver.FindElement(By.Id("nf-field-7"));
            Email.SendKeys("QAtesting@laughlin.com");

            System.Threading.Thread.Sleep(2000);

            var Phone = driver.FindElement(By.Id("nf-field-8"));
            Phone.SendKeys("414-555-5555");

            System.Threading.Thread.Sleep(2000);

            //locates preferred dealership dropdown so we can work with the values
            var select = driver.FindElement(By.Id("nf-field-11"));
            var selectElement = new SelectElement(select);
            System.Threading.Thread.Sleep(2000);
            selectElement.SelectByValue("WI102");

            var step1continue = driver.FindElement(By.Id("nf-field-10"));
            System.Threading.Thread.Sleep(2000);
            step1continue.Click();

            //adding a wait to allow step 2 to render
            System.Threading.Thread.Sleep(5500);

            //onto GMA Step 2 screen

            var Address = driver.FindElement(By.Id("nf-field-12"));
            Address.SendKeys("207 E. Michigan Ave");

            System.Threading.Thread.Sleep(2000);

            var City = driver.FindElement(By.Id("nf-field-13"));
            City.SendKeys("Milwaukee");

            var selectState = driver.FindElement(By.Id("nf-field-14"));
            var selectStateElement = new SelectElement(selectState);
            System.Threading.Thread.Sleep(2000);
            selectStateElement.SelectByValue("WI");

            System.Threading.Thread.Sleep(2000);

            var Zip = driver.FindElement(By.Id("nf-field-15"));
            Zip.SendKeys("53202");

            System.Threading.Thread.Sleep(2000);

            var DOB = driver.FindElement(By.Id("nf-field-29"));
            DOB.SendKeys("11");
            DOB.SendKeys("01");
            DOB.SendKeys("1980");

            System.Threading.Thread.Sleep(2000);

            var SSN = driver.FindElement(By.Id("nf-field-16"));
            SSN.SendKeys("1230005555");

            System.Threading.Thread.Sleep(2000);

            var Terms = driver.FindElement(By.Id("nf-field-22"));
            Terms.Click();

            System.Threading.Thread.Sleep(2000);

            var step2continue = driver.FindElement(By.Id("nf-field-20"));
            step2continue.Click();

            System.Threading.Thread.Sleep(5000);

            var Thankyou = driver.FindElement(By.XPath("//*[@id='post-93']/div/div/div/div/h2"));

       

           /*if (Thankyou == "Please enter a alue.")
                Console.WriteLine("Pass:GMA Step 2: Successfully submitted step2 data " + Thankyou);
            else
                Console.WriteLine("Fail: GMA Step 2: Unable to complete submission of step 2 data "); */






            // kill chrome...maybe??????     Response.Write("<script type=\"text/javascript\">window.close();</script>");





            //var PreferredDealership = driver.FindElement(By.Id("nf-field-11"))[3];
            //var dealership = driver.FindElement(By.ClassName("custom-select"))[3];
            //PreferredDealership.click;

        }
    }
}
