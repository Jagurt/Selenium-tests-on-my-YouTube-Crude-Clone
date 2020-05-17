using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestyYTReactAPI
{
    enum ElementType { Id, Name, LinkText, CssName, ClassName }

    class PropertiesCollection
    {
        public static IWebDriver Driver { get; set; }
    }
}
