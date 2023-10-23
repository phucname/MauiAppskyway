using Android.Content;

namespace MauiAppskyway;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		Task.Run(async () =>
		{
			PermissionStatus status =await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();
		});
        
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{    
        var intent = new Intent(Android.App.Application.Context, typeof(MainActivity));
		Platform.CurrentActivity.StartActivityForResult(intent,1);
       // Android.App.Application.Context.StartActivity(intent);
    }
}

