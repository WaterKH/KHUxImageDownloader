using System;
using System.IO;

namespace ImageDownloaderCore
{
    public class KHMiscMedal : KHMedal
    {
        public string Effect { get; set; }
        public string Effect_Description { get; set; }

        public KHMiscMedal() {}

        public KHMiscMedal(KHMedal medal)
        {
            Console.WriteLine(medal.Name);
            Id = medal.Name.Split(':')[0];
            Name = medal.Name.Split(':')[1].Trim();
            ImageURL = medal.ImageURL;
            Star = medal.Star;
            Class = medal.Class;
            Type = medal.Type;
            Attribute_PSM = medal.Attribute_PSM;
            Attribute_UD = medal.Attribute_UD;
        }

        public override void PrintReadableData()
        {
            Console.WriteLine();
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("ImageURL: " + ImageURL);
            Console.WriteLine("Star: " + Star);
            Console.WriteLine("Class: " + Class);
            Console.WriteLine("Type: " + Type);
            Console.WriteLine("Attribute_PSM: " + Attribute_PSM);
            Console.WriteLine("Attribute_UD: " + Attribute_UD);
            Console.WriteLine("Effect: " + Effect);
            Console.WriteLine("Description: " + Effect_Description);
            Console.WriteLine();
        }

        public override void PrintWriteableData(StreamWriter writer)
        {
            writer.Write(Name + ";" + ImageURL + ";" + Star + ";" + Class + ";" + Type + ";" + Attribute_PSM + ";" + Attribute_UD + ";" +
                         Effect + ";" + Effect_Description);
            writer.WriteLine();
        }
    }
}
