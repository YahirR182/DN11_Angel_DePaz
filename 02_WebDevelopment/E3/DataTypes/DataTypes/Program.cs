using DataTypes;
internal class Program
{
    private static void Main(string[] args)
    {
        //string text = "This is a string";
        //int age = 35;
        //DateTime now = DateTime.Now;
        //double amount = 0;

       // string string2 = text + " a second string " + age + now + amount;
        //string string3 = string.Format("The age is {0},the time is {1}, and the amount is {2}", age, now, amount);
        //string string4 = $"The age is {age},the time is {now}, and the amount is {amount}";
       // char sampleChar = 'C';
        //char[] arrayChar = string4.ToCharArray();
        // for (int i = 0; i < string4.Length; i++)
        // {
        //    Console.WriteLine(string4[i]);
        // }


        //amount = (double)10 / (double)3;
       // DateTime dateTime = new DateTime(2000, 1, 1);
       //TimeSpan timeStamp1 = now - dateTime;
        //Console.WriteLine(timeStamp1.Days);

        //string test = "15";

        //string booleanValue = "True";

        //bool isTrue = bool.Parse(booleanValue);

        //age = int.Parse(test);



        /////////////Implementación ejercicio E3
        
        List<Customer> listaCustomers = new List<Customer>();
        
        listaCustomers.Add(new Customer(1, "Angel Yahir", "De Paz Reyes", new DateTime(2023, 1, 16, 8, 0, 0)));
        listaCustomers.Add(new Customer(2, "Nili", "Crisostomo Domínguez", new DateTime(2021, 5, 10, 18, 0, 0)));
        listaCustomers.Add(new Customer(3, "Anel Michelle", "Zetina Ayala", new DateTime(2022, 4, 11, 14, 0, 0)));
        listaCustomers.Add(new Customer(4, "Jonathan", "Hernández Salinas", new DateTime(2021, 3, 12, 17, 0, 0)));
        listaCustomers.Add(new Customer(5, "Jorge Armando", "Esquivel", new DateTime(2023, 3, 23, 7, 0, 0)));
        listaCustomers.Add(new Customer(6, "Diana Isabel", "Acosta Durán", new DateTime(2023, 9, 9, 15, 0, 0)));
        listaCustomers.Add(new Customer(7, "Michelle ", "Navarrete Esquivel ", new DateTime(2021, 6, 19, 13, 0, 0)));
        listaCustomers.Add(new Customer(8, "Camila Alejandra", "García Camargo", new DateTime(2023, 3, 15, 20, 0, 0)));
        listaCustomers.Add(new Customer(9, "Metzli", "Ramírez Ávila", new DateTime(2022, 7, 15, 7, 0, 0)));
        listaCustomers.Add(new Customer(10, "Azul Itzayana ", "Herrera Urbina", new DateTime(2023, 9, 20, 10, 0, 0)));

        int n = listaCustomers.Count;
        int i = 0;

        Console.WriteLine("Loop with foreach");
        foreach(Customer customer in listaCustomers)
        {
            Console.WriteLine("NAME: " + customer.CustomerName +"  DATE: " + customer.CustomerDate);
            
        }
        Console.WriteLine(" ");
        Console.WriteLine("Loop with for");
        for ( int j = 0; j < listaCustomers.Count; j++)
        {
            Customer customer = listaCustomers[j];
            Console.WriteLine("NAME: " + customer.CustomerName + "  DATE: " + customer.CustomerDate);
        }
        Console.WriteLine(" ");
        Console.WriteLine("Loop with while");
        
        while (i < n)
        {
            Customer customer = listaCustomers[i];
            Console.WriteLine("NAME: " + customer.CustomerName + "  DATE: " + customer.CustomerDate);
            i++;
        }
        Console.WriteLine(" ");
        Console.WriteLine("Loop with do while");
        i = 0;
        do
        {

            Customer customer = listaCustomers[i];
            Console.WriteLine("NAME: " + customer.CustomerName + "  DATE: " + customer.CustomerDate);
            i++;
        } while (i<n);
        Console.ReadKey();


    }
}