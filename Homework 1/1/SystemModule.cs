using System.Diagnostics;
namespace _1
{
	public class SystemModule : SystemProcess
	{
		public SystemModule()
		{
		}

        public void ShowAllModules()
        {
            new SystemProcess().ShowAllProcesses();
            int pid = new SystemProcess().EnterProcess();
            try
            {
                var p = Process.GetProcessById(pid);
                ProcessModule myProcessModule;
                ProcessModuleCollection myProcessModuleCollection = p.Modules;

                for (int i = 0; i < myProcessModuleCollection.Count; i++)
                {
                    myProcessModule = myProcessModuleCollection[i];
                    Console.WriteLine("The moduleName is "
                        + myProcessModule.ModuleName);
                    Console.WriteLine("The " + myProcessModule.ModuleName + "'s base address is: "
                        + myProcessModule.BaseAddress);
                    Console.WriteLine("The " + myProcessModule.ModuleName + "'s Entry point address is: "
                        + myProcessModule.EntryPointAddress);
                    Console.WriteLine("The " + myProcessModule.ModuleName + "'s File name is: "
                        + myProcessModule.FileName);
                }
            }
            catch
            {
                Console.WriteLine("Error, please try again");
            }
            Console.ReadKey();
        }
    }
}

