using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PuertoVaras.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(object a)
        {
            var username = Request["username"];
            var email = Request["email"];
            var password = Request["password"];

            string strcon = "Data Source = sqlexpress;Initial Catalog=PuertoDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand com = new SqlCommand("storlogin134", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("username", username);
            SqlParameter p2 = new SqlParameter("email", email);
            SqlParameter p3 = new SqlParameter("password", password);
            com.Parameters.Add(p1);
            com.Parameters.Add(p2);
            com.Parameters.Add(p3);
            con.Open();
            com.ExecuteNonQuery();
            //http://www.c-sharpcorner.com/UploadFile/rohatash/simple-user-login-in-Asp-Net-using-C-Sharp/
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}