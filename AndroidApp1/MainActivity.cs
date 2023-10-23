//using IO.Skyway.Peer;
using Java.Lang;
using Com.Ntt.Skyway.Room;
using static Android.AccessibilityServices.TouchInteractionController;
using Com.Ntt.Skyway.Room.P2p;
using Com.Ntt.Skyway.Core;
using static Com.Ntt.Skyway.Core.Util.Logger;
using Com.Ntt.Skyway.Core.Util;
using Boolean = System.Boolean;
using Skyway_android;

namespace AndroidApp1
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
       
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
             
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            Task.Run(() =>
            { SkyWayContext.Options options= new SkyWayContext.Options("eyJhbGciOiJIUzI1NiIsInR5" +
                "cCI6IkpXVCJ9.eyJqdGkiOiI4ZWE3MzhiMy0zZTg1LTRkYmUtOTNjMS0zNWFmM2ZlZjdhMjQiLCJpY" +
                "XQiOjE2OTc1Mzg0NTgsImV4cCI6MTY5NzYyNDg1OCwic2NvcGUiOnsiYXBwIjp7ImlkIjoiYTI2MTU" +
                "2ODUtMjBjNi00YmZiLWE3NTgtOGNjMTk5NjhiNzZhIiwidHVybiI6dHJ1ZSwiYWN0aW9ucyI6WyJy" +
                "ZWFkIl0sImNoYW5uZWxzIjpbeyJpZCI6IioiLCJuYW1lIjoiKiIsImFjdGlvbnMiOlsid3JpdGUiXS" +
                "wibWVtYmVycyI6W3siaWQiOiIqIiwibmFtZSI6IioiLCJhY3Rpb25zIjpbIndyaXRlIl0sInB1YmxpY2F0" +
                "aW9uIjp7ImFjdGlvbnMiOlsid3JpdGUiXX0sInN1YnNjcmlwdGlvbiI6eyJhY3Rpb25zIjpbIndyaXRlIl" +
                "19fV0sInNmdUJvdHMiOlt7ImFjdGlvbnMiOlsid3JpdGUiXSwiZm9yd2FyZGluZ3MiOlt7ImFjdGlvbnM" +
                "iOlsid3JpdGUiXX1dfV19XX19fQ.VO5Xqgc4D9ef4Kb3vcLD3BjDaeiz_KiPjXAwDG6AvBg", Logger.LogLevel.Verbose, false, true, null, null, null, null, null, null);
                Console.WriteLine(options.GetType().Name);
               
            });
            
           
            /* PeerOption option = new PeerOption();
             option.Key = "ajss";
             option.Domain = "ssss";
             Peer peer = new Peer(Android.App.Application.Context,option);*/

            /* peer.On(Peer.PeerEventEnum.Open, new IOnCallback()
             {

             });*/

//
            
         
           
          
            
        }
    }
}