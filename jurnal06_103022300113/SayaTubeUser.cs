using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnal06_103022300113
{
    class SayaTubeUser
    {
        private int id;
        public String username;
        public List<SayaTubeVideo> uploadedVideos;

        public SayaTubeUser(String username)
        {
            if (username == null || username.Length > 100)
            {
                //exception jika tidak memenuhi syarat
                throw new ArgumentException("Username tidak valid");
            }
            this.username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();
            this.id = new Random().Next(10000, 99999);
        }

        public void AddVideo(SayaTubeVideo video)
        {
            if (video == null)
            {
                //exception jika tidak memenuhi syarat
                throw new ArgumentException("Video tidak boleh null");
                
            }
            uploadedVideos.Add(video);
        }

        public int getTotalVideoPlayCount()
        {
            int total = 0;
            for (int i =0; i< uploadedVideos.Count; i++)
            {
                //menambahkan semua views dari semua video
                total += uploadedVideos[i].getPlayCount();
            }
            return total;
        }

        public void printAllVideoPlayCount()
        {
            Console.WriteLine($"Username: {username}");
            for (int i =0; i <uploadedVideos.Count; i++)
            {
                Console.Write(uploadedVideos[i].getTitle() + " ");
                Console.WriteLine($"Video {i + 1} : {uploadedVideos[i].getPlayCount()} views");
            }
        }

        public String getUsername()
        {
            return this.username;
        }
    }
}
