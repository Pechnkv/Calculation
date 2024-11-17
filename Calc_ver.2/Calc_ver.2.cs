while (true)
{
    Console.Clear();

    string str1, str2;
    int num1, num2;
    string action;

    for (; ; )
    {
       
        Console.WriteLine("Введите первое число");
        str1 = Console.ReadLine();
        bool result1 = int.TryParse(str1, out num1);

        if (result1)
        {
                       break;
        }
        else
        {
            Console.WriteLine("Вы ввели буквы, введите заново");
            Console.ReadLine();
            Console.Clear();
        }

    }

    for (; ; )
    {

        Console.WriteLine("Введите второе число");
        str2 = Console.ReadLine();
        bool result2 = int.TryParse(str2, out num2);

        if (result2)
        {
           
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели буквы, введите заново");
            Console.ReadLine();
            Console.Clear();
        }

    }

    Console.WriteLine("Выберите операцию. '+', '-', '*', '/'");
    action = Console.ReadLine();
    if (action == "+")
        Console.WriteLine("Сумма равна = " + (num1 + num2));
    else if (action == "-")
        Console.WriteLine("Разница равна = " + (num1 - num2));
    else if (action == "*")
        Console.WriteLine("Умножение равно = " + (num1 * num2));
    else if (action == "/")
        Console.WriteLine("Деление равно = " + (num1 / num2));

    Console.ReadLine();
}
