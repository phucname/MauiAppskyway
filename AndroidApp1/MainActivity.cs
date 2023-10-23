
using Skyway_android;
using Com.Ntt.Skyway.Room.P2p;
using Kotlin.Jvm.Functions;
using Kotlin.Coroutines;
using Com.Ntt.Skyway.Core;
using Com.Ntt.Skyway.Core.Util;
using AndroidX.Core.Content;
using Android.Content.PM;
using AndroidX.Core.App;
using static Kotlin.Jvm.Internal.Intrinsics;
using Android.Content;
using static AndroidApp1.MainActivity;

namespace AndroidApp1
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
          SkyWayContext.Options options = new SkyWayContext.Options("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJqdGkiOiI5MmU5YWM4ZC1mY2Q3LTQyYzYtYTFhZi01YmM1YzA4ZmVhMTMiLCJpYXQiOjE2OTgwMjQ3MTEsImV4cCI6MTY5ODExMTExMSwic2NvcGUiOnsiYXBwIjp7ImlkIjoiYTI2MTU2ODUtMjBjNi00YmZiLWE3NTgtOGNjMTk5NjhiNzZhIiwidHVybiI6dHJ1ZSwiYWN0aW9ucyI6WyJyZWFkIl0sImNoYW5uZWxzIjpbeyJpZCI6IioiLCJuYW1lIjoiKiIsImFjdGlvbnMiOlsid3JpdGUiXSwibWVtYmVycyI6W3siaWQiOiIqIiwibmFtZSI6IioiLCJhY3Rpb25zIjpbIndyaXRlIl0sInB1YmxpY2F0aW9uIjp7ImFjdGlvbnMiOlsid3JpdGUiXX0sInN1YnNjcmlwdGlvbiI6eyJhY3Rpb25zIjpbIndyaXRlIl19fV0sInNmdUJvdHMiOlt7ImFjdGlvbnMiOlsid3JpdGUiXSwiZm9yd2FyZGl" +
               "uZ3MiOlt7ImFjdGlvbnMiOlsid3JpdGUiXX1dfV19XX19fQ.3Wao_Pe7VTKsmHIH1UND3Kju1CnY-ufPvs91b3jy0v8", Logger.LogLevel.Info, false, true, null, null, null, null, null, null);
        Continuation continuation = new Continuation();
        P2PRoomManager p2PRoomManager = new P2PRoomManager();
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);         
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            //  check a = new check();
            // Task<Boolean> task = new Task<Boolean>(runcheck);
            //  task.Start();
            //CoroutineScope coroutine  =CoroutineScopeKt.CoroutineScope(a.Context);        
            Task.Run(() => {              
               var check1 = SkyWayContext.Setup(Application.Context, options, null, continuation);  
                   //if (check1.GetType()==typeof(SkyWayContext))
                   //{                  
                        p2PRoomManager.isSkywayContextSetup = true;      
                        Console.WriteLine("Err:");
             //}
             //   else
             //  {
             //       Console.WriteLine("Type_connect:"+check1.GetType());
             //  }

            });



            Button CreatRoom = (Button)FindViewById(Resource.Id.btnJoinP2PRoom);
            CreatRoom.Click += (s, e) =>
            {
                Object room = P2PRoom.FindOrCreate("ccj", null, continuation);
                Intent intent = new Intent(this, typeof(Activity1));
              //  StartActivity(intent);
            };



            if (  ContextCompat.CheckSelfPermission(this,Android.Manifest.Permission.Camera)== Permission.Granted)
            {
                var requiredPermissions = new string[] { Android.Manifest.Permission.AccessFineLocation };



            }
            else
            {
                ActivityCompat.RequestPermissions(this, new String[] { Android.Manifest.Permission.Camera },1);
            }




        }

       
       
       
        public class Continuation : Java.Lang.Object, IContinuation
        {
            public ICoroutineContext Context => EmptyCoroutineContext.Instance;

            public void ResumeWith(Java.Lang.Object result)
            {
                Console.WriteLine("check:" + result);
            }
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [Android.Runtime.GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {      
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);


        }
        
    }
}