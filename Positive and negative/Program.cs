Console.WriteLine("Airchiet Mteli Cifri");

int result = int.Parse(Console.ReadLine());


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
