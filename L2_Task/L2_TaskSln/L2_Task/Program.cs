namespace L2_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 2;
            int sum = CalculateSum(num1, num2);
            Console.WriteLine("First number: " + num1 + " | Second number: " + num2);
            Console.WriteLine("Sum: " + sum);
            int diff = CalculateDiff(num1, num2);
            Console.WriteLine("Diff: " + diff);
            int division = CalculateDivision(num1, num2);
            Console.WriteLine("Division: " + division);
            int multiplication = CalculateMultiplication(num1, num2);
            Console.WriteLine("Multiplication: " + multiplication);

            //DateTime methodlarini yoxlamaq
            DateTime now = DateTime.Now;
            Console.WriteLine("\nNow: " + now);
            int minute = now.Minute;
            Console.WriteLine("\nMinute: " + minute);
            int microsecond = now.Microsecond;
            Console.WriteLine("\nMicrosecond:" + microsecond);
            int month = now.Month;
            Console.WriteLine("\nMonth: " + month);
            int year = now.Year;
            Console.WriteLine("\nYear: " + year);

            DateTime addDay = now.AddDays(5);
            Console.WriteLine("\nAdd Day: " + addDay);

            DateTime diffDay = now.AddDays(-5);
            Console.WriteLine("\nDiff Day: " + diffDay);

            DateTime dateTime = new DateTime(2020, 01, 01, 00, 00, 00);
            Console.WriteLine("\nOther data time: " + dateTime);

            double diffDays = now.Subtract(dateTime).TotalDays;
            Console.WriteLine("\nDifference between 2 times (days): " + diffDays);

            double diffSecond = now.Subtract(dateTime).TotalSeconds;
            Console.WriteLine("\nDifference between 2 times (seconds): " + diffSecond);

            DateTime todaysDate = DateTime.Today;
            Console.WriteLine("\nToday: " + todaysDate);

            DateTime currentDateTimeUTC = DateTime.UtcNow;
            Console.WriteLine("\ncurrentDateTimeUTC: " + currentDateTimeUTC);

            DateTime maxDateTimeValue = DateTime.MaxValue;
            Console.WriteLine("\nmaxDateTimeValue: " + maxDateTimeValue);

            DateTime minDateTimeValue = DateTime.MinValue;
            Console.WriteLine("\nminDateTimeValue: " + minDateTimeValue);
        }

        static int CalculateSum(int firstNumber, int secondNumber) 
        {   
            int resultSum = 0;

            resultSum =  firstNumber + secondNumber;
            int result = firstNumber - secondNumber;

            return resultSum;
        }

        static int CalculateDiff(int firstNumber, int secondNumber)
        {
            int resultDiff = 0;

            resultDiff = firstNumber - secondNumber;

            return resultDiff;
            
        }

        static int CalculateDivision(int firstNumber, int secondNumber)
        {
            int resultDivision = 0;

            resultDivision = firstNumber/secondNumber;

            return resultDivision;
        }

        static int CalculateMultiplication(int firstNumber, int secondNumber)
        {
            int resultMultiplication = 0;

            resultMultiplication = firstNumber * secondNumber;

            return resultMultiplication;
        }
    }
}
