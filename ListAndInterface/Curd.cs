using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListAndInterface.IInterface;
using ListAndInterface.Models;

namespace ListAndInterface
{
    public class Curd : IMethods
    {
        List<model> modelsList = new List<model>
        {
            new model {Id = 1,Name = "Kunal Jaiswal"},
            new model {Id = 2,Name = "Akshey"},
            new model {Id = 3,Name = "Teja"},
            new model {Id = 4,Name = "Sahil"},
        };
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

            Console.WriteLine("\nPlease enter the Name of {0} : ", id);
            string? updName = Console.ReadLine();
            user.Name = updName;
            Console.WriteLine("\n User ({0}) is updated SuccessFully...", id);
        }
    }
}
