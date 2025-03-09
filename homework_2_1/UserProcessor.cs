using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2_1
{
 class UserProcessor
    {
       public void Proccess(User user)
        {
            user.name=user.name.ToUpper();
            user.age += 1;
        }
    }
}
