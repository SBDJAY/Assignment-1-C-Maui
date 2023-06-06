namespace IAD_Week4A_DanielPius_GuessingGame;

public partial class MainPage : ContentPage
{
	private Game game;
    public MainPage()
	{
        InitializeComponent();
		game = new Game();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{

		//try
		//{
		int userGuess = int.Parse(GuessEntry.Text);
		GuessStatus result = game.CheckGuess(userGuess);
		game.GuessCount++;
		GuessCountLabel.Text = $"Count: {game.GuessCount}";

		//if (result == GuessStatus.Correct)
		//{
		//	HintLabel.BackgroundColor = Colors.Green;
		//	HintLabel.Text = "You Got it!!!";
		//}
		//else if (result == GuessStatus.TooHigh)
		//{
		//	HintLabel.BackgroundColor = Colors.Red;
		//	HintLabel.Text = "TOOO HIGH";

		//}
		//else
		//{
		//	HintLabel.BackgroundColor = Colors.Red;
		//	HintLabel.Text = "TOOO LOW";
		//}
		//}
		//catch (Exception ex)
		//{
		//	HintLabel.Text = "Invalid Entry";
		//}
		//  }

		switch (result)
		{
			//YOu can group certain cases if they all hold the same value 
			case GuessStatus.TooHigh:
				HintLabel.BackgroundColor = Colors.Red;
				HintLabel.Text = "TOOO HIGH";
				break;
			case GuessStatus.Correct:
				HintLabel.BackgroundColor = Colors.Green;
				HintLabel.Text = "You Got it!!!";
				break;
			case GuessStatus.TooLow:
				HintLabel.BackgroundColor = Colors.Red;
				HintLabel.Text = "TOOO LOW";
				break;

		}
	}
		 

    void GuessEntry_TextChanged(System.Object sender, Microsoft.Maui.Controls.TextChangedEventArgs e)
    {
		HintLabel.Text = "";
    }

    void ShowAnswerButton_Clicked(System.Object sender, System.EventArgs e)
    {
    }

}


