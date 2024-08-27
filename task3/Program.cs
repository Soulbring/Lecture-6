//Создайте произвольную строку. Выясните, являеться ли она полиндромом

void Main()
{
    Console.WriteLine("ВВедите текст: ");
    string? text = System.Console.ReadLine()!.ToLower();
    CheckPoly(text);
}


void CheckPoly(string text)

{

    char[] ValidateText = text.ToCharArray();
    int i = 0;
    while (true)
    {

        if (ValidateText[i] == ValidateText[ValidateText.Length - 1 - i])
        {
            if (i <= ValidateText.Length - i)
            {
                i++;
            }
            else
            {
                System.Console.WriteLine("Являеться полиндромом");
                break;
            }
        }
        else
        {
            System.Console.WriteLine("НЕ являеться полиндромом");
            break;
        }


    }
}


Main();