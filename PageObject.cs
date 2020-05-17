using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace TestyYTReactAPI
{
    class PageObject
    {
        public PageObject()
        {
            PageFactory.InitElements(PropertiesCollection.Driver, this);
        }

        [FindsBy(How = How.Name, Using = "searchBar")]
        public IWebElement txtSearchBar { get; set; }

        [FindsBy(How = How.Name, Using = "resultList")]
        public IWebElement listSearchResults { get; set; }

        [FindsBy(How = How.Name, Using = "player")]
        public IWebElement videoPlayer { get; set; }

        public void SearchResult( string initial )
        {
            txtSearchBar.Clear();
            txtSearchBar.SendKeys(initial);
            txtSearchBar.Submit();
        }

        public void ClickSearchResult(int i)
        {
            var results = listSearchResults.FindElements(By.Name("result"));

            results[i].Click();
        }

        public void ClickVideoToPlay()
        {
            videoPlayer.Click();
        }
    }
}
