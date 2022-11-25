// Дан текст. В тексте нужно все пробелы заменить черточками, 
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".


string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежеле бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012
// s[3] // r

//  старый символ   символ, на который будем менять
//        |           |
string Replace(string text, char oldValye, char newValue)
{
    string result = String.Empty; // заводим новую  пустую строку

    int length = text.Length; //определяем длину строки
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValye) result  = result + $"{newValue}";
        else result  = result+ $"{text[i]}";
    }

    return result; // возвращаем результат
}
string newText = Replace(text, ' ' , '|');

Console.WriteLine(newText);

Console.WriteLine(); // Выводит пустую строку в терминале
newText = Replace(text, 'к' , 'К');
Console.WriteLine(newText);

Console.WriteLine(); // Выводит пустую строку в терминале
newText = Replace(text, 'С' , 'с');
Console.WriteLine(newText);