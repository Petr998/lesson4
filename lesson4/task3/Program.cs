﻿//Задача 3. Считать с консоли, состоящую из цифр и латинских букв. Сформировать новую строку, состоящую из букв исходной строки.

string GetLettersFromStr(string s)
{
    string letters = "";
    foreach (char e in s)
    {
       if(char.IsAsciiLetter(e) == true)
       {
        letters = letters + e;
       }
    }
    return letters;
}

string str = Console.ReadLine();
string result = GetLettersFromStr(str);
Console.WriteLine(result);