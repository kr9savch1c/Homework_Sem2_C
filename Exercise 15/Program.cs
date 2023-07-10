int Prompt(string msg)
{
    Console.Write($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите число дня недели от 1 до 7: ");
string ss = "Это не день недели";
string check(int number)
{
    if (number > 5 && number < 8) ss = "Это выходной день";
    if (number >= 1 && number < 6) ss = "Это будний день";
    return ss;
}
Console.WriteLine(check(number));