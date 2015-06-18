using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Term_Project.Models
{
    public class UserRepository
    {
        void addUser(user u)
        {
            using (OnlineMobileShopEntities1 obj = new OnlineMobileShopEntities1())
            {
                obj.users.Add(u);
                obj.SaveChanges();
            }
        }
    }
}