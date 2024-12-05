namespace VeterinaryClinic
{
    internal class Program
    {

        enum TypeOfPet
        {
            LandPet,
            AquaticPet
        }
        
        abstract class Pet
        {
            public string name { get; set; }
            public TypeOfPet typeOfPet { get; set; }
            public string ownerOfThePet { get; set; }
            public float weight {  get; set; }

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
                Console.WriteLine(message);
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
                Console.WriteLine($"Порода: {breedOfAnimals}");
            }
        }

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

        class VeterinaryClinic
        {
            static void Main()
            {
                Dog dog1 = new Dog("Арни", "Дворняжка", "Алмаз", 20);
                Fish fish1 = new Fish("Искорка","Жёлтый", "Далия", 10);

                dog1.ShowInfo();
                fish1.ShowInfo();

                dog1.ToHeal();
                dog1.ToFeed();
                dog1.toTrain();

                fish1.ToHeal();
                fish1.GiveADrink();
                fish1.Gurgling();

                Dog dog2 = new Dog("Джек", "Азалия", 30);
                Fish fish2 = new Fish("Ирина", 15);

                dog2.ShowInfo();
                fish2.ShowInfo();

                List<Pet> pets = new List<Pet> { dog1, fish1, dog2, fish2 };

                Console.WriteLine("\nСписок животных в клинике:");
                foreach (var pet in pets)
                {
                    pet.ShowInfo();
                }

            }

        }
    }
}
