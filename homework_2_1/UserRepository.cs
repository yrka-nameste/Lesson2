using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2_1
{
    class UserRepository
    {
        public void Save(User user)
        {
            Console.WriteLine($"Данные сохранены:\n Имя {user.name}\n Возраст {user.age}") ;
        }
    }
}
