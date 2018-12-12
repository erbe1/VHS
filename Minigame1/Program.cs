using System;
using System.Threading;

namespace Minigame1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Loading loading = new Loading();
            Console.CursorVisible = false;
            int numberOfTimesLoop = 0;
            do
            {
                loading.Loadingbar(20, 20);
                loading.Ready();
                numberOfTimesLoop++;
            } while (numberOfTimesLoop <= 19);

            theMiniGameRun();
        }

        private static void theMiniGameRun()
        {
            Console.Clear();
            Console.WriteLine("You are late! Ruuuuuun!");
        }
    }

    public class Loading
    {
        int counter = 0;

        public void Loadingbar(int left, int top)
        {
            Console.SetCursorPosition(left, top);

            string loadingText = "Loading Minigame... [";
            string loadingTextTerminator = "                   ]";

            Console.Write(loadingText);
            Console.Write(loadingTextTerminator);

            for (int i = 0; i < counter; i++)
            {
                Console.SetCursorPosition(loadingText.Length + i + left, top);
                Console.Write("*");
            }
        }
        public void Ready()
        {
            counter++;
            Thread.Sleep(150);
        }
    }
}
