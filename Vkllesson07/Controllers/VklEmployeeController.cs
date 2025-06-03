using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vkllesson07.Models;

namespace Vkllesson07.Controllers
{
    public class VklEmployeeController : Controller
    {
        //mock data
        private static List<VklEmployee> vklListEmployee = new List<VklEmployee>()
        {
            new VklEmployee { VklId = 231090056, VklName = "Vũ Khánh Linh", VklBirthDay = new DateTime(2005, 3, 24), VklEmail = "vulinhj@gmail.com", VklPhone = "0912345678", VklSalary = 1000.00m, VklStatus = true },
            new VklEmployee { VklId = 2, VklName = "Tran Thi B", VklBirthDay = new DateTime(1992, 2, 2), VklEmail = "b@gmail.com", VklPhone = "0923456789", VklSalary = 1200.00m, VklStatus = true },
            new VklEmployee { VklId = 3, VklName = "Le Van C", VklBirthDay = new DateTime(1988, 3, 3), VklEmail = "c@gmail.com", VklPhone = "0934567890", VklSalary = 1500.00m, VklStatus = false },
            new VklEmployee { VklId = 4, VklName = "Pham Thi D", VklBirthDay = new DateTime(1995, 4, 4), VklEmail = "d@gmail.com", VklPhone = "0945678901", VklSalary = 1100.00m, VklStatus = true },
            new VklEmployee { VklId = 5, VklName = "Do Van E", VklBirthDay = new DateTime(1993, 5, 5), VklEmail = "e@gmail.com", VklPhone = "0956789012", VklSalary = 1300.00m, VklStatus = false }
        };
        // GET: VklEmployeeController
        public ActionResult VklIndex()
        {
            return View(vklListEmployee);
        }

        // GET: VklEmployeeController/VklDetails/5
        public ActionResult VklDetails(int id)
        {
            var vklEmployee = vklListEmployee.FirstOrDefault(x => x.VklId == id);
            return View(vklEmployee);
        }

        // GET: VklEmployeeController/VklCreate
        public ActionResult VklCreate()
        {
            var vklEmployee = new VklEmployee();
            return View(vklEmployee);
        }

        // POST: VklEmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult VklCreate(VklEmployee vklModel)
        {
            try
            {
                //them moi vao list
                vklModel.VklId = vklListEmployee.Max(x=>x.VklId) + 1;
                vklListEmployee.Add(vklModel);
                return RedirectToAction(nameof(VklIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: VklEmployeeController/VklEdit/5
        public ActionResult VklEdit(int id)
        {
            var vklEmployee = vklListEmployee.FirstOrDefault(x => x.VklId == id);
            return View(vklEmployee);
        }

        // POST: VklEmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult VklEdit(int id, VklEmployee vklModel)
        {
            try
            {
                for (int i = 0; i < vklListEmployee.Count(); i++)
                {
                    if (vklListEmployee[i].VklId == id)
                    {
                        vklListEmployee[i] = vklModel;
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

        // GET: VklEmployeeController/VklDelete/5
        public ActionResult VklDelete(int id)
        {
            var vklEmployee = vklListEmployee.FirstOrDefault(e => e.VklId == id);
            if (vklEmployee == null)
            {
                return NotFound();
            }
            return View(vklEmployee);
        }

        // POST: VklEmployeeController/VklDelete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult VklDelete(int id, VklEmployee vklModel)
        {
            try
            {
                for (int i = 0; i < vklListEmployee.Count; i++)
                {
                    if (vklListEmployee[i].VklId == id)
                    {
                        vklListEmployee.RemoveAt(i);
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
