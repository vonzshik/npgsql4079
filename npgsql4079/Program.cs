using Npgsql;
using System;

namespace npgsql4079
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var conn = new NpgsqlConnection("Host=localhost; Database=postgres; User ID=postgres; Password=Master1234"))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Successfully connected");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                Console.WriteLine("Press any key...");
                Console.ReadKey();
            }
        }
    }
}
