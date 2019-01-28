using System;
using System.IO;
using System.Net;
using System.Linq;
using System.Collections.Generic;

namespace ImageDownloaderCore
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            using (var context = new MedalContext())
            {
                var images = context.Medal.Select(x => x.ImageURL).ToList();
                var names = context.Medal.Select(x => x.Name).ToList();

                SaveImages(images, names);
            }
        }

        public static void SaveImages(List<string> images, List<string> names, string webURL = "http://www.khunchainedx.com")
        {
            //var lines = File.ReadAllLines(file);


                //var previousImage = "";
                //for (int i = 0; i < lines.Length; ++i)
            for (int i = 0; i < images.Count; ++i)
            {
                var image = webURL + images[i];
                var name = names[i];

                var fileName = image.Split('/')[image.Split('/').Length - 1];//.Replace("%E2%98%85_", "")
                                                                                               //.Replace("&amp;", "_").Replace("%26", "").Replace("%28", "").Replace("%29", "")
                                                                                               //.Replace("%C3%A9", "").Replace("%C3%AF", "");
                var folderName = name;

                if (!File.Exists("KHUxImages/" + folderName + "/" + fileName))
                {
                    Directory.CreateDirectory("KHUxImages/" + folderName);
                    Console.WriteLine(image);
                    using (WebClient web = new WebClient())
                    {
                        web.DownloadFile(image, "KHUxImages/" + folderName + "/" + fileName);
                    }
                }
            }
        }
    }
}
