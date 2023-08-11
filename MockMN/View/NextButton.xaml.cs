namespace MockMN.View;

public partial class NextButton : ContentView
{
	public static readonly BindableProperty TextProperty =
	BindableProperty.Create(
		nameof(Text),
		typeof(string),
		typeof(NextButton),
		string.Empty
	);
	public string Text
	{
		get => (string)GetValue(TextProperty);
		set => SetValue(TextProperty, value);
	}

	public NextButton()
	{
		InitializeComponent();
	}
}
