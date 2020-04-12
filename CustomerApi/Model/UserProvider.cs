using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApi
{
    public class UserProvider
    {
        public static List<User> users = new List<User>
        {
                new User(Name: "John", age: 23, email: "john.doe@gmail.com", 1),
            new User(Name: "John", age: 23, email: "john.doe@gmail.com", 2)
        };
    }
}