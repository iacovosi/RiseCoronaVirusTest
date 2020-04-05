using Xamarin.Forms;

namespace RiseCoronaVirusTest
{
    public class WebPage : ContentPage
    {
        public WebPage(string url)
        {
            var browser = new WebView();
            browser.Source = "http://"+ url;
            Content = browser;
        }
    }
}

