using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace jurnal06_103022300113
{
    class SayaTubeVideo
    {
        private int id;
        private String title;
        private int playCount;

        public SayaTubeVideo(String title)
        {
            if (title == null || title.Length > 100)
            {
                throw new ArgumentException("Judul tidak boleh null atau lebih 100 kata");
            }
            this.title = title;
            this.playCount = 0;
            Random random = new Random();
            this.id =  random.Next(10000, 99999);
        }
        public void IncreasePlayCount(int count)
        {
            if(count < 0 || count > 10000000)
            {
                throw new ArgumentException("Jumlah play tidak valid");
            }
            this.playCount += count;
        }
        public void printVideoDetails()
        {
           Console.WriteLine("ID " + id);
            Console.WriteLine("Play Count " + playCount);
        }
        public int getPlayCount()
        {
            return playCount;
        }
        public String getTitle()
        {
            return title;
        }
    }
}
