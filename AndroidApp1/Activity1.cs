namespace Skyway_android;

[Activity(Label = "Activity1")]
public class Activity1 : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        SetContentView(Resource.Layout.Layout1);
        // Create your application here
    }
}