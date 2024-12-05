using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinaryClinic.Enums;

namespace VeterinaryClinic.AbstractModels
{
    public abstract class Pet
    {
        public string name { get; set; }
        public TypeOfPet typeOfPet { get; set; }
        public string ownerOfThePet { get; set; }
        public float weight { get; set; }

        public Pet(string name, TypeOfPet typeOfPet, string ownerOfThePet, float weight)
        {
            this.name = name;
            this.typeOfPet = typeOfPet;
            this.ownerOfThePet = ownerOfThePet;
            this.weight = weight;
        }

        public abstract void ToHeal();

        //метод для вывода информации о питомце
        virtual public void ShowInfo()
        {
            ShowMessage($"Имя питомца - {name}, тип питомца - {typeOfPet}, хозяин питомца - {ownerOfThePet}, вес питомца - {weight}");
        }

        private void ShowMessage(string message)
        {
            Console.Write(message);
        }

        //методы
        public void ToFeed()
        {
            Console.WriteLine($"{name} покормлен(а).");
        }
        public void GiveADrink()
        {
            if (typeOfPet == TypeOfPet.AquaticPet)
            {
                Console.WriteLine("Не удалось напоить водного питомца!!!");
            }
            else
            {
                Console.WriteLine($"{name} напоен(а).");
            }

        }
        public void ToStroke()
        {
            Console.WriteLine($"{name} поглажен(а).");
        }
        public void Сheck()
        {
            Console.WriteLine($"Проведён осмотр {typeOfPet} по имени {name}.");
        }
        public void Rename(string newName)
        {
            string tempName = name;
            name = newName;
            Console.WriteLine($"Имя питомца {tempName} сменено на {name} ");
        }
    }
}
