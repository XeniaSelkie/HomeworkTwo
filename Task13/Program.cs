Console.Write("Введите число ");
if (int.TryParse(Console.ReadLine(), out int EnteredNumber))
{
    if (EnteredNumber > 99)
    {
        string SearchingNumber = EnteredNumber.ToString();
        Console.WriteLine(SearchingNumber[2]);
    }

    else
        Console.WriteLine($"В числе {EnteredNumber} нет третьей цифры");
}        
else
{
    Console.WriteLine($"Ошибка ввода, пожалуйста, повторите попытку");
}
