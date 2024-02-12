using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _1ERParcialPRG3.Models;
using _1ERParcialPRG3.Models.TableViewModel;
namespace _1ERParcialPRG3.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Departament
        public ActionResult Query()
        {
            List<mDeptTableViewModel> listDept = null;
            using (dbmvcp3Entities db = new dbmvcp3Entities())
            {
                listDept = (from d in db.mDepartamentoes
                            where d.Activo == 1
                            orderby d.DeptoNombre
                            
                            select new mDeptTableViewModel
                            {
                                _Id = d.IdDepto,
                                _DeptName = d.DeptoNombre,
                                _ActualStatus = d.Activo
                            }).ToList();
            };
                return View(listDept);
        }
    }
}