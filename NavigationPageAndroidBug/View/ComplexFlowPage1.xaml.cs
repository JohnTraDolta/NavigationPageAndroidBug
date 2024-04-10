using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationPageAndroidBug.View;

public partial class ComplexFlowPage1 : ContentPage
{
    public ComplexFlowPage1()
    {
        Shell.SetPresentationMode(this, PresentationMode.ModalAnimated);
        InitializeComponent();
    }

    public static ComplexFlowPage1 Init()
    {
        throw new NotImplementedException();
    }

    private async void OnNextStepClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("FlowPage2");
    }
}