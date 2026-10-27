using System; 
class Program { 
		static void Main() 
		{ 
				Console.Write("Введите сумму заказа: "); 
			  int sum = int.Parse(Console.ReadLine() ?? "0");

				Console.Write("Введите есть ли карта ученика? 1 - да / 0 - нет: "); 
			  int statusCard = int.Parse(Console.ReadLine() ?? "0");

				double total;

				if (sum >= 500 || statusCard == 1)
		{
			total = sum - sum * 5 / 100;
			Console.WriteLine("Скидка предоставлена"); 
		}
		else
		{
			total = sum;
			Console.WriteLine("Скидка не предоставлена"); 
		}

		Console.WriteLine($"К оплате: {total:F2} руб"); 
		} 
	
	} 