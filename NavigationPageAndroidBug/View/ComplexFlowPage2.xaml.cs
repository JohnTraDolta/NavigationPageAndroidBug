using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationPageAndroidBug.View;

public partial class ComplexFlowPage2 : ContentPage
{
    public ComplexFlowPage2()
    {
        InitializeComponent();
    }

    private async void OnCompleteClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///MainPage", true);
    }
}