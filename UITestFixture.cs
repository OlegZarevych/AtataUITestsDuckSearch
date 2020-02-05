﻿using Atata;
using NUnit.Framework;

namespace AtataUITestsDuckSearch
{
    [TestFixture]
    public class UITestFixture
    {
        [SetUp]
        public void SetUp()
        {
            // Find information about AtataContext set-up on https://atata.io/getting-started/#set-up
            AtataContext.Configure().
                UseChrome().
                WithArguments("start-maximized").
                WithFixOfCommandExecutionDelay().
                WithLocalDriverPath().
                UseBaseUrl("https://duckduckgo.com/").
                UseCulture("en-us").
                UseNUnitTestName().
                AddNUnitTestContextLogging().
                LogNUnitError().
                UseAssertionExceptionType<NUnit.Framework.AssertionException>().
                UseNUnitAggregateAssertionStrategy().
                Build();
        }

        [TearDown]
        public void TearDown()
        {
            AtataContext.Current?.CleanUp();
        }
    }
}
