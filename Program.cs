using System;

namespace laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            ResearchTeam a = new ResearchTeam();
            Console.WriteLine(a.ToString());

            Console.WriteLine();
            Console.WriteLine("Year: " + TimeFrame.Year);
            Console.WriteLine("TwoYears: " + TimeFrame.TwoYears);
            Console.WriteLine("Long: " + TimeFrame.Long);
            Console.WriteLine();

            a.Info = TimeFrame.Long;
            a.Organization = "MyOrg";
            a.RegNum = 220202;
            a.Topic = "NewTopic";

            Console.WriteLine(a.ToString());
            Console.WriteLine();

            a.AddPapers(new Paper("Title1", new Person("Mike", "Berns", new DateTime(1968, 12, 7)), new DateTime(2008, 7, 25)));
            Console.WriteLine(a.ToString());

            Console.WriteLine("LAST PAPER");
            Console.WriteLine(a.LastPaper.ToString());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Выберите разделитель:");
            string c = Console.ReadLine();
            Console.WriteLine("Введите размер массивов:");
            string[] mas = Console.ReadLine().Split(c);
            int n = int.Parse(mas[0]);
            int m = int.Parse(mas[1]);
            ResearchTeam[] mas1 = new ResearchTeam[n * m];
            for (int i = 0; i < n * m; i++)
                mas1[i] = new ResearchTeam();
            ResearchTeam[,] mas2 = new ResearchTeam[n, m];
            for (int i = 0; i < n; i++)
                for (int k = 0; k < m; k++)
                    mas2[i,k] = new ResearchTeam();
            ResearchTeam[][] mas3 = new ResearchTeam[n][];
            for (int i = 0; i < n; i++)
            {
                mas3[i] = new ResearchTeam[m];
                for (int k = 0; k < m; k++)
                    mas3[i][k] = new ResearchTeam();
            }

            int time1 = 0;
            int time2 = 0;
            int time3 = 0;

            int t1 = Environment.TickCount;
            for (int i = 0; i < n * m; i++)
                mas1[i].Topic = "ii";
            int t2 = Environment.TickCount;
            time1 = t2 - t1;

            t1 = Environment.TickCount;
            for (int i = 0; i < n; i++)
                for (int k = 0; k < m; k++)
                    mas2[i, k].Topic = "ii";

            t2 = Environment.TickCount;
            time2 = t2 - t1;

            t1 = Environment.TickCount;
            for (int i = 0; i < n; i++)
                for (int k = 0; k < m; k++)
                    mas3[i][k].Topic = "ii";                   
            t2 = Environment.TickCount;
            time3 = t2 - t1;

            Console.WriteLine("Одномерный " + time1 + " Двумерный " + time2 + " Ступенчатый " + time3);
        }
    }
}
