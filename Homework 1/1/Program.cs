

using _1;

int m = 0;
int n = -1;
string? menu = "";
bool cycle = false;

while (cycle != true)
{
    Console.Clear();

    menu = Show(0);
    m = CheckCorrectNum(menu, 1, 3);

    if(m == 4)
    {
        cycle = true;
    }

    switch (m)
    {
        case -1: continue;

        case 1:
            SystemProcess a = new SystemProcess();

            n = -1;

            while (n != 0)
            {
                menu = Show(1);
                n = CheckCorrectNum(menu, 1, 3);

                if (n == 1)
                {
                    a.ShowAllProcesses();
                    Console.ReadKey();

                }

                else if (n == 2) a.FindById();
                else if (n == 3) a.KillProcess();
                else continue;
            }

            break;
        case 2:
            SystemThreads b = new SystemThreads();

            n = -1;

            while (n != 0)
            {
                menu = Show(2);
                n = CheckCorrectNum(menu, 1, 1);

                if (n == 1) b.ShowThreads();
                else continue;
            }

            break;
        case 3:
            SystemModule c = new SystemModule();

            n = -1;

            while( n != 0)
            {
                menu = Show(2);
                n = CheckCorrectNum(menu, 1, 1);

                if (n == 1) c.ShowAllModules();
                else continue;
            }

            break;
    }
}


int CheckCorrectNum(string num, int startNum, int entNum)
{
    int m = 0;
    try
    {
        m = int.Parse(num);
    }
    catch
    {
        Console.WriteLine("Invalid num");
        Console.ReadKey();
        return -1;
    }
    if (m >= startNum && m <= entNum || m == 0)
    {
        return m;
    }

    if(m == 4)
    {
        return m;
    }

    return -1;

}

string Show(int position)
{
    Console.Clear();
    if (position == 0)
    {
        Console.WriteLine("1 - Process");
        Console.WriteLine("2 - Threads");
        Console.WriteLine("3 - Modules");
        Console.WriteLine("4 - Exit");
    }
    else if (position == 1)
    {
        Console.WriteLine("1 - Show all Process");
        Console.WriteLine("2 - Find Process by ID");
        Console.WriteLine("3 - Kill Process");
        Console.WriteLine("0 - Back");
    }
    else if (position == 2)
    {
        Console.WriteLine("1 - Show all Threads by ID");
        Console.WriteLine("0 - Back");
    }
    else if (position == 2)
    {
        Console.WriteLine("1 - Show all Modules by ID");
        Console.WriteLine("0 - Back");
    }

    Console.Write(">>>");

    return Console.ReadLine();
}








