//Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку,
// в которой слова расположены в обратном порядке. В полученной строке слова
// должны быть также разделены пробелами.

void Main()
{

Console.WriteLine("ВВедите текст через пробелы: ");
string? letter = Console.ReadLine()!;
string[] LetterArray = letter.Split();
Array.Reverse(LetterArray);
letter = string.Join(" ", LetterArray);
Console.Write(letter);

}



Main();