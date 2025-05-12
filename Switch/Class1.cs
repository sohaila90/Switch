namespace Switch;

public class Class1
{
 public void Run()
 {
  Console.WriteLine("Choose which day it is today. 1 = Monday, 2 = Tuesday, 3 = Wednesday, 4 = Thursday 5 = Friday, 6 = Saturday 7 = Sunday");
  var chooseNumber = Console.ReadLine();
  switch (chooseNumber)
  {
   case "1":
    Console.WriteLine($"The day is: Monday");
    break;
   case "2":
    Console.WriteLine($"The day is: Tuesday");
    break;
    case "3":
    Console.WriteLine($"The day is: Wednesday");
    break;
    case "4":
     Console.WriteLine($"The day is: Thursday");
     break;
    case "5":
     Console.WriteLine($"The day is: Friday");
     break;
    case "6":
     Console.WriteLine($"The day is: Saturday");
     break;
    case "7":
     Console.WriteLine($"The day is: Sunday");
     break;
   default:
    Console.WriteLine($" Try again");
    Run();
    break;
  }
 }
}
