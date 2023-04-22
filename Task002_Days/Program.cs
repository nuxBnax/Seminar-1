// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.WriteLine("Enter week day");
int number = Convert.ToInt32(Console.ReadLine());

if(number == 1)
{
    Console.WriteLine("It's Sunday");
}
else if(number == 2)
{
    Console.WriteLine("It's Monday");
}
else if(number == 3)
{
    Console.WriteLine("It's Thuesday");
}
else if(number == 4)
{
    Console.WriteLine("It's Whensday");
}
else if(number == 5)
{
    Console.WriteLine("It's Friday");
}
else if(number == 6)
{
    Console.WriteLine("It's Saturday");
}
else if(number == 7)
{
    Console.WriteLine("It's Saturday");
}