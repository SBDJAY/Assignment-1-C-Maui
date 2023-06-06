using System;
namespace IAD_Week4A_DanielPius_GuessingGame
{

	public enum GuessStatus
	{
		TooLow,
		TooHigh,
		Correct,
		OutOfRange
	}

	public class Game
	{
		private int _randomNumber;
		public int GuessCount;


		public Game()
		{
			// This generates a random number
			Random random = new Random();
			_randomNumber = random.Next(0, 101);
			GuessCount = 0;
		}


		public  GuessStatus CheckGuess(int guess)
		{

			if (guess < _randomNumber)
				return GuessStatus.TooLow;
			else if (guess > _randomNumber)
				return GuessStatus.TooHigh;
			else
				return GuessStatus.Correct;

			//Using Case in this scenario would not work it is better to use If else
			//switch (guess)
   //         {
   //             case 1:
   //                 guess < _randomNumber;
   //                     return GuessStatus.TooLow;
   //             case 2:
			//		guess > _randomNumber;
   //                 return GuessStatus.TooHigh;
   //             case 3:
			//		guess = _randomNumber;
			//		return GuessStatus.Correct;
   //         }
   //         return guess;
        }

	}
}

