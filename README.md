# Xamarin-DeepLink

Steps to run the applications
1. Run both the application in different instance of visual studio.
2. Deploy both the application in device or simulator/emaulator.
3. Once both the app are deployed. Open the first app and press "Go to App2" button.
4. You will see the App2 getting launched.

<b>Deepdive</b>
A dependency service is being written where we have implemented IAppHandler interface and handled platform specific navigation. For iOS it is important to tally the url scheme. Please check info.plist of both the application. 
In we have passed "second://" as the url scheme for the 2nd app. It's imporant to note the "LSApplicationQueriesSchemes" property in DeepLinkDemo1 project and it is 
important to note URLTypes and URL Schemes property in DeepLinkDemo2 project. 
