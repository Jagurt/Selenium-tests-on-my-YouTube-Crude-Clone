# Testing my React YT API website project with Selenium
##Description

I wrote few short tests for my [React YT API project website](https://github.com/Jagurt/YT-API-in-React_project-for-Advanced-Internet_Technologies).


## Technologies

* [c#](https://docs.microsoft.com/en-us/dotnet/csharp/) 
* [Selenium](https://www.selenium.dev/)

### Nuget Packets Imported

* NUnit
* NUnit.ConsoleRunner
* NUnit3TestAdapter
* Selenium.Support
* Selenium.WebDriver
* Selenium.WebDriver.ChromeDriver

## Selenium
### PageObject.cs
* PageFactory - class for initializing coorect web page elements and making use of them easier.

* Defining Web Element:

```c#
[FindsBy(How = How.Name, Using = "searchBar")]
public IWebElement txtSearchBar { get; set; }
```
An element with a css name value of "searchBar" will be automatically searched for and assigned to "txtSearchBar" variable.<br />

There are 3 more methods in PageObject class, however they are very self explanatory so I will not mention them here.

### PropertiesCollection.cs

Class to store our static driver for easy acces and useful enum of web elements types.

## Program.cs

### Initialize

I launch Chrome Web Driver process and go to the "localhost:3000" adress on which my app runs.<br />
"\[SetUp]" decorator tells tests to make preparations before testing.

``` c#
[SetUp]
        public void Initialize()
        {
            PropertiesCollection.Driver = new ChromeDriver();
            PropertiesCollection.Driver.Navigate().GoToUrl("localhost:3000");
        }
```

### ExecuteTest

I perform some actions to check functionality of my app.<br />
I also use "Thread.Sleep()" method frequently to have clearer view on what is being done during tests.<br />

#### List of actions:

1. `pageObject.ClickSearchResult(0);` - click on first search result which should be a video.
1. `pageObject.ClickSearchResult(1);` - in playerMode, click on second search result on side bar which should be a playlist.
1. `pageObject.ClickSearchResult(3);` - in playlist, click 4th result which should be playlist item.
1. `pageObject.ClickVideoToPlay();` - in playerMode, click on the vide to start it.
1. `pageObject.SearchResult("TheFatRat");` - search one of my favourite music creators.

### CleanUp

I close the chrome testing window and stop chromedriver proces.

```c#
[TearDown]
        public void CleanUp()
        {
            PropertiesCollection.Driver.Close();        // Zamykanie okna testowej przeglądarki
            PropertiesCollection.Driver.Dispose();      // kończenie procesu "chromedriver.exe"
        }
```
