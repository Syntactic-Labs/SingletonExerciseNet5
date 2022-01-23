using System;

namespace SingletonExerciseNet5
{
    class Program
    {
        public static TableServers host1 = TableServers.GetTableServers();
        public static TableServers host2 = TableServers.GetTableServers();
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Host1ForNextServer();
                Host2ForNextServer();
            }
        }
        public static void Host1ForNextServer()
        {
            Console.WriteLine($"The next server is: {host1.GetNextServer()} ");
        }
        public static void Host2ForNextServer()
        {
            Console.WriteLine($"The next server is: {host2.GetNextServer()} ");
        }
    }
}
