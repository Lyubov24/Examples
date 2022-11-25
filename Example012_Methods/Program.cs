// Метод 1. Невозвращающий и непринимающий

// void Method1()
// {
//  Console.WriteLine("Автор...");
// }
// Method1();

//Метод 2. Невозвращающий, но принимающий аргументы

// void Method2(string msg)
// {
//    Console.WriteLine(msg);
// }
// Method2(msg: "Текст сообщения");



// void Method21(string msg, int count)
// {
//    int i = 0;
//    while (i < count)
//    {
//        Console.WriteLine(msg);
//        i++;
//    }
// }
// Method21("Текст", count: 4); // 4 это количество раз вывода текста


// Метод 3. Ничего не принимает, но возвращает.

// int Method3()
// {
//    return DateTime.Now.Year; //какой год сегодня
// }

// int year = Method3();
// Console.WriteLine(year);


// Метод 4. Принимает и возвращает аргумент.

// string Method4(int count, string text)
// {
//     int i = 0;                             // цикл while
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);




// string Method4(int count, string text)
// {
//     string result = String.Empty;              // цикл for
//     for( int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method4(10, "z");
// Console.WriteLine(res);



                 
    for (int i = 2; i <= 10; i++)
    {
        for (int j = 2; j <= 10; j++) ;              // не работает таблица умножения
    }
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();



