//// See https://aka.ms/new-console-template for more information
//using System.Diagnostics.Metrics;
//using static System.Console;
////playing wish console app
//Console.WriteLine("what's your favorite color and astrology sign?");
//string name = Console.ReadLine();
//Console.WriteLine($"Your hacker name is {name}.");

////practice number size and range
////1.
//string[] datatype = { "sbyte", "byte", "short", "ushort", "int", "uint", "long", "ulong", "float", "double", "decimal" };
//int[] size = { sizeof(sbyte), sizeof(byte), sizeof(short), sizeof(ushort), sizeof(int), sizeof(uint), sizeof(long), sizeof(ulong), sizeof(float), sizeof(double), sizeof(decimal) };
//double[] minval = { sbyte.MinValue, byte.MinValue, short.MinValue, ushort.MinValue, int.MinValue, uint.MinValue, long.MinValue, ulong.MinValue, float.MinValue, double.MinValue, (double)decimal.MinValue };
//double[] maxval = { sbyte.MaxValue, byte.MaxValue, short.MaxValue, ushort.MaxValue, int.MaxValue, uint.MaxValue, long.MaxValue, ulong.MaxValue, float.MaxValue, double.MaxValue, (double)decimal.MaxValue };

//Console.WriteLine("{0,-10} {1,5} {2,25} {3,25}\n", "DataType", "size", "Min value", "Max value");
//for (int conunter = 0; conunter < datatype.Length; conunter++)
//    Console.WriteLine("{0,-10} {1,5} {2,25} {3,25}", datatype[conunter], size[conunter], minval[conunter], maxval[conunter]);

////2.
//Console.WriteLine("input the number of centuries?");
//string val = Console.ReadLine();
//uint cty = Convert.ToUInt32(val);
//uint yr = cty * 100;
//uint dy = cty * 36524;
//uint hr = cty ^ 876576;
//uint mins = cty * 52594560;
//long eds = cty * 3155673600;
//long mseds = cty * 3155673600000;
//long micsed = cty * 3155673600000000;
//ulong nans = cty * 15778454400000000000;

//Console.WriteLine($"{cty} centuries = {yr} years = {dy} days = {hr} hours = {mins} minutes = {eds} seconds = {mseds} milliseconds = {micsed} microseconds = {nans} nanoseconds");

////practive loops and operators
////1.
//for (int i = 1; i <= 100; i++)
//{
//    if (i % 3 == 0 && i % 5 == 0)
//    {
//        Console.WriteLine("FizzBuzz");
//    }
//    else if (i % 3 == 0)
//    {
//        Console.WriteLine("Fizz");
//    }
//    else if (i % 5 == 0)
//    {
//        Console.WriteLine("Buzz");
//    }
//    else
//    {
//        Console.WriteLine(i);
//    }
//}

////2. it will be infinity loop.


//int max = 500;

//if (max > byte.MaxValue)
//{
//    WriteLine("Warning: the max value is greater than maximum value of byte, it would be a infinity loop. The byte range is (0,255)");
//}
//else
//{
//    for (byte i = 0; i < max; i++)
//    {
//        WriteLine(i);
//    }
//}

////3.
//int correctNumber = new Random().Next(3) + 1;
//Console.WriteLine("Guess the number between 1 and 3");
//while (true)
//{
//    int guessedNumber = int.Parse(Console.ReadLine());
//    if (guessedNumber > 3 || guessedNumber < 1)
//    {
//        Console.WriteLine("the number is not valid, the correct number is between 1 and 3");
//    }
//    else if (guessedNumber < correctNumber)
//    {
//        Console.WriteLine("the correct number is higher than your guess");
//    }
//    else if (guessedNumber > correctNumber)
//    {
//        Console.WriteLine("the correct number is less than your guess");
//    }
//    else
//    {
//        Console.WriteLine("you are correct!");
//        break;
//    }
//}

////4.
//int rows = 5; // Number of rows in the pyramid

//for (int i = 1; i <= rows; i++)
//{
//    // Print spaces before the stars
//    for (int j = 1; j <= rows - i; j++)
//    {
//        Console.Write(" ");
//    }

//    // Print stars for the current row
//    for (int k = 1; k <= 2 * i - 1; k++)
//    {
//        Console.Write("*");
//    }

//    Console.WriteLine(); // Move to the next line after printing stars
//}

////5.
//DateTime birthDate = new DateTime(2000, 1, 23);
//TimeSpan age = DateTime.Now - birthDate;
//int dayage = (int)age.TotalDays;
//Console.WriteLine($"Your current day age is {dayage}.");

//int daysToNextAnniversary = 10000 - (dayage % 10000);
//DateTime nextAnniversary = DateTime.Today.AddDays(daysToNextAnniversary);
//Console.WriteLine($"The next 10,000-day anniversary is on {nextAnniversary:d}.");

////6.
//DateTime thistime = DateTime.Now;
//int check = thistime.Hour;

//if (check >= 5 && check < 12)
//{
//    Console.WriteLine("Good Morning!");
//}
//if (check >= 12 && check < 17)
//{
//    Console.WriteLine("Good AfterNoon!");
//}
//if (check >= 17 && check < 20)
//{
//    Console.WriteLine("Good Evening!");
//}
//if (check >= 20 || check < 5)
//{
//    Console.WriteLine("Good Night!");
//}

////7.
//for (int i = 1; i <= 4; i++)
//        {
//            for (int j = 0; j <= 24; j += i)
//            {
//                Console.Write(j);

//                if (j < 24 && j + i <= 24)
//                {
//                    Console.Write(",");
//                }
//            }

//            Console.WriteLine();
//        }