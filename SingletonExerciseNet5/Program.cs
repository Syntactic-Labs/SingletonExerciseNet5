using System;

namespace SingletonExerciseNet5
{
    class Program
    {
        public static TableServers host1List = TableServers.GetTableServers();
        public static TableServers host2List = TableServers.GetTableServers();
        static void Main(string[] args)
        {
            TableServers servers = TableServers.GetTableServers();

            for (int i = 0; i < 10; i++)
            {
                Host1GetNextServer();
                Host2GetNextServer();
            }
        }
        public void Host1GetNextServer()
        {
            Console.WriteLine($"The next server is: {host1List.GetNextServer()} ");
        }
        public void Host2GetNextServer()
        {
            Console.WriteLine($"The next server is: {host2List.GetNextServer()} ");
        }
    }
}
