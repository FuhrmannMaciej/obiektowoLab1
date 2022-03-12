using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obiektowoLab11
{
    class Triangle : IFigure
	{
		int a;
		int b;
		int h;
		
		public void getInput()
        {
			Console.WriteLine("Podaj kolejno bok a, b oraz h trójkąta");
			a = Convert.ToInt32(Console.ReadLine());
			b = Convert.ToInt32(Console.ReadLine());
			h = Convert.ToInt32(Console.ReadLine());
		}

		public double area()
        {
			Console.Write("Pole: ");
			return (a * h) / 2;
        }

		public double perimeter()
        {
			Console.Write("Obwód: ");
			return (a + b * h) / 2;
		}
				
    }
}
