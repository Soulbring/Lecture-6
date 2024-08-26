//Создайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.



void Main()
{
    char[,] letter = new char[,]
    {
    { 'a', 'b', 'c', 'd', 'r'},
    {'e','u','i','o','a'}
    };

System.Console.Write(FromCharArrayToString(letter));


}


string FromCharArrayToString(char[,] array)

{
    string str = "";
    foreach (char c in array)
        str += c;
        return str;
}

Main();