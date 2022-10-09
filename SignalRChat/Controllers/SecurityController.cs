using SignalRChat.Models;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace SignalRChatApp.Controllers
{
    public class SecurityController : Controller
    {
        public chatHubEntities1 db = new chatHubEntities1();

        //https://localhost:44302/
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Users user)
        {
            var userInDb = db.Users.FirstOrDefault(x => x.username == user.username && x.password == user.password);
            if (userInDb != null)
            {
                FormsAuthentication.SetAuthCookie(user.username, false);
                return RedirectToAction("Chat", "Home");
            }
            else
            {
                ViewBag.Mesaj = "geçersiz Kullanıcı. kullanıcı adı ya da şifre hatalı";
                return View();
            }
        }

    }
}