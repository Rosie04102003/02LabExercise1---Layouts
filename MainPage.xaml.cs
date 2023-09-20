namespace MauiApp2;

public partial class MainPage : ContentPage
{
	String x = "Reality";
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnImageButton1Clicked(object sender, EventArgs e)
	{
		Expectation1.Source = "re1.jpg";
		lbl1.Text = x;
	}

	private void OnImageButton2Clicked(object sender, EventArgs e)
	{
		Expectation2.Source = "re2.jpg";
		lbl2.Text = x;
	}


}
