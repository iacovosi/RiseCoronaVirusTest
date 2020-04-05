using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RiseCoronaVirusTest
{
    public partial class App : Application
    {
        public App()
        {
            //InitializeComponent();

          //  MainPage = new MainPage();
		  			var tabs = new TabbedPage ();
			tabs.Children.Add(new WebPage("coronatest.ucy.ac.cy") { Title = "CoronoVirusTest" });
			tabs.Children.Add(new WebPage("covid-19.rise.org.cy") { Title = "CovTracker" });
			MainPage = tabs;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
