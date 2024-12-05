using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DzFromTumakov
{
    static class Program
    {
        static void Task1()
        {
            /*Упражнение 7.1 Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип
            банковского счета(использовать перечислимый тип из упр. 3.1). Предусмотреть методы для
            доступа к данным – заполнения и чтения.Создать объект класса, заполнить его поля и
            вывести информацию об объекте класса на печать.*/

            Console.WriteLine("Упражнение 7.1");

            BankAccount bankAccount = new BankAccount(100, BankAccountType.Accumulation);

            bankAccount.ShowInfo();
        }

        static void Task2()
        {
            /*Упражнение 7.2 Изменить класс счет в банке из упражнения 7.1 таким образом, чтобы
            номер счета генерировался сам и был уникальным. Для этого надо создать в классе
            статическую переменную и метод, который увеличивает значение этого переменной.*/

            Console.WriteLine("Упражнение 7.2");

            BankAccount bankAccount1 = new BankAccount(100, BankAccountType.Accumulation);

            bankAccount1.ShowInfo();

            BankAccount bankAccount2 = new BankAccount(200, BankAccountType.Savings);

            bankAccount2.ShowInfo();
        }

        static void Task3()
        {
            /*Упражнение 7.3 Добавить в класс счет в банке два метода: снять со счета и положить на
            счет. Метод снять со счета проверяет, возможно ли снять запрашиваемую сумму, и в случае
            положительного результата изменяет баланс.*/

            Console.WriteLine("Упражнение 7.3");

            BankAccount bankAccount1 = new BankAccount(100, BankAccountType.Accumulation);

            bankAccount1.ShowInfo();

            bankAccount1.Input(50);

            bankAccount1.ShowInfo();

            bankAccount1.Output(70);
            
            bankAccount1.ShowInfo();
        }


        class BankAccount
        {
            private static int currentId = 1;



            private int accountNumber;
            private decimal balance;
            private BankAccountType bankAccountType;

            public BankAccount(decimal balance, BankAccountType bankAccountType)
            {
                accountNumber = currentId++;

                this.balance = balance;
                this.bankAccountType = bankAccountType;
            }

            public void ShowInfo()
            {
                ShowMessage($"Номер счета: {accountNumber}, Баланс: {balance}, Тип счета: {bankAccountType}");
            }

            private void ShowMessage(string message)
            {
                Console.WriteLine(message);
            }

            public void Input(int amountOfMoney)
            {
                if (amountOfMoney > balance)
                {
                    ShowMessage("На счёте недостаточно средств денег");
                }
                else
                {
                    balance -= amountOfMoney;
                    ShowMessage("Деньги успешно сняты!");
                }
            }

            public void Output(int amountOfMoney)
            {
                balance += amountOfMoney;
                ShowMessage("Счет успешно пополнен!");
            }
        }

        enum BankAccountType
        {
            Accumulation,
            Savings
        }
        
        
        
        static void Task4()
        {
            /*Домашнее задание 7.1 Реализовать класс для описания здания (уникальный номер здания,
            высота, этажность, количество квартир, подъездов). Поля сделать закрытыми,
            предусмотреть методы для заполнения полей и получения значений полей для печати.
            Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества
            квартир на этаже и т.д. Предусмотреть возможность, чтобы уникальный номер здания
            генерировался программно. Для этого в классе предусмотреть статическое поле, которое бы
            хранило последний использованный номер здания, и предусмотреть метод, который
            увеличивал бы значение этого поля.*/

            Console.WriteLine("Домашнее задание 7.1");

            Building building1 = new Building(70, 9, 100, 2);
            building1.ShowInfo();
            building1.CalculatingTheHeighFloor();
            building1.CalculatingThecountApartmentsInEntrance();
            building1.CalculatingThecountApartmentsInFloor();


        }

        class Building
        {
            private static int currentId = 1;

            private int buildingNumber;
            private float height;
            private int countFloor;
            private int countApartments;
            private int countEntrance;
            public Building(float height, int floor, int apartmens, int entrance)
            {
                buildingNumber = currentId++;

                this.height = height;
                this.countFloor = floor;
                this.countApartments = apartmens;
                this.countEntrance = entrance;
            }
            public void ShowInfo()
            {
                ShowMessage($"Номер здания: {buildingNumber}, высота здания: {height}, количество этажей: {countFloor}, количество квартир: {countApartments}, количество подъездов: {countEntrance}");
            }

            private void ShowMessage(string message)
            {
                Console.WriteLine(message);
            }
            public void CalculatingTheHeighFloor()
            {
                float heightFloor = height / countFloor;
                Console.WriteLine($"Высота этажа:{string.Format("{0:f1}", heightFloor)}");
            }

            public void CalculatingThecountApartmentsInEntrance()
            {
                int countApartmentsInEntrance = countApartments / countEntrance;
                Console.WriteLine($"Количество квартир в подъезде:{countApartmentsInEntrance}");

            }

            public void CalculatingThecountApartmentsInFloor()
            {
                int countApartmentsInFloor = countApartments / countEntrance / countFloor;
                Console.WriteLine($"Количество квартир на этаже:{countApartmentsInFloor}");

            }

        }

        static void Main()
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }
    }
}
