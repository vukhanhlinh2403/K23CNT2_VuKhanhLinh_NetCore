using Microsoft.AspNetCore.Mvc;
using Vkllesson06.Models;

namespace Vkllesson06.Controllers
{
    public class VklEmployeeController : Controller
    {
        private static List<VklEmployee> vklListEmployee = new List<VklEmployee>()
        {
            new VklEmployee { VklId = 1, VklName = "Vu Khanh Linh", VklBirthDay = new DateTime(2005, 3, 24), VklEmail = "vulinhj@gmail.com", VklPhone = "0123456789", VklSalary = 1000, VklStatus = true },
            new VklEmployee { VklId = 2, VklName = "Trần Thị B", VklBirthDay = new DateTime(1998, 4, 20), VklEmail = "b@gmail.com", VklPhone = "0123456790", VklSalary = 2000, VklStatus = true },
            new VklEmployee { VklId = 3, VklName = "Lê Văn C", VklBirthDay = new DateTime(1995, 12, 15), VklEmail = "c@gmail.com", VklPhone = "0123456791", VklSalary = 1500, VklStatus = false },
            new VklEmployee { VklId = 4, VklName = "Phạm Thị D", VklBirthDay = new DateTime(1997, 6, 5), VklEmail = "d@gmail.com", VklPhone = "0123456792", VklSalary = 1700, VklStatus = true },
            new VklEmployee { VklId = 5, VklName = "Sinh viên (Bạn)", VklBirthDay = new DateTime(2003, 1, 1), VklEmail = "sinhvien@example.com", VklPhone = "0987654321", VklSalary = 0, VklStatus = true }
        };
        public IActionResult VklIndex()
        {
            return View(vklListEmployee);
        }

        public IActionResult VklCreate()
        {
            return View();
        }
        public IActionResult VklCreateSubmit(VklEmployee model)
        {
            if (ModelState.IsValid)
            {
                int newId = vklListEmployee.Any() ? vklListEmployee.Max(e => e.VklId) + 1 : 1;
                model.VklId = newId;
                vklListEmployee.Add(model);
                return RedirectToAction("VklIndex");
            }
            return View(model);
        }
        public IActionResult VklEdit(int id)
        {
            var emp = vklListEmployee.FirstOrDefault(e => e.VklId == id);
            if (emp == null)
            {
                return NotFound();
            }
            return View(emp);
        }
        public IActionResult VklEditPUT(VklEmployee updatedEmp)
        {
            var emp = vklListEmployee.FirstOrDefault(e => e.VklId == updatedEmp.VklId);
            if (emp == null)
            {
                return NotFound();
            }

            emp.VklName = updatedEmp.VklName;
            emp.VklBirthDay = updatedEmp.VklBirthDay;
            emp.VklEmail = updatedEmp.VklEmail;
            emp.VklPhone = updatedEmp.VklPhone;
            emp.VklSalary = updatedEmp.VklSalary;
            emp.VklStatus = updatedEmp.VklStatus;

            return RedirectToAction("VklIndex");
        }
        public IActionResult VklDelete(int id)
        {
            var emp = vklListEmployee.FirstOrDefault(e => e.VklId == id);
            if (emp != null)
            {
                vklListEmployee.Remove(emp);
            }
            return RedirectToAction("VklIndex");
        }
    }
}
