using System;

namespace birthdayCelebrator
{
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayManager birthdayManager = new BirthdayManager();

            // Adding some sample people with birthdays
            birthdayManager.AddPerson("Steve", new DateTime(1954, 9, 28));
            birthdayManager.AddPerson("Alexa", new DateTime(1990, 10, 15));
            birthdayManager.AddPerson("Maria", new DateTime(1992, 12, 20));
            birthdayManager.AddPerson("Ethan", new DateTime(1988, 12, 2));

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add person");
                Console.WriteLine("2. Remove person");
                Console.WriteLine("3. Update birthday");
                Console.WriteLine("4. List people");
                Console.WriteLine("5. Check birthdays today");
                Console.WriteLine("6. List upcoming birthdays");
                Console.WriteLine("7. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddPerson(birthdayManager);
                        break;
                    case "2":
                        RemovePerson(birthdayManager);
                        break;
                    case "3":
                        UpdateBirthday(birthdayManager);
                        break;
                    case "4":
                        ListPeople(birthdayManager);
                        break;
                    case "5":
                        birthdayManager.CheckBirthdaysToday();
                        break;
                    case "6":
                        ListUpcomingBirthdays(birthdayManager);
                        break;
                    case "7":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static void AddPerson(BirthdayManager birthdayManager)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter birthday (yyyy-mm-dd): ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            birthdayManager.AddPerson(name, birthday);
        }

        static void RemovePerson(BirthdayManager birthdayManager)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            birthdayManager.RemovePerson(name);
        }

        static void UpdateBirthday(BirthdayManager birthdayManager)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Person person = birthdayManager.GetPerson(name);
            if (person != null)
            {
                Console.Write("Enter new birthday (yyyy-mm-dd): ");
                DateTime newBirthday = DateTime.Parse(Console.ReadLine());
                person.UpdateBirthday(newBirthday);
            }
            else
            {
                Console.WriteLine("Person not found.");
            }
        }

        static void ListPeople(BirthdayManager birthdayManager)
        {
            Console.WriteLine("\nList of people:");
            foreach (var person in birthdayManager.GetPeople())
            {
                Console.WriteLine($"{person.Name} - {person.Birthday.ToString("yyyy-MM-dd")}");
            }
        }

        static void ListUpcomingBirthdays(BirthdayManager birthdayManager)
        {
            Console.Write("Enter number of days ahead: ");
            int daysAhead = int.Parse(Console.ReadLine());
            birthdayManager.ListUpcomingBirthdays(daysAhead);
        }
    }
}
