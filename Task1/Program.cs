using System; 
class Program { 
		static void Main() 
		{ 
			Console.Write("Введите количество страниц: "); 
			int pagesQuantity = int.Parse(Console.ReadLine() ?? "0");

			Console.Write("Введите цену одной страницы: "); 
			int pricePerPage = int.Parse(Console.ReadLine() ?? "0");

			Console.Write("Стоимость подготовки файла: "); 
			int priceOfFile = int.Parse(Console.ReadLine() ?? "0");

			double baseCost = pagesQuantity * pricePerPage;
			double discount = baseCost * 10 / 100;
			double total = baseCost - discount + priceOfFile;

			Console.WriteLine($"Основная стоимость: {baseCost:F2} руб.");
			Console.WriteLine($"Скидка: {discount:F2} руб.");
			Console.WriteLine($"К оплате: {total:F2} руб.");
		} 
	
	} 