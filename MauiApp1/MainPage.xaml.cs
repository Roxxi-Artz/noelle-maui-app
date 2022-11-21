namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);

		if (count >= 5)
			NoelleText.Text = "Wowza! You must like Noelle!";
		if (count >= 10)
			NoelleText.Text = "Okay that's a good amount you can slow it down now";
		if (count >= 20)
			NoelleText.Text = "ok cmon are you trying to show me up";
		if (count >= 30)
			NoelleText.Text = ":(";
		if (count >= 50)
			NoelleText.Text = "I'd kill you if I could but I am nothing but a simple program";
	}
}

