using System;

class Billajatekokhoz {

    const int N=60;

    const int M=30;

    static int[,] palya = new int[N,M];

    static void Kajaelhelyez(int db) {
        Random rnd = new ();
        for (int i = 0; i < db; i++) {
            int kajax = rnd.Next(0,N);
            int kajay = rnd.Next(0,M);
            int kajaertek = rnd.Next(5,10);
            palya[kajax,kajay] = kajaertek;
        }
    }

    static void Kajarajz() {
        for (int x = 0; x < N; x++) {
            for (int y = 0; y < M; y++) {
                if(palya[x,y] > 0 ) {
                    Console.SetCursorPosition(x,y);
                    Console.Write(palya[x,y]);
                }
            }
        }
    }
    static void Main() {
        Console.SetWindowSize(N,M);

        bool exit = false;
        int timer = 0;

        int babuX = N/2;
        int babuY = M/2;
        Console.SetCursorPosition(babuX, babuY);
        Console.Write('X');

        Kajaelhelyez(30);
        while(!exit) {
            timer++;
            Console.SetCursorPosition(0, 0);
            Console.Write(timer);
            Kajarajz();

            Thread.Sleep(100);
            if(Console.KeyAvailable ) {
                ConsoleKeyInfo pressed = Console.ReadKey(true);
                if (pressed.Key == ConsoleKey.Escape ) {
                exit = true;
                }
                else if( pressed.Key == ConsoleKey.UpArrow && babuY>0){
                    Console.SetCursorPosition(babuX,babuY);
                    Console.Write(' ');
                    babuY--;
                    Console.SetCursorPosition(babuX, babuY);
                    Console.Write('X');
                }
                else if(pressed.Key == ConsoleKey.DownArrow && babuY <M-1){
                    Console.SetCursorPosition(babuX,babuY);
                    Console.Write(' ');
                    babuY++;
                    Console.SetCursorPosition(babuX, babuY);
                    Console.Write('X');
                }
                else if(pressed.Key == ConsoleKey.LeftArrow && babuX >0) {
                    Console.SetCursorPosition(babuX,babuY);
                    Console.Write(' ');
                    babuX--;
                    Console.SetCursorPosition(babuX, babuY);
                    Console.Write('X');
                }
                else if(pressed.Key == ConsoleKey.RightArrow && babuX <N-1) {
                    Console.SetCursorPosition(babuX,babuY);
                    Console.Write(' ');
                    babuX++;
                    Console.SetCursorPosition(babuX, babuY);
                    Console.Write('X');
                }
            }
        }
        Console.ReadKey();

    }
}