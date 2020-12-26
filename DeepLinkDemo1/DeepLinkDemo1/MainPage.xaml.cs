using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DeepLinkDemo1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                //Xamarin.Forms.Device.OpenUri(new Uri("second://"));
                //await Launcher.OpenAsync(new Uri("second://"));
                string appId = string.Empty;
                switch (Device.RuntimePlatform)
                {
                    case Device.iOS:
                        appId = "second://";
                        break;
                    case Device.Android:
                        appId = "com.molit.deeplinkdemo2";
                        break;
                    case Device.UWP:
                    default:
                        appId = string.Empty;
                        break;
                }

                var result = await DependencyService.Get<IAppHandler>().LaunchApp(appId);

            }
            catch (Exception ex)
            {
                // An unexpected error occured. No browser may be installed on the device.
            }
        }
    }
}
