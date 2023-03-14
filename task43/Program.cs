// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Prompt(string message)
{
    Console.WriteLine(message);
    double number = double.Parse(Console.ReadLine());
    return number;
}

//Находим значение точки
(double, double) GetValuePoint(double numB1, double numK1, double numB2, double numK2)
{
    double numX;
    double numY;
    
    numX = (numB2-numB1)/(numK1-numK2);
    numY = numK1*numX+numB1;

    return (numX, numY);
}

double numberB1 = Prompt("Введите значение b1: ");
double numberK1 = Prompt("Введите значение k1: ");
double numberB2 = Prompt("Введите значение b2: ");
double numberK2 = Prompt("Введите значение k2: ");

(double numberX, double numberY)= GetValuePoint(numberB1, numberK1, numberB2, numberK2); 
Console.WriteLine($"Коортинаты точки пересечения({numberX}; {numberY})");
