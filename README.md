A. Framework Highlights:

- This is a page object model framework created using Selenium, Specflow & C#. 
- The framework is capable of running tests on real browsers as well as in headless mode. It also supports cross browser testing (Chrome & Edge at the moment). 
- The framework also has a function to capture screenshots of the page where the test fails. The screenshot folder can be accessed from ../bin/Debug directory.


B. Framework Description:

The framework is seggregated into various parts (explained below) for better understandablibity & easier maintainability.

1. Scenarios Folder: Contains specflow file with the BDD user scenarios.

2. Steps Folder: This contains the step definitions class file which has the logic for the user scenarios mentioned in the specflow file. This folder also has the base class whose properties are inherited in the step definitions section.

3. Page objects Folder: This contains the page objects class file which contains all the element ids that are used in the project.

4. Data Folder: This contains a class file which has logic for allowing the framework to read data from a json file rather than hard coding the test data into the step definition. It also contains a json file which stores all the test data that will be used by the application under test.

5. Utilities Folder: This contains the following class files.

6. Common Constants - This contains code for location of the browser drivers, names of the tags that are used in the SpecFlow file

7. Hooks 
- This contains BeforeScenario & AfterScenrio functions that direct the test to perform actions before it starts & after it ends. Before starting the test checks whether it has to run the test has to run on a real browser or in headless mode depending on the tag mentioned on top of the scenario in the SpecFlow file. After the test is over, the framework captures images of any failed tests & then disposes the browser.
- This also contains logic for reporting results of the test run using the BeforeFeature, AfterStep, InitializeReport & PublishReport functions.

8. DriverFactory - This contains the logic for running tests in real browser or headless mode. It also contains logic for driver timeout & maximize while running tests in real browser mode.


C. Pre-requisites & Getting Started:

1. Download the edge driver version supported by your browser. Create a folder called "MicrosoftWebDriver" under "C:\Users\yourusername\AppData\Local\Temp" & add the edge driver version in this folder for the web browser to initiate. Make sure you name it as "MicrosoftWebDriver.exe"

2. Download the chrome driver version supported by your browser. Create a folder called "chromedriver" under "C:\Users\yourusername\AppData\Local\Temp" & add the chrome driver version in this folder for the web browser to initiate. Make sure you name it as "chromedriver.exe"

3. Install Microsoft visual studio 2019 (community edition will do)

4. Install SpecFlow for visual studio

5. Clone the bitbucket repo to your local machine

6. Open the .sln file using visual studio 2019


D. Running Tests on Chrome:

1. Add the tag @Chrome in SpecFlow on top of scenario every scenario. This is because specflow does not support feature level tags (https://github.com/SpecFlowOSS/SpecFlow/issues/2024)

2. Create a folder called "chromedriver" under "C:\Users\yourusername\AppData\Local\Temp" & add the chrome driver version supported by your browser in this folder for the web browser to initiate. Make sure you name it as "chromedriver.exe"

3. Right click on PersonalDevelopment (7) in test explorer & click Run


E. Running Tests on Edge:

1. Add the tag @Edge in SpecFlow on top of scenario every scenario. This is because specflow does not support feature level tags (https://github.com/SpecFlowOSS/SpecFlow/issues/2024)

2. Create a folder called "MicrosoftWebDriver" under "C:\Users\yourusername\AppData\Local\Temp" & add the chrome driver version supported by your browser in this folder for the web browser to initiate. Make sure you name it as "MicrosoftWebDriver.exe"

3. Right click on PersonalDevelopment (7) in test explorer & click Run


F. Running Tests in Headless Mode:

1. Add the tag @Headless in SpecFlow on top of scenario every scenario. This is because specflow does not support feature level tags (https://github.com/SpecFlowOSS/SpecFlow/issues/2024)

2. Right click on PersonalDevelopment (7) in test explorer & click Run


G. Troubleshooting:

1. If the webdriver does not start for some reason & the tests timeout in a few milliseconds:

Option 1:
-  Close Visual Studio 2019 & close the project folder on your machine. Then open the project folder again & open the .sln file with Visual Studio 2019.

Option 2:
-  Delete the .exe file from your 'Temp' folder & paste the .exe file again from another folder. Then run the tests again.  

Option 3:
- Restart the machine. Open the project, clean the solution & run the tests again.

NB: Please try Option 1 or Option 2 first. If it does not work, then try either Option 3.

2. In a rare occasion, if there is a webdriver timeout when test runs are in progress, then clean the solution & rerun the tests again.
