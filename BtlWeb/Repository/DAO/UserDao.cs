using BtlWeb.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BtlWeb.Repository.DAO
{
    public class UserDao
    {
        public static User findUserByUserName(string username)
        {
            string data = Utils.FileIO.readFileJson("1");
            List<User> listUser = JsonConvert.DeserializeObject<List<User>>(data);
            foreach (User user in listUser)
            {
                if (user.Username.Equals(username))
                    return user;
            }
            return null;
        }
    }
}