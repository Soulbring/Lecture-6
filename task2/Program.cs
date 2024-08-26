//Создайте строкуб сщдержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.


void Main()
{
    Console.WriteLine("ВВедите текст: ");
    string? text = System.Console.ReadLine()!.ToLower();

    System.Console.Write(text);

}


Main();