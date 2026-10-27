using System; 
class Program { 
		static void Main() 
		{ 
				Console.Write("Введите количество страниц в заказе: "); 
			  int pagesCount = int.Parse(Console.ReadLine() ?? "0");

				if (pagesCount < 0 || pagesCount > 1000)
		{
			Console.WriteLine("Ошибка диапазона");
			return;
		}
		else if (pagesCount <= 99) 
		{
			Console.WriteLine("Малый заказ");
		}
		else if (pagesCount <= 499) 
		{
			Console.WriteLine("Средний заказ");
		}
		else
		{
			Console.WriteLine("Крупный заказ");
		}
		} 
	
	} 