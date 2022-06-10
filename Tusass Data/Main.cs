using UIKit;
using System.Text.Json.Serialization;
using RestSharp;

namespace Tusass_Data
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, typeof(AppDelegate));



            
        }

        async void GetRequest()
        {
            string url = "https://my.tusass.gl/api/account/page-account-home";

            var request = new RestRequest(url, Method.Get);

            request.AddHeader("x-csrf-token", "dIn4IDy5RdiMwyQ2PMZJ30t6UKKoPGhnYsi506f6");
            request.AddHeader("cookie", "lang=en; remember_web_59ba36addc2b2f9401580f014c7f58ea4e30989d=eyJpdiI6Ik42bEVBUHpwcTIwc25xWnRqW" +
                "WhwelE9PSIsInZhbHVlIjoiSCszbzVoRlBzMjB6RklFRHA3S3dQczJxTHRqa3dPdmVnaE9idXQxOC96bkFtUldQNml6NjhCZzVMN3k2alRrWE1ra2F1SW02WktjSTlMRDNOakg0RGd" +
                "1SVRzWEFTSTU2U29MSjVPa0xuUWg3OWFBbkdUMmQxTTZlZEEvYlJYNUMyYlpseWxtdXpsRytscUljNmdncFcyWXdBTGk4NmcwdnFWMXg4Vm9GbDllTSszU0NsMnpDdVVHZTFIeExON2hSNThaamlqb0ZaeHBKZVlvaTkxRDNCNDBHWTFpZjhkOUtL" +
                "ZHRKOWkxZDBYZz0iLCJtYWMiOiIwODU1NjNkNjhjZmI5YjA1NGZlNGVlNDU2MGQ3OWI2M2NkOGRkODViYzgwMjY0MThhZjU2MmRlNzU1ZTU4NTg4In0%3D; tusassgl_session=eyJpdiI6IlRSdlRTM1Vvc1A4cWV6UEFDZ09Wb0E9PSIsI" +
                "nZhbHVlIjoiOUllM0I2b2JTSFZHY3ZRRGFLYkwxU2VhU1IzTWRFMEJIWDB6L25OSE9VZTRIamhvUjhmTzZiU0x5UW1LK0xyanozeVU2cVZrRy9mVUVSNHJYb1dMSlRZcElvbG9UVG9GU1EzNUVoRWc3ZUQ0VXFoWUZROWIxNW11ZHRVVytH" +
                "RXMiLCJtYWMiOiJiYmZhZmMxY2MwODVmOWViODlhODc5MTQ1NDRmMDkwOGU4MGMyOWY4YmJjZmRkMThkODM0ZmRhYWIxMzg0ZmM5In0%3D");

            RestClient client = new RestClient();
            RestResponse response = await client.GetAsync(request);
            
            
        }
    }
}