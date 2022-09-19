namespace MauiPicker;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = this;
	}

	string selection = null;
	public string Selection
	{
		get
		{ 
			return selection;
		} 
		set 
		{ 
			selection = value;
			OnPropertyChanged(nameof(Selection));
		}
	}
}

