using System;
using System.Threading.Tasks;
using DeepLinkDemo1.iOS;
using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(OpenAppiOS))]
namespace DeepLinkDemo1.iOS
{  
    public class OpenAppiOS : IAppHandler
    {
        public Task<bool> LaunchApp(string uri)
        {
            try
            {
                var canOpen = UIApplication.SharedApplication.CanOpenUrl(new NSUrl(uri));
                if (!canOpen)
                    return Task.FromResult(false);
                return Task.FromResult(UIApplication.SharedApplication.OpenUrl(new NSUrl(uri)));
            }
            catch (Exception ex)
            {
                return Task.FromResult(false);
            }
        }
    }
}
