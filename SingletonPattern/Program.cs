using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = SingletonDataContainer.GetInstance();
            var s2 = SingletonDataContainer.GetInstance();

            if (s1.Equals(s2))
            {
                Console.WriteLine("Singleton instance is equal");
                var name = s1.GetCustomerName("John Doe");
                Console.WriteLine(name);
            }
            else
            {
                Console.WriteLine("Singleton instance is not equal");
            }
        }
    }
}
