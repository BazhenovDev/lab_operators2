using System; 
class Program { 
		static void Main() 
		{ 
				Console.WriteLine("1 - Чёрно-белая печать: 5руб"); 
				Console.WriteLine("2 - Цветная печать: 20руб"); 
				Console.WriteLine("3 - Фотопечать: 60руб"); 

				Console.WriteLine("Ввести код печати: "); 
			  int code = int.Parse(Console.ReadLine() ?? "0");

				Console.WriteLine("Введите количество страниц: "); 
			  int n = int.Parse(Console.ReadLine() ?? "0");

				int price;

				switch(code)
		{
			case 1:
			price  = 5;
			break;
					case 2:
			price  = 20;
			break;
					case 3:
			price  = 60;
			break;
			default:
			Console.Write("Неизвестный код"); 
			return;
		}

		double totalPrice  = price * n;
		Console.WriteLine($"Цена единицы печати: {price:F2} руб"); 
		Console.Write($"Итого к оплате: {totalPrice:F2} руб"); 
		} 
	
	} 