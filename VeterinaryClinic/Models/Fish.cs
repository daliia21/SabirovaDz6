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
    class Fish : Pet
    {
        public string color { get; set; }

        public Fish(string name, string color, string хозяин, float weight)
            : base(name, TypeOfPet.AquaticPet, хозяин, weight)
        {
            this.color = color;
        }

        public Fish(string ownerOfThePet, float weight)
            : base("Неизвестно", TypeOfPet.AquaticPet, ownerOfThePet, weight)
        {
            color = "Неизвестно";
        }

        public override void ToHeal()
        {
            Console.WriteLine($"{name} (рыбка цвета {color}) лечится в клинике.");
        }

        public void Gurgling()
        {
            Console.WriteLine($"Рыбка {name} булькает.");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Цвет: {color}");
        }
    }
}
