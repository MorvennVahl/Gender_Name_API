# Projekttitel.: Gender_Name_API
Description.: This small Program determines, based on the desired input of the in form of a name, the gender of said name. Using an Gender-API free to use coming with a free licence, limited to 200 uses per day.

Used a httpRequest to get the Jsondata from the online server, to display on a basic website, everything written in c#, html, css. The gander string in the extracted json string was extracted on the razor page itself and is displayed in the crude webpage.

I can safely say that Rider as a coding platform was the best choice for this project.

----------------------------

How to run the Program.:
  - first you need to have the latest version of .NET installed to run the Program. 
  - secondly download the source code to your desktop and unpack it, so it doesnt appear in a zip folder. 
  - thirdly open the unzipped folder and write cmd into the Adress bar
    - a Command line prompt should open. 
      -type the following commands into cmd and press enter. 
        - dotnet build
        - dotnet run Name_Gender_API
          (it should automatically create a webserver and host on a localhost on your pc)
        - now copy the first https adress from the command line prompt and paste it in your browser (Chrome, Firefox etc.)
  
or for simplyfiying everything.: with docker.
  after downloading, you have to have installed the latest version of docker. 
  open the unzipped folder and write cmd into the Adress bar a Command line prompt should open. 
  then you type.: docker run -d -p 8080:80 name_gender_api
  into the console. press enter and go to your webbrowser. type.: localhost:8080 
  into the search bar and the program should start without problems. 
  
  https://docs.docker.com/desktop/windows/install/
  (the link for docker desktop /Windows)
  
----------------------------
  
 How to test the Program.:
  - create a new folder xy on your desktop put the project into it and generate a new folder in xy naming it Tests or whatever you like it
  - Open the Solution Name_Gender_API in your favorite IDE, Rider or Visual Studio..
  - Right click on the solution and add a Unit Test Project in the subsection .NET Core, but change the directory to the Tests folder not the project folder. This may save you some trouble
  - Go to nuget packages and add bUnit 1.6.4 or newer to the test Project
  - copy paste the _Imports.razor into the TestProject so save trouble 
  - now add a reference to the Test Solution.
    - Right click on the test solution, go to add and add reference and add the reference from the project. 
    - you have to add a using reference to the class.
      - go to the created UnitTest1.cs class that has been automatically generated and add.: using Name_Gender_API.Data; 
        to the Project. it now can access Classes and Functions declared.

  A simple Test could be.:
  
  ```
  using System.Collections.Generic;
  using Bunit;
  using Microsoft.Extensions.DependencyInjection;
  using MudBlazor;
  using NUnit.Framework;
  using Name_Gender_API.Data;
  using Name_Gender_API.Pages;


  namespace TestProject1;

  public class Tests 
  {
    private Bunit.TestContext _testContext;
    private IGenderNameService _genderNameService;
    [SetUp]
    public void Setup()
    {
        _testContext = new Bunit.TestContext();
        _genderNameService = new GenderNameService();
    }

    public void Teardown()
    {
        _testContext.Dispose();
    }

    [Test]
    [TestCase("Alexander", "male")]
    [TestCase(null, "female")]
    public void CounterComponentTest(string name, string gender)
    {
        ServerResponse response = new ServerResponse();
        Assert.IsTrue((name != null) || (gender != null));
    }
  }
  ```
  
  which can easily be pasted into the testproject and run.
  Have fun and stay safe!
  
  
