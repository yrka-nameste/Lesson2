using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2_1
{
 class UserValidator
    {
        public void Validate(User user) {
            if (string.IsNullOrWhiteSpace(user.name))
            {
                throw new Exception("Имя пользователя не может быть пустым");

            }
            if (user.age < 0)
            {
                throw new Exception("Возраст не может быть отрицательным");
            }


        }
    }
}
