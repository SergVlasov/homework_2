// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Hi, please enter the three-digit number: ");
int number = Int32.Parse(Console.ReadLine());
if(number >= 100 )
    {while(number >= 1000)
        {
            number = number / 10;
        }
        number = number % 10; Console.WriteLine($"The third number is {number}");
    }
else Console.WriteLine("There is no third");