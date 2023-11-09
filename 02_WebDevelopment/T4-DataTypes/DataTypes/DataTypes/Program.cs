internal class Program
{
    private static void Main(string[] args)
    {
        string text = "This is a string";
        int age = 35;
        DateTime now = DateTime.Now;
        double amount = 0;

        string string2 = text + " a second string " + age + now + amount;
        string string3 = string.Format("The age is {0},the time is {1}, and the amount is {2}", age, now, amount);
        string string4 = $"The age is {age},the time is {now}, and the amount is {amount}";
        char sampleChar = 'C';
        char[] arrayChar = string4.ToCharArray();
        // for (int i = 0; i < string4.Length; i++)
        // {
        //    Console.WriteLine(string4[i]);
        // }


        amount = (double)10 / (double)3;
        DateTime dateTime = new DateTime(2000, 1, 1);
        TimeSpan timeStamp1 = now - dateTime;
        Console.WriteLine(timeStamp1.Days);

        string test = "15";

        string booleanValue = "True";

        bool isTrue = bool.Parse(booleanValue);

        age = int.Parse(test);
        Console.ReadKey();
    }
}