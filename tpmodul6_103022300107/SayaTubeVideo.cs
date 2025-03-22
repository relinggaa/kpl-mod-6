using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_103022300107
{
    using System;

    public class SayaTubeVideo
    {
   
        private int id;
        private string title;
        private int playCount;

  
        public SayaTubeVideo(string title)
        {
            Random rand = new Random();
            this.id = rand.Next(10000, 99999); 
            this.title = title;
            this.playCount = 0; 
        }


        public void IncreasePlayCount(int count)
        {
            this.playCount += count;
        }

     
        public void PrintVideoDetails()
        {
            Console.WriteLine($"ID: {this.id}");
            Console.WriteLine($"Title: {this.title}");
            Console.WriteLine($"PlayCount: {this.playCount}");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
     
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - [Relingga Aditya]");

         
            video.IncreasePlayCount(5); 

         
            video.PrintVideoDetails();
        }
    }
}
