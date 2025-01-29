using System;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

class Lakotelep
{
    const int N = 30;
    const int M = 30;
    const double K = 8;

    static int[,] palya = new int[N, M];
    static void Terep()
    {
        for (int x = 0; x < N; x++)
        {
            for (int y = 0; y < M; y++) {
                
                if (palya[x,y] == 0) 
                {
                    Console.Write('■');
                }
                else {
                    Console.Write(palya[x,y]);
                }
            }
        }
    }



    static void Szamolo() {
        int lakas = 0;

        for (int x = 0; x < N; x++) {

            for (int y = 0; y < M; y++) {

                if (palya[x,y] >=1) {
                    lakas += palya[x,y];
                }
            }
        }
        Console.Write($"Lakasok szama: {lakas}");
    }

    static void Hazak()
    {
        int db = 0;

        while (db < K)
        {
            Random rnd = new Random();
            int x = rnd.Next(1, N-1);
            int y = rnd.Next(1, M-1);
            int emelet = rnd.Next(1, 10);
            if (palya[x,y] == 0 && palya[x-1,y] == 0 && palya[x+1,y] == 0 && palya[x,y+1] ==0 && palya[x,y-1] ==0)
            {
                db++;
                palya[x,y] = emelet;
            }
        }
    }
        static void Main() 
        {
             Console.SetWindowSize(N, M);

             Hazak();
             Terep();
             Szamolo();
        }
}