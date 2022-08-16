// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
// в общем, приравниваем правые части данных равенств:
//k1*x+b1=k2*x+b2
//выразим отсюда x:
//x=(b2-b1)/(k1-k2)
//затем подставим полученное значение х в выражение для у (для любого, например первого) :
//y=k1(b2-b1)/(k1-k2)+b1
//ответ: x=(b2-b1)/(k1-k2) , y=k1(b2-b1)/(k1-k2)+b1

// void point(int num1, int num2, int num3, int num4)


Console.WriteLine("Введите точки прямой [k1 ; k2]: ");
int k1 = int.Parse(Console.ReadLine() ?? "0");
int k2 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите точки прямой [b1 ; b2]: ");
int b1 = int.Parse(Console.ReadLine() ?? "0");
int b2 = int.Parse(Console.ReadLine() ?? "0");

int x = (b2 - b1) / (k1 - k2);
int y = k1 * x + b1;
Console.WriteLine($"Точка пересечения заданных прямых [{x} ; {y}]");


//Console.WriteLine($"{k1} {k2} {b1} {b2}");
