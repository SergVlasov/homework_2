// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Hi, please enter the number from 1 to 7: ");
int number = Int32.Parse(Console.ReadLine());
    if(number>0 && number<=7)
           if(number <=7 && number>5)
        {
            Console.WriteLine("The day is a weekend");
        }
        else
        {
            Console.WriteLine("This day is a worker");
        }
    else
        {
            Console.WriteLine("The number is out of request");
        }