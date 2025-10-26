//Assignment  1
Console.Write("Enter the number of week days (1-7) to print it:");
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1:
        Console.WriteLine("Sunday");
        break;
    case 2:
        Console.WriteLine("Monday");
        break;
    case 3:
        Console.WriteLine("Tuesday");
        break;
    case 4:
        Console.WriteLine("Wednesday");
        break;
    case 5:
        Console.WriteLine("Thursday");
        break;
    case 6:
        Console.WriteLine("Friday");
        break;
    case 7:
        Console.WriteLine("Saturday");
        break;

    default:
        Console.WriteLine("Input is invalid");
        return;
}
//Assignement 2
Console.Write("Enter the number of month (1-12) to print the days:");
int month = Convert.ToInt32(Console.ReadLine());
int days;
switch (month)
{
    case 1:
    case 3:
    case 5:
    case 7:
    case 8:
    case 10:
    case 12:
        days = 31;
        break;
    case 4:
    case 6:
    case 9:
    case 11:
        days = 30;
        break;
    case 2:
        days = 28;
        break;

    default:
        Console.WriteLine("Input is invalid");
        return;
}
Console.WriteLine($"The days number of month you entered {days} days");

