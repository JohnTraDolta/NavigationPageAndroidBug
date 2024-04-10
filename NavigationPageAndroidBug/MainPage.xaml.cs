namespace NavigationPageAndroidBug;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnComplexFlowInNavigationPageClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("FlowPage1NavigationPage");
    }

    private void OnComplexFlowClicked(object? sender, EventArgs e)
    {
        Shell.Current.GoToAsync("FlowPage1");
    }
}