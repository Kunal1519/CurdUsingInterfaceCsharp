using System.Data.SqlTypes;
using System.Reflection;

namespace ListAndInterface
{
    public class Program : IMethods
    {
        List<model> modelsList = new List<model>
        {
            new model {Id = 1,Name = "Kunal Jaiswal"},
            new model {Id = 2,Name = "Akshey"},
            new model {Id = 3,Name = "Teja"},
            new model {Id = 4,Name = "Sahil"},
        };
        static void Main(string[] args)
        {
            Program program = new Program();
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
        public void GetById(int id)
        {
            var user = from n in modelsList
                       where n.Id == id
                       select n;

            if (user.Count() > 0)
            {
                foreach (var item in user)
                {
                    Console.Write("\n" + item.Id);
                    Console.Write("\t" + item.Name);
                }
            }
            else
            {
                Console.WriteLine("\nyou entered wrong choice");
            }
        }
        public void GetAllUser()
        {
            foreach (var item in modelsList)
            {
                Console.Write("\n" + item.Id);
                Console.Write("\t" + item.Name);
            }
        }
        public void AddUser()
        {
            Console.WriteLine("\nPlease enter Name of user: ");
            string? name = Console.ReadLine();

            var lastid = modelsList.Last();


            model m = new model();
            m.Name = name;
            m.Id = modelsList.Count() + 1;
            //m.Id = modelsList.Last();
            modelsList.Add(m);
        }
        public void UpdateUser(int id)
        {
            var user = (from n in modelsList
                       where n.Id == id
                      select n).Single();

            Console.WriteLine("\nPlease enter the Name of {0} : ",id);
            string? updName = Console.ReadLine();
            user.Name = updName;
            Console.WriteLine("\n User ({0}) is updated SuccessFully...",id);
        }
    }
}