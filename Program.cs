using polymorphism;

public static class programm
{

	public static void Main(string[] args)
	{

		doctor d = new doctor();
		d.operation("heartsurgery");

		arthematic a = new arthematic();
		a.add(10, 20);
		a.add(20.5f, 30.2f);
		a.add(20.1f, 5);
		a.add(2, 3, 5);

	}
}