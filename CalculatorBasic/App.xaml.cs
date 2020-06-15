using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculatorBasic
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CalculatorBasic.Views.Calculator();
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
