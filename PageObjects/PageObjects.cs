using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PersonalDev.PageObjects
{
    public class Pageobjects
    {
       public Pageobjects(IWebDriver driver)
        {
           PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "login-submit")]
        public IWebElement cont;

        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement username;

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement password;

        [FindsBy(How = How.Id, Using = "login-submit")]
        public IWebElement login;

        [FindsBy(How = How.XPath, Using = "//*[@id='root']/div[3]/div/div[2]/div[2]/div/div/div/div[3]/div/div[2]/a[1]/button/div")]
        public IWebElement confluence;

        [FindsBy(How = How.XPath, Using = "//*[@id='AkTopNav']/div[1]/header/nav/div[3]/div[1]/div/a/span/div/span/span")]
        public IWebElement home;

        [FindsBy(How = How.XPath, Using = "//*[@id='content-body']/div/main/div[1]/div/div[2]/a/p[1]")]
        public IWebElement space;

        [FindsBy(How = How.XPath, Using = "//*[@id='AkSideNavigation']/div/div[1]/div/div/nav/div[2]/div/div/div/div/a[1]/div/span[2]/span/span")]
        public IWebElement overview;

        [FindsBy(How = How.XPath, Using = "//*[@id='tools-menu-trigger']/span/span")]
        public IWebElement restrictionsmenu;

        [FindsBy(How = How.XPath, Using = "//*[@id='bm-restrictions-link']/span/span/span")]
        public IWebElement restrictionstxt;

        [FindsBy(How = How.XPath, Using = "//*[@id='com-atlassian-confluence']/div[2]/div[3]/div/div[3]/div[2]/div/div/header/div/h1")]
        public IWebElement restrictionstitle;

        [FindsBy(How = How.XPath, Using = "//*[@id='com-atlassian-confluence']/div[2]/div[3]/div/div[3]/div[2]/div/div/div[2]/footer/div/div[2]/button/span/span")]
        public IWebElement apply;

        [FindsBy(How = How.XPath, Using = "div.fabric-user-picker__value-container.fabric-user-picker__value-container--is-multi.css-pspj7h")]
        public IWebElement selectuser;

        [FindsBy(How = How.XPath, Using = "//*[@id='com-atlassian-confluence']/div[2]/div[3]/div/div[3]/div[2]/section/div/div[3]/div/div/div[1]/button/span/span")]
        public IWebElement cancelbtn;

        [FindsBy(How = How.CssSelector, Using = "div.css-4avucx-control")]
        public IWebElement restrictionstf;

        [FindsBy(How = How.CssSelector, Using = "div.css-11e7u0k.e1er2gfe2")]
        public IWebElement restrictionstxt1;

        [FindsBy(How = How.XPath, Using = "//*[@id='com-atlassian-confluence']/div[2]/div[3]/div/div[3]/div[2]/div/div/div[1]/div/div/div[2]/div/div/div[1]/div/div/div/div[1]")]
        public IWebElement usergroup;

        [FindsBy(How = How.XPath, Using = "//*[@id='com-atlassian-confluence']/div[2]/div[3]/div/div[3]/div[2]/div/div/div[1]/div/div/div[2]/div/div/div[3]/button/span")]
        public IWebElement add;

        [FindsBy(How = How.XPath, Using = "//*[@id='com-atlassian-confluence']/div[2]/div[3]/div/div[3]/div[2]/div/div/div[1]/div/div/div[3]/div[1]/table/tbody/tr[3]/td[3]")]
        public IWebElement remove;

        [FindsBy(How = How.XPath, Using = "//*[@id='com-atlassian-confluence']/div[2]/div[3]/div/div[3]/div[2]/div/div/div[1]/div/div/div[3]/div[1]/table/tbody/tr[3]/td[2]")]
        public IWebElement edit;


    }
}
