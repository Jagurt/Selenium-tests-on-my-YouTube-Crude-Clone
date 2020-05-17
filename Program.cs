using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestyYTReactAPI
{
    class Program
    {
        static void Main( string[] args )
        {

        }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.Driver = new ChromeDriver();
            PropertiesCollection.Driver.Navigate().GoToUrl("localhost:3000");
        }

        [Test]
        public void ExecuteTest()
        {
            PageObject pageObject = new PageObject();
            
            Thread.Sleep(3000);
            pageObject.ClickSearchResult(0);    // Klikam pierwszy wynik wyszukiwania który powinien być filmikiem
            Thread.Sleep(3000);
            pageObject.ClickSearchResult(1);    // Klikam drugi wynik wyszukiwania w pasku obok który powinien być playlistą
            Thread.Sleep(3000);                 // z jakiegoś powodu, jeśli kliknę w nie playlistę(video) w pasku obok to video nie zmieni się, próbowałem naprawić, nie wyszło ... jednak wyszło
            pageObject.ClickSearchResult(3);    // Klikam 4 wynik wyszukiwania w playliście który jest playListItem'em
            Thread.Sleep(3000); 
            pageObject.ClickVideoToPlay();      // Klikam w okienko żeby odpalić video
            Thread.Sleep(3000);
            pageObject.SearchResult("TheFatRat"); // Szukam kozackiego twórcę muzyki

            Thread.Sleep(5000);
        }

        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.Driver.Close();        // Zamykanie okna testowej przeglądarki
            PropertiesCollection.Driver.Dispose();      // kończenie procesu "chromedriver.exe"
        }
    }
}
