using BtlWeb.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BtlWeb.Views.Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string username = Request.Form.Get("username");
                string password = Request.Form.Get("password");
                User user = Repository.DAO.UserDao.findUserByUserName(username);
                if (user != null)
                {
                    if (user.Password.Equals(password))
                        Response.Write("Dang nhap thanh cong");

                }
            }
        }
    }
}