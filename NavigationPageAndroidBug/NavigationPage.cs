namespace NavigationPageAndroidBug;

public class NavigationPage<T> : NavigationPage where T : Page
{
    public NavigationPage(T page) : base(page)
    {
        Shell.SetPresentationMode(this, PresentationMode.ModalAnimated);
    }
}

