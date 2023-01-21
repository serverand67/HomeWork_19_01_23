/*Задача 41: Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
int getCountPositivNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
       {
        if (array[i] > 0)
          {
            count = count + 1;
          }
       }
    return count;
}
void printArr(int[] array)
{
    Console.Write("");
    for (int i = 0; i < array.Length; i++)
        {
          Console.Write(array[i]);
          if (i < array.Length - 1)
            {
                Console.Write(",");
            }
        }
    Console.WriteLine("");
}

Console.WriteLine("Введите элементы массива через пробел: ");
int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
printArr(array);
int count = getCountPositivNum(array);
Console.WriteLine($"Количество чисел больше 0 = {count}");
    
