using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Final_Project
{

    [TestClass]
    public class Test_SwagLab
    {
        [TestMethod]
        public void Std_Filter_Search_Z_A()
        {
            TestSetup.NavigateToUrl(TestSetup.driver, TestSetup.url);
            System.Threading.Thread.Sleep(1000);

            IWebElement userName = TestSetup.driver.FindElement(By.Id("user-name"));
            TestSetup.HighlightElement(TestSetup.driver, userName);

            userName.SendKeys("standard_user");
            System.Threading.Thread.Sleep(1000);


            IWebElement password = TestSetup.driver.FindElement(By.Id("password"));
            TestSetup.HighlightElement(TestSetup.driver, password);

            password.SendKeys("secret_sauce");
            System.Threading.Thread.Sleep(1000);

            IWebElement login = TestSetup.driver.FindElement(By.Id("login-button"));
            TestSetup.HighlightElement(TestSetup.driver, login);

            login.Click();


            System.Threading.Thread.Sleep(2000);

            
            


            IWebElement filterBottun = TestSetup.driver.FindElement(By.ClassName("product_sort_container"));
            TestSetup.HighlightElement(TestSetup.driver, filterBottun);
            filterBottun.Click();


            System.Threading.Thread.Sleep(2000);
            IWebElement zaBottun = TestSetup.driver.FindElement(By.XPath("//*/select/option[@value='za']"));
            TestSetup.HighlightElement(TestSetup.driver, zaBottun);
            zaBottun.Click();
            System.Threading.Thread.Sleep(1000);

            ReadOnlyCollection<IWebElement> elements = TestSetup.driver.FindElements(By.ClassName("inventory_item_name"));

            string[] alltext = new string[elements.Count];

           



            for (int i = 0; i < elements.Count; i++)
            {
                string textTest = elements[i].GetAttribute("innerText");
                alltext[i] = textTest;

            }
            for (int i = 0; i < alltext.Length; i++)
            {
                if (i == elements.Count - 1)
                {
                   
                    Console.WriteLine("successfuly Z-A: " + i);
                    
                    
                    break;

                }
                if (String.Compare(alltext[i].ToUpper(), alltext[i + 1].ToUpper()) > 0)
                {
                    Console.WriteLine("successfuly Z-A: " + i);
                  
                    continue;
                }
                else
                {
                    Console.WriteLine("faill Z-A");
                    break;

                }

            }

            IWebElement logoutBTN = TestSetup.driver.FindElement(By.XPath("//*/button[@id='react-burger-menu-btn']"));
            TestSetup.HighlightElement(TestSetup.driver, logoutBTN);

            logoutBTN.Click();
            System.Threading.Thread.Sleep(2000);


            IWebElement logout = TestSetup.driver.FindElement(By.XPath("//*/a[@id='logout_sidebar_link']"));
            TestSetup.HighlightElement(TestSetup.driver, logout);

            logout.Click();
            System.Threading.Thread.Sleep(2000);
        }
       
        [TestMethod]
        public void Std_Filter_Search_A_Z()
        {
            TestSetup.NavigateToUrl(TestSetup.driver, TestSetup.url);
            System.Threading.Thread.Sleep(1000);

            IWebElement userName = TestSetup.driver.FindElement(By.Id("user-name"));
            TestSetup.HighlightElement(TestSetup.driver, userName);

            userName.SendKeys("standard_user");
            System.Threading.Thread.Sleep(1000);


            IWebElement password = TestSetup.driver.FindElement(By.Id("password"));
            TestSetup.HighlightElement(TestSetup.driver, password);

            password.SendKeys("secret_sauce");
            System.Threading.Thread.Sleep(1000);

            IWebElement login = TestSetup.driver.FindElement(By.Id("login-button"));
            TestSetup.HighlightElement(TestSetup.driver, login);

            login.Click();

            System.Threading.Thread.Sleep(2000);




            IWebElement filterBottun = TestSetup.driver.FindElement(By.ClassName("product_sort_container"));
            filterBottun.Click();


            System.Threading.Thread.Sleep(2000);
            IWebElement zaBottun = TestSetup.driver.FindElement(By.XPath("//*/select/option[@value='az']"));
            System.Threading.Thread.Sleep(2000);
            TestSetup.HighlightElement(TestSetup.driver, zaBottun);
            zaBottun.Click();
            System.Threading.Thread.Sleep(1000);

            ReadOnlyCollection<IWebElement> elements = TestSetup.driver.FindElements(By.ClassName("inventory_item_name"));

            string[] alltext = new string[elements.Count];

            for (int i = 0; i < elements.Count; i++)
            {
                string textTest = elements[i].GetAttribute("innerText");
                alltext[i] = textTest;

            }
            for (int i = 0; i < alltext.Length; i++)
            {
                if (i == elements.Count - 1)
                {
                    Console.WriteLine("successfuly A-Z: " + i);

                    break;

                }
                if (String.Compare(alltext[i].ToUpper(), alltext[i + 1].ToUpper()) < 0)
                {
                    Console.WriteLine("successfuly A-Z: " + i);
                    continue;
                }
                else
                {
                    Console.WriteLine("faill A-Z");
                    break;

                }
            }

            IWebElement logoutBTN = TestSetup.driver.FindElement(By.XPath("//*/button[@id='react-burger-menu-btn']"));
            TestSetup.HighlightElement(TestSetup.driver, logoutBTN);

            logoutBTN.Click();
            System.Threading.Thread.Sleep(2000);


            IWebElement logout = TestSetup.driver.FindElement(By.XPath("//*/a[@id='logout_sidebar_link']"));
            TestSetup.HighlightElement(TestSetup.driver, logout);

            logout.Click();
            System.Threading.Thread.Sleep(2000);
        }

        [TestMethod]
        public void Std_Filter_Search_High_Low()
        {
            TestSetup.NavigateToUrl(TestSetup.driver, TestSetup.url);
            System.Threading.Thread.Sleep(4000);

            IWebElement usernameinput = TestSetup.driver.FindElement(By.XPath("//div/input[@id='user-name']"));
            TestSetup.HighlightElement(TestSetup.driver, usernameinput);

            usernameinput.SendKeys("standard_user");
            System.Threading.Thread.Sleep(1000);


            IWebElement passwordinput = TestSetup.driver.FindElement(By.XPath("//div/input[@id='password']"));
            TestSetup.HighlightElement(TestSetup.driver, passwordinput);

            passwordinput.SendKeys("secret_sauce");
            System.Threading.Thread.Sleep(1000);

            IWebElement login = TestSetup.driver.FindElement(By.XPath("//form/input[@id='login-button']"));
            TestSetup.HighlightElement(TestSetup.driver, login);

            login.Click();
            System.Threading.Thread.Sleep(2000);

            IWebElement element = TestSetup.driver.FindElement(By.XPath("//select[@data-test='product_sort_container']"));
            TestSetup.HighlightElement(TestSetup.driver, element);

            element.Click();

            System.Threading.Thread.Sleep(4000);

            IWebElement element1 = TestSetup.driver.FindElement(By.XPath("//span/select/option[@value='hilo']"));
            TestSetup.HighlightElement(TestSetup.driver, element1);

            element1.Click();
            System.Threading.Thread.Sleep(4000);
            ReadOnlyCollection<IWebElement> webElements = TestSetup.driver.FindElements(By.XPath("//div/div[@class='inventory_item_price']"));

            double[] prices = new double[webElements.Count];

            for (int i = 0; i < webElements.Count; i++)
            {
                prices[i] = Convert.ToDouble(webElements[i].GetAttribute("innerText").Trim('$', ' '));
            }

            for (int i = 0; i < prices.Length; i++)
            {
                if (i == prices.Length - 1)
                {
                    Console.WriteLine("passed");
                    break;


                }
                if (prices[i] >= prices[i + 1])
                    continue;
                else
                {
                    Console.WriteLine("Faild");
                    break;
                }


            }
            IWebElement logoutBTN = TestSetup.driver.FindElement(By.XPath("//*/button[@id='react-burger-menu-btn']"));
            TestSetup.HighlightElement(TestSetup.driver, logoutBTN);

            logoutBTN.Click();
            System.Threading.Thread.Sleep(2000);


            IWebElement logout = TestSetup.driver.FindElement(By.XPath("//*/a[@id='logout_sidebar_link']"));
            TestSetup.HighlightElement(TestSetup.driver, logout);

            logout.Click();
            System.Threading.Thread.Sleep(2000);
        }

        [TestMethod]
        public void Std_Filter_Search_Low_High()
        {
            TestSetup.NavigateToUrl(TestSetup.driver, TestSetup.url);
            System.Threading.Thread.Sleep(4000);

            IWebElement usernameinput = TestSetup.driver.FindElement(By.XPath("//div/input[@id='user-name']"));
            TestSetup.HighlightElement(TestSetup.driver, usernameinput);

            usernameinput.SendKeys("standard_user");
            System.Threading.Thread.Sleep(1000);


            IWebElement passwordinput = TestSetup.driver.FindElement(By.XPath("//div/input[@id='password']"));
            TestSetup.HighlightElement(TestSetup.driver, passwordinput);

            passwordinput.SendKeys("secret_sauce");
            System.Threading.Thread.Sleep(1000);

            IWebElement login = TestSetup.driver.FindElement(By.XPath("//form/input[@id='login-button']"));
            TestSetup.HighlightElement(TestSetup.driver, login);

            login.Click();
            System.Threading.Thread.Sleep(2000);

            IWebElement element = TestSetup.driver.FindElement(By.XPath("//select[@data-test='product_sort_container']"));
            TestSetup.HighlightElement(TestSetup.driver, element);

            element.Click();

            System.Threading.Thread.Sleep(4000);

            IWebElement element1 = TestSetup.driver.FindElement(By.XPath("//span/select/option[@value='hilo']"));
            TestSetup.HighlightElement(TestSetup.driver, element1);

            element1.Click();
            System.Threading.Thread.Sleep(4000);
            ReadOnlyCollection<IWebElement> webElements = TestSetup.driver.FindElements(By.XPath("//div/div[@class='inventory_item_price']"));

            double[] prices = new double[webElements.Count];

            for (int i = 0; i < webElements.Count; i++)
            {
                prices[i] = Convert.ToDouble(webElements[i].GetAttribute("innerText").Trim('$', ' '));
            }

            for (int i = 0; i < prices.Length; i++)
            {
                if (i == prices.Length - 1)
                {
                    Console.WriteLine("passed");
                    break;


                }
                if (prices[i] <= prices[i + 1])
                    continue;
                else
                {
                    Console.WriteLine("Faild");
                    break;
                }


            }
            IWebElement logoutBTN = TestSetup.driver.FindElement(By.XPath("//*/button[@id='react-burger-menu-btn']"));
            TestSetup.HighlightElement(TestSetup.driver, logoutBTN);

            logoutBTN.Click();
            System.Threading.Thread.Sleep(2000);


            IWebElement logout = TestSetup.driver.FindElement(By.XPath("//*/a[@id='logout_sidebar_link']"));
            TestSetup.HighlightElement(TestSetup.driver, logout);

            logout.Click();
            System.Threading.Thread.Sleep(2000);
        }

        [TestMethod]
        public void problem_Filter_Search_Z_A()
        {
            TestSetup.NavigateToUrl(TestSetup.driver, TestSetup.url);
            System.Threading.Thread.Sleep(1000);

            IWebElement userName = TestSetup.driver.FindElement(By.Id("user-name"));
            TestSetup.HighlightElement(TestSetup.driver, userName);

            userName.SendKeys("problem_user");
            System.Threading.Thread.Sleep(1000);


            IWebElement password = TestSetup.driver.FindElement(By.Id("password"));
            TestSetup.HighlightElement(TestSetup.driver, password);

            password.SendKeys("secret_sauce");
            System.Threading.Thread.Sleep(1000);

            IWebElement login = TestSetup.driver.FindElement(By.Id("login-button"));
            TestSetup.HighlightElement(TestSetup.driver, login);

            login.Click();

            System.Threading.Thread.Sleep(2000);




            IWebElement filterBottun = TestSetup.driver.FindElement(By.ClassName("product_sort_container"));
            TestSetup.HighlightElement(TestSetup.driver, filterBottun);
            filterBottun.Click();


            System.Threading.Thread.Sleep(2000);
            IWebElement zaBottun = TestSetup.driver.FindElement(By.XPath("//*/select/option[@value='za']"));
            TestSetup.HighlightElement(TestSetup.driver, zaBottun);
            zaBottun.Click();
            System.Threading.Thread.Sleep(1000);

            ReadOnlyCollection<IWebElement> elements = TestSetup.driver.FindElements(By.ClassName("inventory_item_name"));

            string[] alltext = new string[elements.Count];

          



            for (int i = 0; i < elements.Count; i++)
            {
                string textTest = elements[i].GetAttribute("innerText");
                alltext[i] = textTest;

            }
            for (int i = 0; i < alltext.Length; i++)
            {
                if (i == elements.Count - 1)
                {
                  
                    Console.WriteLine("successfuly Z-A: " + i);

                    break;

                }
                if (String.Compare(alltext[i].ToUpper(), alltext[i + 1].ToUpper()) > 0)
                {
                    Console.WriteLine("successfuly Z-A: " + i);
                  
                    continue;
                }
                else
                {
                    Console.WriteLine("faill Z-A");
                    break;

                }
            }

            IWebElement logoutBTN = TestSetup.driver.FindElement(By.XPath("//*/button[@id='react-burger-menu-btn']"));
            TestSetup.HighlightElement(TestSetup.driver, logoutBTN);

            logoutBTN.Click();
            System.Threading.Thread.Sleep(2000);


            IWebElement logout = TestSetup.driver.FindElement(By.XPath("//*/a[@id='logout_sidebar_link']"));
            TestSetup.HighlightElement(TestSetup.driver, logout);

            logout.Click();
            System.Threading.Thread.Sleep(2000);
        }
        [TestMethod]
        public void Problem_Filter_Search_A_Z()
        {
            TestSetup.NavigateToUrl(TestSetup.driver, TestSetup.url);
            System.Threading.Thread.Sleep(1000);

            IWebElement userName = TestSetup.driver.FindElement(By.Id("user-name"));
            TestSetup.HighlightElement(TestSetup.driver, userName);

            userName.SendKeys("problem_user");
            System.Threading.Thread.Sleep(1000);


            IWebElement password = TestSetup.driver.FindElement(By.Id("password"));
            TestSetup.HighlightElement(TestSetup.driver, password);

            password.SendKeys("secret_sauce");
            System.Threading.Thread.Sleep(1000);

            IWebElement login = TestSetup.driver.FindElement(By.Id("login-button"));
            TestSetup.HighlightElement(TestSetup.driver, login);

            login.Click();

            System.Threading.Thread.Sleep(2000);




            IWebElement filterBottun = TestSetup.driver.FindElement(By.ClassName("product_sort_container"));
            filterBottun.Click();


            System.Threading.Thread.Sleep(2000);
            IWebElement zaBottun = TestSetup.driver.FindElement(By.XPath("//*/select/option[@value='az']"));
            System.Threading.Thread.Sleep(2000);
            TestSetup.HighlightElement(TestSetup.driver, zaBottun);
            zaBottun.Click();
            System.Threading.Thread.Sleep(1000);

            ReadOnlyCollection<IWebElement> elements = TestSetup.driver.FindElements(By.ClassName("inventory_item_name"));

            string[] alltext = new string[elements.Count];

            for (int i = 0; i < elements.Count; i++)
            {
                string textTest = elements[i].GetAttribute("innerText");
                alltext[i] = textTest;

            }
            for (int i = 0; i < alltext.Length; i++)
            {
                if (i == elements.Count - 1)
                {
                    Console.WriteLine("successfuly A-Z: " + i);

                    break;

                }
                if (String.Compare(alltext[i].ToUpper(), alltext[i + 1].ToUpper()) < 0)
                {
                    Console.WriteLine("successfuly A-Z: " + i);
                    continue;
                }
                else
                {
                    Console.WriteLine("faill A-Z");
                    break;

                }
            }
            IWebElement logoutBTN = TestSetup.driver.FindElement(By.XPath("//*/button[@id='react-burger-menu-btn']"));
            TestSetup.HighlightElement(TestSetup.driver, logoutBTN);

            logoutBTN.Click();
            System.Threading.Thread.Sleep(2000);


            IWebElement logout = TestSetup.driver.FindElement(By.XPath("//*/a[@id='logout_sidebar_link']"));
            TestSetup.HighlightElement(TestSetup.driver, logout);

            logout.Click();
            System.Threading.Thread.Sleep(2000);
        }

        [TestMethod]
        public void Problem_Filter_Search_High_Low()
        {
            TestSetup.NavigateToUrl(TestSetup.driver, TestSetup.url);
            System.Threading.Thread.Sleep(4000);

            IWebElement usernameinput = TestSetup.driver.FindElement(By.XPath("//div/input[@id='user-name']"));
            TestSetup.HighlightElement(TestSetup.driver, usernameinput);

            usernameinput.SendKeys("problem_user");
            System.Threading.Thread.Sleep(1000);


            IWebElement passwordinput = TestSetup.driver.FindElement(By.XPath("//div/input[@id='password']"));
            TestSetup.HighlightElement(TestSetup.driver, passwordinput);

            passwordinput.SendKeys("secret_sauce");
            System.Threading.Thread.Sleep(1000);

            IWebElement login = TestSetup.driver.FindElement(By.XPath("//form/input[@id='login-button']"));
            TestSetup.HighlightElement(TestSetup.driver, login);

            login.Click();
            System.Threading.Thread.Sleep(2000);

            IWebElement element = TestSetup.driver.FindElement(By.XPath("//select[@data-test='product_sort_container']"));
            TestSetup.HighlightElement(TestSetup.driver, element);

            element.Click();

            System.Threading.Thread.Sleep(4000);

            IWebElement element1 = TestSetup.driver.FindElement(By.XPath("//span/select/option[@value='hilo']"));
            TestSetup.HighlightElement(TestSetup.driver, element1);

            element1.Click();
            System.Threading.Thread.Sleep(4000);
            ReadOnlyCollection<IWebElement> webElements = TestSetup.driver.FindElements(By.XPath("//div/div[@class='inventory_item_price']"));

            double[] prices = new double[webElements.Count];

            for (int i = 0; i < webElements.Count; i++)
            {
                prices[i] = Convert.ToDouble(webElements[i].GetAttribute("innerText").Trim('$', ' '));
            }

            for (int i = 0; i < prices.Length; i++)
            {
                if (i == prices.Length - 1)
                {
                    Console.WriteLine("passed");
                    break;


                }
                if (prices[i] >= prices[i + 1])
                    continue;
                else
                {
                    Console.WriteLine("Faild");
                    break;
                }


            }

            IWebElement logoutBTN = TestSetup.driver.FindElement(By.XPath("//*/button[@id='react-burger-menu-btn']"));
            TestSetup.HighlightElement(TestSetup.driver, logoutBTN);

            logoutBTN.Click();
            System.Threading.Thread.Sleep(2000);


            IWebElement logout = TestSetup.driver.FindElement(By.XPath("//*/a[@id='logout_sidebar_link']"));
            TestSetup.HighlightElement(TestSetup.driver, logout);

            logout.Click();
            System.Threading.Thread.Sleep(2000);

        }

        [TestMethod]
        public void Problem_Filter_Search_Low_High()
        {
            TestSetup.NavigateToUrl(TestSetup.driver, TestSetup.url);
            System.Threading.Thread.Sleep(4000);

            IWebElement usernameinput = TestSetup.driver.FindElement(By.XPath("//div/input[@id='user-name']"));
            TestSetup.HighlightElement(TestSetup.driver, usernameinput);

            usernameinput.SendKeys("problem_user");
            System.Threading.Thread.Sleep(1000);


            IWebElement passwordinput = TestSetup.driver.FindElement(By.XPath("//div/input[@id='password']"));
            TestSetup.HighlightElement(TestSetup.driver, passwordinput);

            passwordinput.SendKeys("secret_sauce");
            System.Threading.Thread.Sleep(1000);

            IWebElement login = TestSetup.driver.FindElement(By.XPath("//form/input[@id='login-button']"));
            TestSetup.HighlightElement(TestSetup.driver, login);

            login.Click();
            System.Threading.Thread.Sleep(2000);

            IWebElement element = TestSetup.driver.FindElement(By.XPath("//select[@data-test='product_sort_container']"));
            TestSetup.HighlightElement(TestSetup.driver, element);

            element.Click();

            System.Threading.Thread.Sleep(4000);

            IWebElement element1 = TestSetup.driver.FindElement(By.XPath("//span/select/option[@value='hilo']"));
            TestSetup.HighlightElement(TestSetup.driver, element1);

            element1.Click();
            System.Threading.Thread.Sleep(4000);
            ReadOnlyCollection<IWebElement> webElements = TestSetup.driver.FindElements(By.XPath("//div/div[@class='inventory_item_price']"));

            double[] prices = new double[webElements.Count];

            for (int i = 0; i < webElements.Count; i++)
            {
                prices[i] = Convert.ToDouble(webElements[i].GetAttribute("innerText").Trim('$', ' '));
            }

            for (int i = 0; i < prices.Length; i++)
            {
                if (i == prices.Length - 1)
                {
                    Console.WriteLine("passed");
                    break;


                }
                if (prices[i] <= prices[i + 1])
                    continue;
                else
                {
                    Console.WriteLine("Faild");
                    break;
                }


            }

        }
        

    }
    
}

