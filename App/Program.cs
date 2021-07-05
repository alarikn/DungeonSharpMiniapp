using System;

namespace Netcore.Docker
{
    class Program
    {
        static void Main(string[] args)
        {
            GameLooper looper = new GameLooper();
            looper.Start();
        }
    }
}
