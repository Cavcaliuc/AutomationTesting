## AutomationTesting
with Selenium WebDriver

# Laboratory work nr.5: Introduction to automation
# Laboratory task:
Create and run a test for given variant, using automation scripts. Upload created project on GitHub. Attach to email link to your GitHub repository.
# Variants:
Variant 1	Open google.com. Search for computer. Check that google header is displayed
Variant 2	Open youtube.com. Search for computer. Check that youtube header is displayed
Variant 3	Open amazon.com. Search for computer. Check that amazon header is displayed
Variant 4	Open ebay.com. Search for computer. Check that ebay header is displayed
Variant 5	Open aliexpress.com. Search for computer. Check that aliexpress header is displayed
Variant 6	Open 999.md. Search for computer. Check that 999 header is displayed
Variant 7	Open reddit.com. Search for computer. Check that reddit header is displayed
Variant 8	Open 9gag.com. Search for computer. Check that 9gag header is displayed

# Work requirements:
Install IDE. Suggested IDE is IntelijIDEA: https://www.jetbrains.com/idea/download/#section=windows

# Install selenium web driver:
https://www.guru99.com/intellij-selenium-webdriver.html#:~:text=Step%203)%20Now%20You%20need,4)%20Select%20all%20the%20selenium%20.

Suggested programming languages: Kotlin and Java.
Allowed Languages are: Kotlin, Java, Python, C#
Suggested dependency manager - MAVEN


Rapoartele trebuie scrise în format word sau pdf. Fiecare raport trebuie trimis prin e-mail.
Toate rapoartele trebue sa contina propria evaluare, adica sa fie notate de catre studenti
Email: mihail.lungu.qa@gmail.com


# As one of the most widely used test automation frameworks in the world, Selenium is definitely a popular test framework suite for automating web browser testing. 

# Selenium Automation Framework
An Automation Framework is collection of assumptions, concepts and practices you bring in while developing the automation project, so it helps in constituting a work platform or support for automated testing. It would be great, if the framework is application independent.
If you look into the any existing framework, it will be block of function libraries for reporting, error handling, and driver scripts. So the test automation framework is an execution environment for automated tests. It is the overall system in which our tests will be automated.

# Selenium WebDriver
Selenium WebDriver is a browser-specific driver which helps in accessing and launching the different browsers whether it’s desktop browsers or mobile browsers. That means it does not support for example Windows applications. It provides an interface to write and run automation scripts. Every browser has different drivers to run tests.
Chrome has ChromeDriver, Firefox has GeckoDriver, Safari has SafariDriver and so on, due to the fact that every browser has a different way of performing actions i.e. loading a page.
WebDriver has the capability to test modern and dynamic websites, sites where content is changing dynamically with a click of a button for example. As you will find out later when we go through the architecture, it works by interacting with the browser in more or less the same way as a real user would.
The Selenium WebDriver architecture works in the following way. You write your tests in your preferred programming language, this is communicated in JSON over HTTP (REST API) to the browser-specific driver which then, in turn, instantiate and communicates via HTTP to the browser itself and the browser communicates back with an HTTP response.

Therefore it does not matter what language you use as Selenium communicates with the Client Library and the Browser Driver will then handle the specific actions.


# Selenium WebDriver refers to both the language bindings and the implementations of the individual browser controlling code. This is commonly referred to as just WebDriver.

Selenium WebDriver is a W3C Recommendation

- WebDriver is designed as a simple and more concise programming interface.

- WebDriver is a compact object-oriented API.

- It drives the browser effectively.


# Selenium WebDriver speaks directly to the browser using browser drivers for a particular browser.

Selenium WebDriver supports the following languages
- Java
- Python
- C#
- Ruby
- Perl
- PHP

# 1.Architecture

- Selenium WebDriver’s architecture is simple than Selenium RC’s.
- It controls the browser from Operating System-level.

# All you need are your programming languages IDE and a browser
- Selenium RC’s architecture is more complicated than WebDriver
- You first need to install and launch a separate application called Selenium Remote Control 

# Server before you start running test scripts
- The Selenium RC Server acts as a mediator between your browser and your Selenium commands

# The following operations are performed behind the scenes when you run your tests scripts in Selenium RC:
- The Selenium RC Server injects a Javascript Program called Selenium Core into the browser
- Once the Selenium Core is injected it will start receiving instructions from the RC server based on test scripts
- Once the instructions are received, Selenium Core executes all these as Javascript commands.
- The web browser will execute all the commands of Selenium Core and returns its response to the RC Server.
- The RC Server will receive the browser response and then display the results.


# 2. Speed

Selenium WebDriver scripts execution is faster than Selenium RC since it speaks directly to the browser using browser drivers for a particular browser.

Selenium RC scripts execution is slower than Selenium WebDriver since it uses a Javascript program called Selenium Core. This Selenium Core directly controls the browser.

# 3. Real-life Interaction

Selenium WebDriver communicates with elements the page in a more realistic way. For example, if you have disabled dropdown on a webpage you are testing, WebDriver cannot select any value in it just like how a real person can’t do.

Just like other JavaScript codes, Selenium RC can access disabled elements.

# 4.Object-Oriented

Selenium RC is less object-oriented API, whereas Selenium WebDriver is purely object-oriented API. Selenium WebDriver is purely based on object-oriented programming languages like C#, Java, Python, etc. Selenium RC has weak API, whereas WebDriver has Strong API.

# 5. Browser Support

Selenium WebDriver can support a headless HTMLUnit browser. The term Headless refers to an invisible browser written in java. It can be configured to simulate a specific browser. It is a very fast browser because of no need to wait till the time in waiting for page elements to get loaded. 

Selenium RC can not support the headless HtmlUnit browser. To operate it needs a real, visible browser.

# Limitations of  WebDriver

- Selenium doesn’t support windows based applications. 
- By alone Selenium tool cannot test mobile applications, we can achieve it with the help of Appium.
- By alone Selenium tool cannot test Windows-based popup, we need to use AutoIT tool to handle the windows based popups
- Selenium uses JUnit/ TestNG for reporting since selenium doesn’t have inbuilt reporting capability.
- Selenium doesn’t have an in-built object repository.
- No reliable support is available because of an open-source.
- Selenium doesn’t support to perform testing on images, we need to use Sikuli for image-based testing.

Selenium RC has In-built Test Result Generator

Selenium RC mechanically generates an HTML file to test results. RC by itself sets the report format.

Selenium WebDriver has no in-built command to generate a Test Results File automatically. You have to depend on your IDE’s output window or you need to design the report by yourself by using the programming language capabilities.

# Why Use Selenium Framework for Automated Browser Testing?
As we now are familiar with the makeup of Selenium and the tools at hand, let’s take a look at the main points or benefits of Selenium and why it is a good tool for automation testing:
- Open Source: Selenium is open source, this means that no licensing or cost is required, it is totally free to download and use. This is not the case for many other automation tools out there.
- Mimic User Actions: As stated earlier, Selenium WebDriver is able to mimic user input, in real scenarios, you are able to automate events like key presses, mouse clicks, drag and drop, click and hold, selecting and much more.
- Easy Implementation: Selenium WebDriver is known for being a user-friendly automation tool. Selenium being Open Source means that users are able to develop extensions for their own needs.
- Tool for every scenario: As mentioned earlier, Selenium is a suite of tools, and you will most likely find something that fits your scenario and your way of working.
- Language Support: One big benefit is multilingual support. Selenium supports all major languages like Java, JavaScript, Python, Ruby, C sharp, Perl, .Net and PHP, giving the developer a lot of freedom and flexibility.
- Browser, Operating System & Device support: Selenium supports many different browsers Chrome, Firefox, Opera, Internet Explorer, Edge, and Safari as well as operating systems (Windows, Linux, Mac)
- Framework Support: Selenium also supports a multitude of frameworks like Maven, Junit, TestNG to make it easier to automate testing. CI and CD tools like Jenkins is also supported, for automating the deployment process.
- Reusability: Scripts written for WebDriver is cross-browser compatible. Testers can therefore run multiple testing scenarios with the same base.
- Community Support: The Selenium community is quite active and open. Therefore, there is a lot of information and help available when needed.
- Advanced User Input: With WebDriver it is possible to request clicking of the browser back and front buttons. A practical feature when testing money transfer applications for example. This feature is not found in many tools, especially open source.


# Variant 4	Open ebay.com. Search for computer. Check that ebay header is displayed

# The code from Visual Studio.
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationTesting 

{
    [TestClass]
    public class MS_Test_Cross_Browser_Test
    {
        String test_url = "https://www.ebay.com/";

        [TestMethod]
        public void NavigateToDoApp()
        {
            IWebDriver driver;

            // Local Selenium WebDriver
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl(test_url);

            driver.Manage().Window.Maximize();

            // Click on Search box
            IWebElement searchBox = driver.FindElement(By.CssSelector("div[id='gh-ac-box2'] input"));
            searchBox.Click();
            // Write something
            searchBox.SendKeys("Computer");
            searchBox.SendKeys(Keys.Enter);

            IWebElement header = driver.FindElement(By.CssSelector("header[id='gh']"));

            Console.WriteLine("\n-------------------------\n");
            Console.WriteLine("TEST PASSED");
            Console.WriteLine("\n-------------------------\n");

            driver.Quit();
        }
    }
}


# And the result.
# TEST PASSED

# Conclusion:

The aim of this laboratory work was to understand the importance - how to Create and run a test  using automation scripts, for:

# Variant 4	Open ebay.com. Search for computer. Check that ebay header is displayed

Upload created project on GitHub. Attach to email link to your GitHub repository.

- Due to simpler architecture, Selenium WebDriver is faster than Selenium RC
- Selenium RC cannot support HtmlUnit browser like WebDriver
- Selenium RC takes the help of RC Server to talks to the browser, where WebDriver talks to the browser directly.
- WebDriver is a tool used for testing web-based applications across multiple browsers with different programming languages.
- Selenium WebDriver’s API is briefer than Selenium RC’s.
- WebDriver cannot readily support new browsers like Selenium RC.
- WebDriver does not have an in-built command for automatic test results generation.

