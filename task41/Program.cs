// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

//Выводими сообщения для пользователя для ввода необходимых данных
int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

//Проверяем сколько чисел больше 0 и выводим на экран
void GetNumberPositive(int numM)
{
    string listNumber = " ";
    int count = 0;
    for (int i = 0; i <= numM; i++)
    {
        int numberUser = Prompt("Введите число: ");
        listNumber = listNumber + numberUser +", ";  

        if (numberUser > 0)
        {
           count ++;
        }

    }
    Console.WriteLine($"{listNumber} чисел больше 0 = {count}");
}


int NumberM = Prompt("Введите количество чисел M: ");

GetNumberPositive(NumberM);

