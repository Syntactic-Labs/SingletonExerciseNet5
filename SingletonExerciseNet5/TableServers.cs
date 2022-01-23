using System.Collections.Generic;
namespace SingletonExerciseNet5
{
    public class TableServers
    {
        private static readonly TableServers _instance = new TableServers();
        private readonly List<string> servers = new List<string>();
        private int nextServer = 0;
        private TableServers()
        {
            servers.Add("Tim");
            servers.Add("Todd");
            servers.Add("Sally");
            servers.Add("Kristy");
        }
        public static TableServers GetTableServers()
        {
            return _instance;
        }
        public string GetNextServer()
        {
            string output = servers[nextServer];
            nextServer++;
            if (nextServer >= servers.Count)
            {
                nextServer = 0;
            }
            return output;
        }
    }
}
