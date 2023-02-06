Console.Write ("Введите номер дня недели ");
if (int.TryParse(Console.ReadLine(), out int dayNumber))
{
    switch (dayNumber)
    {
        case 1:
            Console.WriteLine("Это будний день");
            break;
        case 2:
            Console.WriteLine("Это будний день");
            break;
        case 3:
            Console.WriteLine("Это будний день"); 
            break;
        case 4:
            Console.WriteLine("Это будний день"); 
            break;
        case 5:
            Console.WriteLine("Это будний день"); 
            break;
        case 6:
            Console.WriteLine("Это выходной день"); 
            break;
        case 7:
            Console.WriteLine("Это выходной день");
            break;
        default:
            Console.WriteLine("Такого дня недели нет");    
            break;                                
    }   
}
else
{
    Console.WriteLine("Ошибка ввода, пожалуйста, повторите попытку");
}