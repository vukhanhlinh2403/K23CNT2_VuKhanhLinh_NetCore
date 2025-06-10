using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vkllesson08.Models;
namespace Vkllesson08.Controllers
{
    public class VklAccountController : Controller
    {
        private static List<VklAccount> vklListAccount = new List<VklAccount>()
        {
            new VklAccount
                {
                    VklId = 230109056,
                    VklFullName = "Vu Khanh Linh",
                    VklEmail = "vulinhj@gmail.com",
                    VklPhone = "069698479859",
                    VklAddress = "Lớp K23CNT2",
                    VklAvatar = "vulinh.jpg",
                    VklBirthday = new DateTime(1979, 5, 25),
                    VklGender = "Nam",
                    VklPassword = "0978611889",
                    VklFacebook = "https://facebook.com/deveduvn"
                },
                new VklAccount
                {
                    VklId = 2,
                    VklFullName = "Trần Thị B",
                    VklEmail = "tranthib@example.com",
                    VklPhone = "0987654321",
                    VklAddress = "456 Đường B, Quận 3, TP.HCM",
                    VklAvatar = "avatar2.jpg",
                    VklBirthday = new DateTime(1992, 8, 15),
                    VklGender = "Nữ",
                    VklPassword = "password2",
                    VklFacebook = "https://facebook.com/tranthib"
                },
                new VklAccount
                {
                    VklId = 3,
                    VklFullName = "Lê Văn C",
                    VklEmail = "levanc@example.com",
                    VklPhone = "0911222333",
                    VklAddress = "789 Đường C, Quận 5, TP.HCM",
                    VklAvatar = "avatar3.jpg",
                    VklBirthday = new DateTime(1988, 12, 1),
                    VklGender = "Nam",
                    VklPassword = "password3",
                    VklFacebook = "https://facebook.com/levanc"
                },
                new VklAccount
                {
                    VklId = 4,
                    VklFullName = "Phạm Thị D",
                    VklEmail = "phamthid@example.com",
                    VklPhone = "0909876543",
                    VklAddress = "321 Đường D, Quận 7, TP.HCM",
                    VklAvatar = "avatar4.jpg",
                    VklBirthday = new DateTime(1995, 3, 10),
                    VklGender = "Nữ",
                    VklPassword = "password4",
                    VklFacebook = "https://facebook.com/phamthid"
                },
                new VklAccount
                {
                    VklId = 5,
                    VklFullName = "Hoàng Văn E",
                    VklEmail = "hoangvane@example.com",
                    VklPhone = "0933444555",
                    VklAddress = "654 Đường E, Quận 10, TP.HCM",
                    VklAvatar = "avatar5.jpg",
                    VklBirthday = new DateTime(1991, 7, 22),
                    VklGender = "Nam",
                    VklPassword = "password5",
                    VklFacebook = "https://facebook.com/hoangvane"
                }
        };
        // GET: VklAccountController
        public ActionResult VklIndex()
        {
            return View(vklListAccount);
        }

        // GET: VklAccountController/Details/5
        public ActionResult VklDetails(int id)
        {
            var vklModel = vklListAccount.FirstOrDefault(x => x.VklId == id);
            return View(vklModel);
        }

        // GET: VklAccountController/Create
        public ActionResult VklCreate()
        {
            var vklModel = new VklAccount();
            return View(vklModel);
        }

        // POST: VklAccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult VklCreate(VklAccount vklModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    vklListAccount.Add(vklModel);
                    return RedirectToAction(nameof(VklIndex));
                }

                // Nếu dữ liệu không hợp lệ, trả về View để người dùng sửa
                return View(vklModel);
            }
            catch (Exception ex)
            {
                // Bạn có thể log lỗi ở đây nếu cần
                ModelState.AddModelError("", "Có lỗi xảy ra khi thêm mới: " + ex.Message);
                return View(vklModel);
            }
        }

        // GET: VklAccountController/Edit/5
        public ActionResult VklEdit(int id)
        {
            var vklModel = vklListAccount.FirstOrDefault(x => x.VklId == id);
            return View(vklModel);
        }

        // POST: VklAccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult VklEdit(int id, VklAccount vklModel)
        {
            try
            {
                for (int i = 0; i < vklListAccount.Count(); i++)
                {
                    if (vklListAccount[i].VklId == id)
                    {
                        vklListAccount[i] = vklModel;
                        break;
                    }
                }
                return RedirectToAction(nameof(VklIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: VklAccountController/Delete/5
        public ActionResult VklDelete(int id)
        {
            var vklModel = vklListAccount.FirstOrDefault(e => e.VklId == id);
            if (vklModel == null)
            {
                return NotFound();
            }
            return View(vklModel);
        }

        // POST: VklAccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult VklDelete(int id, VklAccount vklModel)
        {
            try
            {
                for (int i = 0; i < vklListAccount.Count; i++)
                {
                    if (vklListAccount[i].VklId == id)
                    {
                        vklListAccount.RemoveAt(i);
                        break;
                    }
                }
                return RedirectToAction(nameof(VklIndex));
            }
            catch
            {
                return View();
            }
        }
    }
}
