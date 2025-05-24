using Microsoft.AspNetCore.Mvc;
using Vkllesson05.Models.DataModels;
namespace Vkllesson05.Controllers
{
    public class VklMemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult VklGetMember()
        {
            var vklMember = new VklMember();
            vklMember.VklMemberId = Guid.NewGuid().ToString();
            vklMember.VklUserName = "LinhLinh";
            vklMember.VklFullName = "vu khanh linh";
            vklMember.VklPassword = "123465a@";
            vklMember.VklEmail = "vulinhj@gmail.com";

            ViewBag.vklMember = vklMember;
            return View();
        }
        public IActionResult VklGetMembers()
        {
            List<MemberModel> members = new List<MemberModel>()
            {
                new MemberModel() { MemberId = Guid.NewGuid().ToString(), Username = "member1", Fullname = "Thanh Vũ 1", Password = "123456", Email = "tv1@gmail.com" },
                new MemberModel() { MemberId = Guid.NewGuid().ToString(), Username = "member2", Fullname = "Thanh Vũ 2", Password = "123456", Email = "tv2@gmail.com" },
                new MemberModel() { MemberId = Guid.NewGuid().ToString(), Username = "member3", Fullname = "Thanh Vũ 3", Password = "123456", Email = "tv3@gmail.com" },
                new MemberModel() { MemberId = Guid.NewGuid().ToString(), Username = "member4", Fullname = "Thanh Vũ 4", Password = "123456", Email = "tv4@gmail.com" },
                new MemberModel() { MemberId = Guid.NewGuid().ToString(), Username = "member5", Fullname = "Thanh Vũ 5", Password = "123456", Email = "tv5@gmail.com" },
            };

            return View(members);
        }
    }
}
