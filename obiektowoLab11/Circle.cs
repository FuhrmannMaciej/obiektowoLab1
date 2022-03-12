using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obiektowoLab11
{
    class Circle : IFigure
	{
		int r;
		
		public void getInput()
        {
			Console.WriteLine("Podaj promień koła");
			r = Convert.ToInt32(Console.ReadLine());
		}

		public double area()
        {
			Console.Write("Pole: ");
			return 3.14 * r * r;
        }

		public double perimeter()
        {
			Console.Write("Obwód: ");
			return 2 * 3.14 * r;
		}
				
    }
}
