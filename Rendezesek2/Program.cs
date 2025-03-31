﻿using System;


struct Par { public int ossze, csere;};
class Rendezesek 
{

    static int[] tomb;
    const int N = 30;

    static void kiir()
    {
        for(int i=0; i<N; i++)
            System.Console.Write(tomb[i]+" ");
        System.Console.WriteLine();
    }

    static void csere(int i, int j)
    {
        int plusz = tomb[i];
        tomb[i] = tomb[j];
        tomb[j] = plusz;
    }

    static Par minKivRend()
    {
        Par par;
        par.ossze = 0;
        par.csere = 0;
        for(int honnan = 0; honnan <= N-2; honnan++)
        {
            int minind = honnan;
            for(int i=honnan+1; i<N; i++)
            {
                par.ossze++;
                if(tomb[i] < tomb[minind])
                {
                    minind = i;
                }
            }
            par.csere++;
            csere(honnan, minind);
        }

        return par;
    }

    static Par buborek()
    {
        Par par;
        par.ossze = 0;
        par.csere = 0;
        for(int meddig = N-2; meddig >=0; meddig--)
        {
            for(int mutato=0; mutato<=meddig; mutato++)
            {
                par.ossze++;
                if(tomb[mutato] > tomb[mutato+1]){
                    par.csere++;
                    csere(mutato, mutato+1);
                }
            }
        }
        return par;
    }

    static int logKer(int mit)
    {
        int eleje = 0, vege = N-1;
        int kozepe = (eleje+vege)/2;
        while ( tomb[kozepe] != mit && eleje < vege)
        {
            
        
            if( tomb[kozepe] < mit ) 
            {
                eleje = kozepe+1;
            }
            else if( tomb[kozepe] > mit)
            {
                vege = kozepe-1;
            }
            kozepe = (eleje+ vege)/2;
            }
            if(tomb[kozepe] == mit)
                return kozepe;
            else
                return -1;
    }

    static void RendK() {
        Random rnd = new Random();
        int egyik = 0;
        int masik = 1;    
        for (int i = 0; i < 14; i++) {
            Console.WriteLine($"Index: {i}");
            rnd.Next(1, 100);
            
        }
    }


    static void Main()
    {

        tomb = new int[N];
        Random rnd = new ();
        for(int i = 0; i<N; i++)
            tomb[i] = rnd.Next(10000, 100000);
        kiir();

        int[] ment = (int[]) tomb.Clone();


        Par bub = buborek();
        kiir();
        System.Console.WriteLine(bub.ossze+"--"+bub.csere);
        
        tomb = (int[]) ment.Clone();
        Par min = minKivRend();
        kiir();
        System.Console.WriteLine(min.ossze+"--"+min.csere);

        int keres = 34567;
        int holVan = logKer(keres);
        if( holVan >= 0)
        {
            System.Console.WriteLine("Itt van:"+holVan+": "+tomb[holVan]);
        }
        else
        {
            System.Console.WriteLine("Nincs benne");
        }
    }
}