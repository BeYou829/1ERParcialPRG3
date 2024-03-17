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
        // GET: Department
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
        public ActionResult New()
        {
            return View();
        }
        [HttpPost]
		public ActionResult New(DeptTableViewModel model)
		{
            try
            {
                if (ModelState.IsValid)
                {
                    using(dbmvcp3Entities db = new dbmvcp3Entities())
                    {
                        var oDept = new mDepartamento();
                        oDept.DeptoNombre = model._DeptName;
                        oDept.Activo = model._ActualStatus;

                        db.mDepartamentoes.Add(oDept);
                        db.SaveChanges();
                    }
					return Redirect("/Department/Query");
				}
                return View(model);
			}
            
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
		}

		public ActionResult Edit( int Id )
		{
            DeptTableViewModel model = new DeptTableViewModel();
            using (dbmvcp3Entities db = new dbmvcp3Entities())
            {
                var oDept = db.mDepartamentoes.Find(Id);
                model._DeptName = oDept.DeptoNombre;
                model._ActualStatus = oDept.Activo;
                model._Id = oDept.IdDepto;
            }
			return View(model);
		}
		[HttpPost]
		public ActionResult Edit(DeptTableViewModel model)
		{
			try
			{
				if (ModelState.IsValid)
				{
					using (dbmvcp3Entities db = new dbmvcp3Entities())
					{
						var oDept = db.mDepartamentoes.Find(model._Id);
						oDept.DeptoNombre = model._DeptName;
						oDept.Activo = model._ActualStatus;

						db.Entry(oDept).State = System.Data.Entity.EntityState.Modified;
						db.SaveChanges();
					}
					return Redirect("/Department/Query");
				}
				return View(model);
			}

			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public ActionResult Delete(int Id)
		{
			DeptTableViewModel model = new DeptTableViewModel();
			using (dbmvcp3Entities db = new dbmvcp3Entities())
			{
				var oDept = db.mDepartamentoes.Find(Id);
                db.mDepartamentoes.Remove(oDept);
                db.SaveChanges();
			}
			return Redirect("/Department/Query");
		}
	}
}