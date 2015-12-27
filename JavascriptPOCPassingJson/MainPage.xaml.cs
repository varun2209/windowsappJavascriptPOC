using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using ChakraBridge;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace JavascriptPOCPassingJson
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            Console.OnLog += Console_OnLog;


            XMLHttpRequest apiCall = new XMLHttpRequest();
            apiCall.setRequestHeader("X-ROCKET-MOBAPI-TOKEN", "b5467071c82d1e0d88a46f6e057dbb88");
            apiCall.setRequestHeader("X-ROCKET-MOBAPI-VERSION", "1.8");
            apiCall.setRequestHeader("X-ROCKET-MOBAPI-PLATFORM", "application/windows.rocket.SHOP_MOBILEAPI_STAGING-v1.0+json");
            apiCall.setRequestHeader("X-USER-DEVICE-TYPE", "mobile");
            apiCall.setRequestHeader("X-ROCKET-MOBAPI-DEVICE-ID", "5yHaJvczNCz/IZ9zU1juJnfghAQ=");
            apiCall.setRequestHeader("X-ROCKET-MOBAPI-DEVICE-NAME", "RM-978_1046");
            apiCall.setRequestHeader("X-ROCKET-MOBAPI-HASH", "f18bea4e6ab96164e86ba8651d99e68a871bdf112f98d1bef78cbb8273686e9c");
            apiCall.setRequestHeader("X-ROCKET-MOBAPI-APP-VERSION", "2.5.0.0");
            apiCall.setRequestHeader("X-ROCKET-MOBAPI-DEVICE-META", "5yHaJvczNCz/IZ9zU1juJnfghAQ=|RM-978_1046|Wireless80211|Microsoft Windows NT 8.10.14234.0|f18bea4e6ab96164e86ba8651d99e68a871bdf112f98d1bef78cbb8273686e9c|2.5.0.0");
    
            apiCall.open("GET", "http://mobapi.jabong.com/mobapi/main/initapi");
            apiCall.send(null);

            ChakraHost host = new ChakraHost();
            CommunicationManager.RegisterType(typeof(RootObject));

            CommunicationManager.OnObjectReceived = (data) => {
                RootObject empObj = (RootObject)data;
                System.Diagnostics.Debug.WriteLine(empObj);
            };

            var script = await CoreTools.GetPackagedFileContentAsync("JavaScriptModule", "JsonParser.js");
            host.RunScript(script);

            var callResult = await CoreTools.DownloadStringAsync("https://google.co.in");

        }

        private void Console_OnLog(object sender, string e)
        {
            
        }
    }

    public class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
    }

    public class RootObject
    {
        public List<Employee> employees { get; set; }
    }
}
