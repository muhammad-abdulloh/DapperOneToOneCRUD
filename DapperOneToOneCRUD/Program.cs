using DapperOneToOneCRUD.Data;
using DapperOneToOneCRUD.Data.Repositories;
using System;

namespace DapperOneToOneCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository  repo = new Repository();

            Console.WriteLine("1. Create | 2. ReadAll | 3. Update | 4. Delete");
            int choose = int.Parse(Console.ReadLine());

            if (choose == 1)
            {
                Person person = new Person();

                Console.WriteLine(" Entering passportId: ");
                person.passportId = int.Parse(Console.ReadLine());

                Console.WriteLine(" Entering nick name: ");
                person.name = Console.ReadLine();

                Console.WriteLine("Entering firstname: ");
                person.firstName = Console.ReadLine();

                Console.WriteLine("Entering lastname: ");
                person.lastName = Console.ReadLine();

                repo.Create(person);
            }
            else if (choose == 2)
            {
                foreach (Person item in repo.GetAll())
                {
                    Console.WriteLine($"{item.passportId}, {item.name}, {item.firstName}, {item.lastName}");
                }
            }
            else if (choose == 3)
            {
                Console.WriteLine("O'zgartirmoqchi bo'lgan qatorning Id raqamini kiriting: ");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("O'zgartirmoqchi bo'lgan nick name ni kiriting: ");
                string nick = Console.ReadLine();
                repo.Update(id, nick);
            }
            else if (choose == 4)
            {
                Console.WriteLine("o'chirmoqchi rowni bo'lgan id raqamini kiriting: ");
                int id = int.Parse(Console.ReadLine());
                repo.Delete(id);
            }


        }
    }
}
