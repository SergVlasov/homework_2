// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Hi! Please enter the three-digit number: ");
int number = Int32.Parse(Console.ReadLine());
int a = number / 100; 
int b = (number / 10) % 10;
int c = number % 10;
if(number > 99 && number < 1000)
{
    Console.WriteLine(b);
}
else
{
    Console.WriteLine("Number doesn't match");
}