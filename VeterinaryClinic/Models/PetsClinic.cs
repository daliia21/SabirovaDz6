using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinaryClinic.AbstractModels;

namespace VeterinaryClinic.Models
{
    public class PetsClinic
    {
        private List<Pet> pets = new List<Pet>();


        public void AddPet(Pet pet)
        {
            pets.Add(pet);
        }

        public Pet GetPet(string name)
        {
            Pet pet = pets.FirstOrDefault(p => p.name == name);

            pets.Remove(pet);

            return pet;
        }

        public void ShowInfo()
        {
            foreach (Pet pet in pets)
            {
                Console.WriteLine("Название животного: " + pet.name + " Владелец: " + pet.ownerOfThePet + " Тип: " + pet.typeOfPet + " Вес: " + pet.weight);
            }
        }
    }
}
