Console.WriteLine("Airchiet Mteli Cifri");

int result = int.Parse(Console.ReadLine());

//Console.WriteLine("Choos Second number");
//double number2 = double.Parse(Console.ReadLine());

//Console.WriteLine("Choos symbol from: (+, -, *, /, %,) ");
//String symbol = Console.ReadLine();


if (result < 0)
{
    Console.WriteLine("Cifri uaryofitia");
}
else if (result > 0)
{
    Console.WriteLine("cifri dadebitia");
}
else if (result == 0)  
{
    Console.WriteLine("Cifri nolis tolia");
}


Console.ReadLine();
