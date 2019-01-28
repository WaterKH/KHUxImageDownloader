using System;
using System.IO;

namespace ImageDownloaderCore
{
    public class KHAttackMedal : KHMedal
    {
        public int BaseAttack { get; set; }
        public int MaxAttack { get; set; }
        public int BaseDefense { get; set; }
        public int MaxDefense { get; set; }
        public int TraitSlots { get; set; }
        public int BasePetPoints { get; set; }
        public int MaxPetPoints { get; set; }
        public string Ability { get; set; }
        public string AbilityDescription { get; set; }
        public string Target { get; set; }
        public int Gauge { get; set; }

        public string BaseMultiplier { get; set; }
        public string MaxMultiplier { get; set; }
        public string GuiltMultiplier { get; set; }
        public double SubslotMultiplier { get; set; }
        public int Tier { get; set; }

        public string SupernovaName { get; set; }
        public string SupernovaDescription { get; set; }
        public string SupernovaDamage { get; set; }
        public string SupernovaTarget { get; set; }

        public KHAttackMedal() {}

        public KHAttackMedal(KHMedal medal)
        {
            Name = medal.Name;
            ImageURL = medal.ImageURL;
            Star = medal.Star;
            Class = medal.Class;
            Type = medal.Type;
            Attribute_PSM = medal.Attribute_PSM;
            Attribute_UD = medal.Attribute_UD;
        }

        public KHAttackMedal(KHAttackMedal medal)
        {
            Name = medal.Name;
            ImageURL = medal.ImageURL;
            Star = medal.Star;
            Class = medal.Class;
            Type = medal.Type;
            Attribute_PSM = medal.Attribute_PSM;
            Attribute_UD = medal.Attribute_UD;
            BaseAttack = medal.BaseAttack;
            MaxAttack = medal.MaxAttack;
            BaseDefense = medal.BaseDefense;
            MaxDefense = medal.MaxDefense;
            TraitSlots = medal.TraitSlots;
            BasePetPoints = medal.BasePetPoints;
            MaxPetPoints = medal.MaxPetPoints;
            Ability = medal.Ability;
            AbilityDescription = medal.AbilityDescription;
            Target = medal.Target;
            Gauge = medal.Gauge;
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
            Console.WriteLine("BaseAttack: " + BaseAttack);
            Console.WriteLine("MaxAttack: " + MaxAttack);
            Console.WriteLine("BaseDefense: " + BaseDefense);
            Console.WriteLine("MaxDefense: " + MaxDefense);
            Console.WriteLine("TraitSlots: " + TraitSlots);
            Console.WriteLine("BasePetPoints: " + BasePetPoints);
            Console.WriteLine("MaxPetPoints: " + MaxPetPoints);
            Console.WriteLine("Ability: " + Ability);
            Console.WriteLine("Description: " + AbilityDescription);
            Console.WriteLine();
        }
    }
}
