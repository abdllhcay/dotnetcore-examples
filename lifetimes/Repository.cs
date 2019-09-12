public class Repository
{
	private readonly RandomNumberGenerator _generator;

	public Repository(RandomNumberGenerator generator)
	{
		_generator = generator;
	}

	public int RandomNumber => _generator.RandomNumber;
}