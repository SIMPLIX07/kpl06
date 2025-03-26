// See https://aka.ms/new-console-template for more information
using jurnal06_103022300113;
using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Muhammad Salman Al Farizy");

        string[] filmList =
        {
            "Interstellar", "Naruto", "Batman", "Avatar", "Goku", "Avengers", "Doraemon", "Bolang",
            "Arthur Morgan", "Dono"
        };

        for (int i =0; i< filmList.Length; i++)
        {
            SayaTubeVideo video = new SayaTubeVideo($"Review Film {filmList[i]} oleh Muhammad Salman");
            user.AddVideo(video);
        }

        Console.WriteLine("Detail Video");
        //Melakukan print semua     playcount video
        user.printAllVideoPlayCount();
        Console.WriteLine(" ");

        Console.WriteLine("Detail user");
        //Memanggil getter username
        Console.WriteLine($"Username: {user.getUsername()}");
        Console.WriteLine(" ");

        Console.WriteLine("menaikan play count");
        //Perulangan untuk menambahkan views/playcount dari semua video
        for (int i =0; i<filmList.Length; i++)
        {
            user.uploadedVideos[i].IncreasePlayCount(5000);
        }
        Console.WriteLine(" ");
        //Menampilkan detail video setelah ditambah play count
        Console.WriteLine("Menampilkan detail video setelah ditambah play count");
        user.printAllVideoPlayCount();
        Console.WriteLine(" ");
        //Memanggil functiongetTotalPlayCount dari class SayaTubeUser
        Console.WriteLine($"\nTotal semua play count: {user.getTotalVideoPlayCount()}");

    }
}
