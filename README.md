# Testing my React YT API website project with Selenium
##Description

I wrote few short tests for my React YT API project website.

## Technologies
* [c#](https://docs.microsoft.com/en-us/dotnet/csharp/) 
* [Selenium](https://www.selenium.dev/)

## Selenium

* PageFactory - class for initializing coorect web page elements and making use of them easier.

* Defining Web Element:

```c#
[FindsBy(How = How.Name, Using = "searchBar")]
public IWebElement txtSearchBar { get; set; }
```
An element with a css name value of "searchBar" will be automatically searched for and assigned to "txtSearchBar" variable.

