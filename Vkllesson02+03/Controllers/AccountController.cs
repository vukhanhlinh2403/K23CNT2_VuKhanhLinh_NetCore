using Microsoft.AspNetCore.Mvc;
using Vkllesson02_03.Models;
namespace Vkllesson02_03.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            List<Account> accounts = new List<Account>
            {
                new Account()
                {
                    Id = 1,
                    Name = "Hoàng Anh",
                    Email = "anh@gmail.com",
                    Phone = "0986456789",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/Avatar/02.jpg"),
                    Gender = 1,
                    Bio = "My name is small",
                    Birthday = new DateTime(1998, 7, 15)
                },
                new Account()
                {
                    Id = 2,
                    Name = "Minh Thư",
                    Email = "thu.minh@gmail.com",
                    Phone = "0908123456",
                    Address = "Đà Nẵng",
                    Avatar = Url.Content("~/Avatar/03.jpg"),
                    Gender = 0,
                    Bio = "Loves traveling and music",
                    Birthday = new DateTime(1995, 3, 20)
                },
                new Account()
                {
                    Id = 3,
                    Name = "Quang Huy",
                    Email = "huyquang@gmail.com",
                    Phone = "0912345678",
                    Address = "TP.HCM",
                    Avatar = Url.Content("~/Avatar/04.jpg"),
                    Gender = 1,
                    Bio = "Coder by day, gamer by night",
                    Birthday = new DateTime(1992, 12, 5)
                }
            };

            ViewBag.Accounts = accounts;
            return View();
        }
        [Route("ho-so-cua-toi", Name = "profile")]
        public IActionResult Profile(int id)
        {
            List<Account> accounts = new List<Account>()
            {
                new Account()
                {
                    Id = 1,
                    Name = "Vu Khanh Linh",
                    Email = "vulinhj@gmail.com",
                    Phone = "05654468",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/Avatar/03.jpg"),
                    Gender = 1,
                    Bio = "My name is small",
                    Birthday = new DateTime(2005, 5, 11)
                },
                new Account()
                {
                    Id = 2,
                    Name = "Minh Thư",
                    Email = "thu@gmail.com",
                    Phone = "0986456789",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/Avatar/04.jpg"),
                    Gender = 1,
                    Bio = "My name is small",
                    Birthday = new DateTime(1998, 7, 15)
                },
                new Account()
                {
                    Id = 3,
                    Name = "Quang Huy",
                    Email = "huy@gmail.com",
                    Phone = "0986456789",
                    Address = "Hà Nội",
                    Avatar = Url.Content("~/Avatar/05.jpg"),
                    Gender = 1,
                    Bio = "My name is small",
                    Birthday = new DateTime(1998, 7, 15)
                },
            };
            Account account = accounts.FirstOrDefault(ac => ac.Id == id);
            // gửi đối tượng account qua view
            ViewBag.account = account;
            return View();
        }
    }
}
