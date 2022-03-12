using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obiektowoLab11
{
    class Square : IFigure
	{
		int a;
		int b;
		
		public void getInput()
        {
			Console.WriteLine("Podaj kolejno bok a, b prostokąta");
			a = Convert.ToInt32(Console.ReadLine());
			b = Convert.ToInt32(Console.ReadLine());
		}

		public double area()
        {
			Console.Write("Pole: ");
			return (2 * a) + (2 * b);
        }

		public double perimeter()
        {
			Console.Write("Obwód: ");
			return a * b;
		}
				
    }
}
