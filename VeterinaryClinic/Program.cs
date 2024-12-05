using VeterinaryClinic.AbstractModels;
using VeterinaryClinic.Enums;
using VeterinaryClinic.Models;

namespace VeterinaryClinic
{
    internal class Program
    {

        static void Main()
        {
            PetsClinic petsClinic = new PetsClinic();

            Dog dog1 = new Dog("Арни", "Дворняжка", "Алмаз", 20);
            Fish fish1 = new Fish("Искорка", "Жёлтый", "Далия", 10);

            petsClinic.AddPet(fish1);
            petsClinic.AddPet(dog1);

            Console.WriteLine("Текущие животные в клинике:");
            petsClinic.ShowInfo();



            dog1.ToHeal();
            dog1.ToFeed();
            dog1.toTrain();

            fish1.ToHeal();
            fish1.GiveADrink();
            fish1.Gurgling();

            Pet dog1_new = petsClinic.GetPet("Арни");
            dog1_new.ShowInfo();


            Dog dog2 = new Dog("Джек", "Азалия", 30);
            Fish fish2 = new Fish("Ирина", 15);

            petsClinic.AddPet(fish2);
            petsClinic.AddPet(dog2);

            Console.WriteLine("Текущие животные в клинике:");
            petsClinic.ShowInfo();

        }

    }
}
