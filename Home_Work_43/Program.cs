/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.Clear();

double b1, k1, b2, k2, pointY1, decisionX, decision, pointY2;

Console.WriteLine("Для нахождения точки пересечения двух прямых будем использовать уравнение y = k1 * x + b1, y = k2 * x + b2. Значения b1, k1, b2 и k2 задаются вами.");
Console.WriteLine("Введите k1: ");
k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите b1: ");
b1 = double.Parse(Console.ReadLine());


Console.WriteLine("Введите k2: ");
k2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите b2: ");
b2 = double.Parse(Console.ReadLine());

// для нахождения первой точки мы вычитаем из первого уравнения второе
// y = k1 * x + b1                     y - y = k1x + b1 - (k2x + b2)
// y = k2 * x + b2                     y = k2 * x + b2 
pointY1 = 0;
decisionX = k1 - k2; // находим разницу между k1x и k2x
decision = b1 - b2; // находим разницу между b1 и b2
pointY1 = (decision / decisionX) * -1; // делим число без Х на число с Х (х (икс оставляем слева) = (decision / decisionX)). * -1 нужен для смены знака.


// для нахождения второй точки нужно подставить значение pointY1 во второе уравнение
// х = pointY1
// y = k2 * (x) + b2
pointY2 = 0;
pointY2 = k2 * pointY1 + b2;


Console.WriteLine($"Точки пересечения двух прямых будет {pointY1:f1} и {pointY2:f1}");