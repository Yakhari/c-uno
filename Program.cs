using System;

namespace UNO
{
    class Program
    {
        static void Main(string[] args){
            Random rnd = new Random();
            int card = rnd.Next(100);     // creates a number between 0 and 100
            string[] deck = {"r0", "r1", "r2", "r3", "r4", "r5","r6","r7","r8","r9","rs","rr","r+2",
            "y0", "y1", "y2", "y3", "y4", "y5","y6","y7","y8","y9","ys","yr","y+2",
            "g0", "g1", "g2", "g3", "g4", "g5","g6","g7","g8","g9","gs","gr","g+2",
            "b0", "b1", "b2", "b3", "b4", "b5","b6","b7","b8","b9","bs","br","b+2",
            "r1", "r2", "r3", "r4", "r5","r6","r7","r8","r9","rs","rr","r+2",
            "y1", "y2", "y3", "y4", "y5","y6","y7","y8","y9","ys","yr","y+2",
            "g1", "g2", "g3", "g4", "g5","g6","g7","g8","g9","gs","gr","g+2",
            "b1", "b2", "b3", "b4", "b5","b6","b7","b8","b9","bs","br","b+2",
            "cc","cc","cc","cc","cc+4","cc+4","cc+4","cc+4"};

            String[]

            Console.WriteLine(deck[card]);
        }
    }
}
