﻿using Atata;
using AtataUITestsDuckSearch.PageObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtataUITestsDuckSearch
{
    [TestFixture]
    public class DuckSearch : UITestFixture
    {
        [Test]
        public void DuckDuckSearch()
        {
            Go.To<DuckDuckSearchPage>()
                .SearchFormInputHomepage
                .SetRandom()
                .SearchButton
                .ClickAndGo();
        }
    }
}