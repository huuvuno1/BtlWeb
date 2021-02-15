using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BtlWeb.Entity
{
    public class User
    {
        public int ID { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Fullname { get; set; }
    }
}