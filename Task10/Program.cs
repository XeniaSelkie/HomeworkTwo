Console.Write("Введите трёхзначное число ");
int SavedNumber;
if (int.TryParse(Console.ReadLine(), out int EnteredNumber))
{
    if (EnteredNumber > 99 && EnteredNumber < 1000)
    {
        SavedNumber = EnteredNumber;
        EnteredNumber = EnteredNumber%100;
        EnteredNumber = EnteredNumber/10;
        Console.WriteLine($"{EnteredNumber} вторая цифра в числе {SavedNumber}");
    }
    else
    {
    Console.WriteLine($"{EnteredNumber} - не трёхзначное число, пожалуйста, введите корректное число");
    }
}
else
{
   Console.WriteLine($"Ошибка ввода, пожалуйста, повторите попытку");
}
