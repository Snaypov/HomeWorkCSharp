using System.Diagnostics;
namespace _1
{
	public class SystemProcess 
	{
		public SystemProcess(){ }

        public void ShowAllProcesses()
        {
            Console.Clear();
            var processes = from p in Process.GetProcesses()
                            orderby p.Id
                            select p;
            foreach (var process in processes)
            {
                Console.WriteLine($"PID: {process.Id}\t Name: {process.ProcessName}");
            }
        }

        public void FindById()
        {
            ShowAllProcesses();
            
            int pid = EnterProcess();
            if (pid == -1) return;
            try
            {
                Console.Clear();
                var p = Process.GetProcessById(pid);
                Console.WriteLine($"PID: {pid} \t Name: {p.ProcessName}");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Error, please try again");
                Console.ReadKey();
                return;
            }
        }

        public void KillProcess()
        {
            ShowAllProcesses();
            int pid = EnterProcess();
            if (pid == -1) return;
            try
            {
                Console.Clear();
                var p = Process.GetProcessById(pid);
                p.Kill();
                Console.WriteLine($"PID: {pid} \t Name: {p.ProcessName} was removed");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Error, please try again");
                Console.ReadKey();
                return;
            }          
        }

        public int EnterProcess()
        {
            Console.WriteLine("Enter a PID: ");
            string? input = Console.ReadLine();
            int m;
            try
            {
                m = int.Parse(input);
            }
            catch
            {
                Console.WriteLine("Invalid num");
                Console.ReadKey();
                return -1;
            }
            return m;

        }
    }
}

