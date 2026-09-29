using MauiOpenGym.ViewModels;

namespace MauiOpenGym.Views.Pages;

public class BasePages : ContentPage
{
	public BasePages()
	{
		
	}



    protected override void OnAppearing()
    {
        base.OnAppearing();

        (BindingContext as BaseViewModels)?.OnAppearing();
    }


    protected override void OnDisappearing()
    {
        (BindingContext as BaseViewModels)?.OnDisappearing();

        base.OnDisappearing();
    }

}