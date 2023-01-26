/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

Console.Clear();


int input, size, more; string inputStr, sizeStr;

while (true)
{
    Console.WriteLine("Введите размер массива: ");
    sizeStr = Console.ReadLine();
    if (!int.TryParse(sizeStr, out size))
    {
        Console.WriteLine("Вы ввели не число!");
    }
    else break;
}
size = int.Parse(sizeStr);
int[] array = Array(size);


int[] Array(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size;)
    {
        while (true)
        {
            Console.WriteLine("Введите число:");
            inputStr = Console.ReadLine();
            if (!int.TryParse(inputStr, out input))
            {
                Console.WriteLine("Вы ввели не число!");
            }
            else
            {
                input = int.Parse(inputStr);
                arr[i] = input;
                i++;
                break;
            }
        }
    }
    return arr;
}

more = 0;
for (int i = 0; i < size; i++)
{
    if (array[i] > 0) more++;
}

Console.WriteLine($"В заполненом массиве пользавателем [{String.Join(", ", array)}] чисел больше нуля равно = {more}");