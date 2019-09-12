using System;

public class RandomNumberGenerator
{
	private readonly Random randomNumber = new Random();
	public int RandomNumber { get; }

	public RandomNumberGenerator()
	{
		RandomNumber = randomNumber.Next(1, 1000);
	}
}