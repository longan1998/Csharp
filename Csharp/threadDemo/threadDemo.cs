using System;
using System.Threading;

public class threadDemo
{public static void Boom(Object o) {
        int m = (int)o;
        while (m > 0)
        {
            m--;
            int s = 59;
            while (s > 0) {
                Console.WriteLine(m.ToString("D2") + ":" + m);

                s--;

                Thread.Sleep(100);
            }
        }
        Console.WriteLine("bum bum...");
            }

    public static void Main3(string[] args)
    {

        Thread t = new Thread(ShowMessage);
        t.Start("Happy birthday!!!");


    }

    public static void ShowMessage(Object o)
    {
        String s = (String)o;
        while (true)
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("Time: " + i + "s");
                Thread.Sleep(1000);
            }
            Console.WriteLine(s);
        }

    }



    public static void Main2(string[] args)
    {

        Thread t = new Thread(RunOnThread);
        t.Start("Thread 2");

        Thread t2 = new Thread(new ThreadDemo().RunRun);
        t2.Start();

        ThreadDemo td = new ThreadDemo();
        Thread t3 = new Thread(td.RunRun);
        t3.Start();

    }

    public static void RunOnThread(Object a)
    {
        String s = (String)a;
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(s + "--" + i);
            Thread.Sleep(300);
        }
    }
    public void RunRun()
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("Runrung--" + i);
            Thread.Sleep(100);
        }
    }
}
