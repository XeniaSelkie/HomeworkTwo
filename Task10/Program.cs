Console.Write("Введите трёхзначное число ");
int SavedNumber;
if (int.TryParse(Console.ReadLine(), out int EnteredNumber))
{
    if (EnteredNumber > 99 && EnteredNumber < 1000)
    {
        SavedNumber = EnteredNumber;
        SavedNumber = SavedNumber%100;
        SavedNumber = SavedNumber/10;
        Console.WriteLine($"{SavedNumber} вторая цифра в числе {EnteredNumber}");
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
