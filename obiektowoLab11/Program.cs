using System;

namespace obiektowoLab11
{
	class Program
	{
		static void Main(string[] args)
		{
			string whatToCalculate;
			IFigure figure = null;
			Console.WriteLine("Wybierz 1 - koło, 2 - trójkąt, 3 - kwadrat");
			whatToCalculate = Console.ReadLine();
			if (whatToCalculate == "1")
			{
				figure = new Circle();
			}
			else if (whatToCalculate == "2")
			{
				figure = new Triangle();
			}
			else if (whatToCalculate == "3")
			{
				figure = new Square();
			}

			figure.getInput();
			Console.WriteLine("Obliczyć 1 - obwód, 2 - pole");
			whatToCalculate = Console.ReadLine();
			if (whatToCalculate == "1")
			{
				figure.perimeter();
			}
			else if (whatToCalculate == "2")
			{
				figure.area();
			}
		}
	}
}
