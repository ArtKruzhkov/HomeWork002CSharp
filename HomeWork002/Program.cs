// Task 1
// Console.WriteLine("Enter 3 digits number");
// int number = int.Parse(Console.ReadLine()!);
// int num1 = number / 10;
// int num2 = num1 % 10;
// Console.WriteLine($"2nd digit for {number} = {num2}");

// Task 2
// Console.WriteLine("Enter any digits number");
// int number = int.Parse(Console.ReadLine()!);
// if(number < 100)
// {
//     Console.WriteLine("There is no 3rd number");
// }
// else if((number > 100)&&(number < 1000))
// {
//     int num1 = number % 10;
//     Console.WriteLine($"3rd digit for {number} = {num1}");
// }
// else if((number > 1000)&&(number < 10000))
// {
//     int num2 = number / 10;
//     int num3 = num2 % 10;
//     Console.WriteLine($"3rd digit for {number} = {num3}");
// }
// else // Работает с числами более 10000 но менее чем 100000
// {
//     int num4 = number / 100;
//     int num5 = num4 % 10;
//     Console.WriteLine($"3rd digit for {number} = {num5}");
// }

// Task3
// Console.WriteLine("Enter number for day of week");
// int number = int.Parse(Console.ReadLine()!);

// if(number <= 5)
// {
//     Console.WriteLine("It is a weekday"); // будний 
// }
// if((number == 6)||(number == 7))
// {
//     Console.WriteLine("It is a weekend"); // выходной
// }