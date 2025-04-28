namespace Munka0428
{
    internal class Program
    {
        static int[] hosszak(string[] szovegek)
        {
            int[] hosszusagok = new int[szovegek.Length];
            for (int i = 0; i < szovegek.Length; i++)
            {
                hosszusagok[i] = szovegek[i].Length;
            }
            return hosszusagok;
        }

        //1.Feladat  
        static float szamol(float sz1, float sz2)
        {
            if (sz1 > 0 && sz2 > 0)
            {
                float eredmeny = sz1 * sz2;
                Console.WriteLine($"Eredmény{eredmeny}");
                return eredmeny;
            }
            else if (sz1 < 0 && sz2 < 0)
            {
                float eredmeny = sz1 / sz2;
                Console.WriteLine($"Eredmény{eredmeny}");
                return eredmeny;
            }
            else
            {
                float eredmeny = 0;
                Console.WriteLine($"Eredmény{eredmeny}");
                return eredmeny;
            }
        }

        //2.Feladat  
        static void el_par(int[] szamok)
        {
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] % 2 != 0)
                {
                    Console.WriteLine(szamok[i]);
                    return;
                }
            }
            Console.WriteLine(0);
        }

        //3.Feladat
        

        static void Main(string[] args)
        {
            //Console.WriteLine("Kérek egy szöveget, vesszővel elválasztva: ");  
            //string aszoveg = Console.ReadLine();  
            //string[] feldarabolva = aszoveg.Split(',');  
            //int[] ahosszak = hosszak(feldarabolva);  

            //Console.WriteLine("A hosszúszágok: ");  
            //for (int i = 0; i < ahosszak.Length; i++)  
            //{  
            //    Console.Write(ahosszak[i]);  
            //    if (i < ahosszak.Length - 1)  
            //        Console.Write(", ");  
            //    else  
            //        Console.WriteLine();  
            //}  
            //szamol(1, 2);  

            el_par(new int[] { 6, 8, 4, 8, 2, 2 });
        }
    }
}
