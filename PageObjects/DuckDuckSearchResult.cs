using Atata;

namespace AtataUITestsDuckSearch.PageObjects
{
    [Url("/?q=")]
    public class DuckDuckSearchResult : Page<DuckDuckSearchResult>
    {
        [FindById]
        [WaitFor(Until.Visible, TriggerEvents.Init)]
        public Clickable<DuckDuckSearchResult> Header { get; private set; }
    }
}