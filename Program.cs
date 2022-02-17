using System;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
			List<Employees> List = new List<Employees>();

			Console.WriteLine("Enter the number of employees: ");
			int n = int.Parse(Console.ReadLine());

			for (int i = 1; i <= n; i++)
			{
				Console.WriteLine($"Employee #{i} data:");
				Console.WriteLine("Outsourced (y/n)?");
				char ch = char.Parse(Console.ReadLine());

				Console.WriteLine(" Name : ");
				string name = Console.ReadLine();

				Console.WriteLine(" Hours : ");
				int hours = int.Parse(Console.ReadLine());

				Console.WriteLine(" Value per hours : ");
				double valueperhours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				if (ch == 'y')
				{
					Console.WriteLine("Additional charge");
					double addchanger = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
					List.Add(new OutsourseEmployee(name, hours, valueperhours, addchanger));
				}

				else
				{
					List.Add(new Employees(name, hours, valueperhours));
				}


			}

				Console.WriteLine();
				Console.WriteLine("Paymets");
				foreach (Employees emp in List)
			{
				Console.WriteLine(emp.Name + "-$" + emp.PayMent().ToString("F2"), CultureInfo.InvariantCulture);
			}
		}
    }
}
