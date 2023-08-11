using MockMN.ViewModel;

namespace MockMN.View;

public partial class MainPage : ContentPage
{ 
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new A010ViewModel();		
	}
}