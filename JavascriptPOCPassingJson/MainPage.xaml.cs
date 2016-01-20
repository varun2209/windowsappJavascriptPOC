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
    /// 

    public sealed partial class MainPage : Page
    {
        ChakraHost host = new ChakraHost();
        DateTime startTime = new DateTime();
        UInt16 executionCount;
        //UInt16 totalTimeElapsed = 0;
        //UInt16 currentDifference = 0;
        //string text = null;

        public MainPage()
        {
            this.InitializeComponent();
            host.ProjectNamespace("RuntimeComponent1");
            //host.ProjectObjectToGlobal(RuntimeComponent1.Employee.Create(), "EmployeeObject");  
            //Class type to be returned is to be registered with communication manager
            CommunicationManager.RegisterType(typeof(RuntimeComponent1.Employee));
        }
        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            Console.OnLog += Console_OnLog;
            //makeHttpCalls();
            //EmployeeList RootObj = new EmployeeList();

            CommunicationManager.OnObjectReceived = (data) =>
            {
                RuntimeComponent1.Employee employeeData = (RuntimeComponent1.Employee)data;
                //currentDifference = (UInt16)Convert.ToInt16(DateTime.Now.Subtract(startTime).Milliseconds);
                //System.Diagnostics.Debug.WriteLine("End Time Difference-------------------------------" + currentDifference);
                //if (executionCount > 0)
                //{
                //    totalTimeElapsed = (UInt16)(totalTimeElapsed + currentDifference);
                //    System.Diagnostics.Debug.WriteLine("End Time Difference average-------------------------------" + totalTimeElapsed / executionCount);
                //}
            };
            //await System.Threading.Tasks.Task.Run(() =>
            //{
            //    text = File.ReadAllText("ResponseFiles/JSonResponse.txt");
            //});
            var script = await CoreTools.GetPackagedFileContentAsync("JavaScriptModule", "JsonParser.js");
            var result = host.RunScript(script);
            //startTime = DateTime.Now;
            //System.Diagnostics.Debug.WriteLine("Start Time -------------------------------" + DateTime.Now);
            //host.CallFunction("ParseJson", text);
        }

        private async void makeHttpCalls()
        {
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

            var callResult = await CoreTools.DownloadStringAsync("https://google.co.in");
        }

        private void Console_OnLog(object sender, string e)
        {
            System.Diagnostics.Debug.WriteLine(e + " -------------------- ");
        }

        private void ExecuteScript_Click(object sender, RoutedEventArgs e)
        {
            //EmployeeList rootObj = new EmployeeList();
            //var script = await CoreTools.GetPackagedFileContentAsync("JavaScriptModule", "JsonParser.js");
            //var output = host.RunScript(script);
            startTime = DateTime.Now;
            System.Diagnostics.Debug.WriteLine("Start Time -------------------------------" + DateTime.Now);
            executionCount++;
            int optionSelected = 0;
            optionSelected = Convert.ToInt16(ChoiceInput.Text);
            //Execute case 2,3 with debug application process set as SCRIPT in the project properties
            switch (optionSelected)
            {
                //Execute case 4 with debug application process set as MANAGED in project properties
                case 1:
                    host.CallFunction("ParseJsonAndSendObject", "Dummy");
                    break;
                case 2:
                    host.CallFunction("CallNativeMethodFromJs");
                    break;
                case 3:
                    host.CallFunction("CallNativeStaticMethodFromJs");
                    break;
                case 4:
                    //Execute case 4 with debug application process set as MANAGED in project properties
                    host.CallFunction("ParseJsonAndSendObjectUsingJSGlobalObjectMethod", "Dummy");
                    break;
            }
        }
    }
    //public sealed class EmployeeList
    //{
    //    public List<RuntimeComponent1.Employee> employees { get; set; }
    //}
}
