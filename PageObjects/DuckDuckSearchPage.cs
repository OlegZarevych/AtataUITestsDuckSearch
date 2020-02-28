using Atata;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtataUITestsDuckSearch.PageObjects
{
    using _ = DuckDuckSearchPage;

    [VerifyTitle("DuckDuckGo — Конфіденційність — це просто.")]
    [Url("/")]
    public class DuckDuckSearchPage : Page<DuckDuckSearchPage>
    {
        [FindById("search_form_input_homepage")]
        public TextInput<DuckDuckSearchPage> SearchFormInputHomepage { get; private set; }

        [FindById("search_button_homepage")]
        public Button<DuckDuckSearchResult, _> SearchButton { get; private set; }
    }
}
