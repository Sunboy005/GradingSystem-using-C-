using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem
{
    class UserRepo
    {
        //Retrieval Method
        public User Retrieve(int userId)
        {
            User newUser = new User(userId);

            if (userId == 1)
            {
                newUser.FirstName = "Akinola";
                newUser.LastName = "Amos";
                newUser.Dept = "Arts";
            }
            //To retrieve a customer from ID
            return newUser;
        }

        //Retrieve All Customer
        public bool Save()
        {
            //To Save a customer details
            return true;
        }

    }
}
