using BtlWeb.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BtlWeb.Views
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User temp = Repository.DAO.UserDao.findUserByUserName("admin");
            if (temp != null)
            {
                Response.Write(temp.Fullname);
            }
            else
            {
                Response.Write("Khong ton tai admin");
            }
            
        }
    }
}