using System.Diagnostics;
namespace _1
{
	public class SystemThreads : SystemProcess
	{
		public SystemThreads(){}

        public void ShowThreads()
        {
            new SystemProcess().ShowAllProcesses();
            int pid = new SystemProcess().EnterProcess();

            try
            { 
                var p = Process.GetProcessById(pid);
                ProcessThreadCollection treads = p.Threads;
                foreach (ProcessThread t in treads)
                {
                    Console.WriteLine($"{t.Id}, Start:{t.StartTime}, Pri: {t.PriorityLevel}");
                }
            }
            catch
            {
                Console.WriteLine("Error, please try again");
            }
            Console.ReadKey();
            Console.Clear();

        }
    }

  

}

