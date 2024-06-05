using MauiTestApp.MVVM.ViewModels;

namespace MauiTestApp.MVVM.Views;

public partial class FormView : ContentPage
{
	public FormView()
	{
		InitializeComponent();
		BindingContext = new FormViewModel();
	}
}