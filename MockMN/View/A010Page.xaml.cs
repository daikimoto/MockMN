using MockMN.ViewModel;

namespace MockMN.View;

public partial class A010Page : ContentPage
{
	public A010Page()
	{
		InitializeComponent();
		BindingContext = new A010ViewModel();
	}
}


