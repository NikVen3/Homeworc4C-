//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]


/*int size = 8;
int[] array = new int[size]; // Массив из 8 элементов: 
Random rand = new Random();
for (int i = 0; i < size; i++)
{
    // array[i] = new Random().Next(0, 99)
    array[i] = rand.Next(99);
    // Console.Write(array[i] + " ");
}

Console.WriteLine($"Массив: [ {String.Join("; ",array)} ]");
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
/*
Console.WriteLine("Ведите число");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
        while (a > 0)
{
 
        sum = sum + a % 10;
        a = a /10 ;

}
//Console.WriteLine(sum);
Console.WriteLine($"Сумма чисел: {sum} ");
*/

//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

  Console.Write("Введите число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());
  int Exponentiation(int numberA, int numberB)
{
  int result = 1;
  for(int i=1; i <= numberB; i++){
    result = result * numberA;
  }
    // int result = Math.Pow(numberA, numberB);
   return result;
}

int exponentiation = Exponentiation(numberA, numberB);
Console.WriteLine("число А в степени числа В: " + exponentiation);

