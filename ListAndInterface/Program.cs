using System.Data.SqlTypes;
using System.Reflection;

namespace ListAndInterface
{
    public class Program 
    {
        
        static void Main(string[] args)
        {
            Curd program = new Curd();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n\n\n-----------------MENU-------------------------");
                Console.WriteLine("--------1)Show All Users--------");
                Console.WriteLine("--------2)TO Add New User-------------------");
                Console.WriteLine("--------3)Get User By ID-----------------------");
                Console.WriteLine("--------4)Update User-----------------------");
                Console.WriteLine("--------5)Exit----------------------------------");
                Console.WriteLine("---------Pls Enter your Choice------------------");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        program.GetAllUser();
                        break;
                    case 2:
                        program.AddUser();
                        break;
                    case 3:
                        Console.WriteLine("\nEnter a Id to See Details : ");
                        int selID = Convert.ToInt32(Console.ReadLine());
                        program.GetById(selID);
                        break;
                    case 4:
                        Console.WriteLine("\nEnter a Id to See Details : ");
                        int updId = Convert.ToInt32(Console.ReadLine());
                        program.UpdateUser(updId);
                        break;
                    case 5:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("\nYou Entered a wrong Choice:");
                        break;
                }
            }
        }
    }
}