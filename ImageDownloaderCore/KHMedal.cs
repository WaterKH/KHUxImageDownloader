using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace ImageDownloaderCore
{
    public class KHMedal
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }
        public string ImageURL { get; set; }
        public int Star { get; set; }
        public string Class { get; set; }
        public string Type { get; set; }
        public string Attribute_PSM { get; set; }
        public string Attribute_UD { get; set; }

        public virtual void PrintReadableData()
        {
            Console.WriteLine("Base Class");
        }

        public virtual void PrintWriteableData(StreamWriter writer)
        {
            Console.WriteLine("Base Class");
        }
    }
}
