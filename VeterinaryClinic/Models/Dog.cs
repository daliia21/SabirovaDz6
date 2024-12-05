using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using VeterinaryClinic.AbstractModels;
using VeterinaryClinic.Enums;

namespace VeterinaryClinic.Models
{
    class Dog : Pet
    {
        public string breedOfAnimals { get; set; }

        public Dog(string name, string breedOfAnimals, string ownerOfThePet, float weight)
            : base(name, TypeOfPet.LandPet, ownerOfThePet, weight)
        {
            this.breedOfAnimals = breedOfAnimals;
        }

        public Dog(string name, string ownerOfThePet, float weight)
            : base(name, TypeOfPet.LandPet, ownerOfThePet, weight)
        {
            breedOfAnimals = "Неизвестно";
        }

        public override void ToHeal()
        {
            Console.WriteLine($"{name} (собака породы {breedOfAnimals}) лечится в клинике.");
        }

        public void toTrain()
        {
            Console.WriteLine($"Собака {name} проходит дрессировку.");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($", порода - {breedOfAnimals}");
        }
    }
}
