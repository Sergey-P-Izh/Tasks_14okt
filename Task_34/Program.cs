// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

class Program 
{
    static void Main(string [] args)
{
    uint oddNumbersCount = 0; //нечетные числа
    uint evenNumbersCount = 0; //четные числа

    Console.WriteLine("Введите первое число диапазона");

    int currentValue = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите последнее число диапазона");
    int limit = int.Parse(Console.ReadLine());

    while (currentValue <= limit)
    {
       if(currentValue %2 == 0)
       {
         evenNumbersCount ++;
       }
       else
       {
        oddNumbersCount ++;
       }
        currentValue ++;

    }



   Console.WriteLine("Количество нечетных чисел: " + oddNumbersCount);
   Console.WriteLine("Количество нечетных чисел: " + evenNumbersCount);
   Console.ReadLine();


}


}




