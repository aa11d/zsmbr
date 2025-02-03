using System;

class Orai {
    static double p = 0.1;

    const int N = 80;

    static int[] Jobb = [2, 4, 6, 8, 0];
    static int[] Bal = [1, 3, 5, 7, 9];

    static int[] palya = new int [80];

    static Random  rnd = new Random();

    static void Main() 
    {
        for (int i = 0; i < 80;i++) {
            palya[i] = -1;

        }
        int t = 0;
        while (!Console.KeyAvailable) {
            t++;
            Console.SetCursorPosition(0, 0);
            for (int x = 0; x < 80; x++) {
                if (palya[x] == -1) {
                    Console.Write(' ');
                }
                else {
                    Console.Write(palya[x] % 10);
                }

            }
            if (palya[0] == -1) {
                double veletlen = rnd.NextDouble();
                if (veletlen < p) {
                    int vel2 = rnd.Next(0, 5);
                    palya[0] = Bal[vel2];
            
                }
            }
            if (palya[79] == -1) {
                double vel3 = rnd.NextDouble();
                if (vel3 < p) {
                    int vel4 = rnd.Next(0, 5);
                    palya[79] = Jobb[vel4];
                }
            }
        }
    }
}