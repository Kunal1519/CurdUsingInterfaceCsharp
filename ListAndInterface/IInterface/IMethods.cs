using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndInterface.IInterface
{
    public interface IMethods
    {
        public void GetAllUser();
        public void GetById(int id);
        public void AddUser();
        public void UpdateUser(int id);
    }
}
