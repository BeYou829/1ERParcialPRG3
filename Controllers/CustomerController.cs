using _1ERParcialPRG3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _1ERParcialPRG3.Models.TableViewModel;

namespace _1ERParcialPRG3.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Query()
        {
            List<CustomerTableViewModel> listCustomer = null;
            using (dbmvcp3Entities db = new dbmvcp3Entities())
            {
                listCustomer = (from d in db.Customers
                               orderby d.CompanyName

                               select new CustomerTableViewModel
							   {
								   _CustomerID = d.CustomerID,
								   _CompanyName = d.CompanyName,
                                   _Address = d.Address,
                                   _City = d.City,
                                   _Region = d.Region
                               }).ToList();
            }
			//List<OrderTableViewModel> listOrder = null;
			//using (dbmvcp3Entities db = new dbmvcp3Entities())
			//{
			//	listCustomer = (from d in db.Orders
								
			//					select new OrderTableViewModel
			//					{
			//						_CustomerID = d.CustomerID,
			//						_CompanyName = d.CompanyName,
			//						_Address = d.Address,
			//						_City = d.City,
			//						_Region = d.Region
			//					}).ToList();
			//}
			//var every = listCustomer+=list
			return View(listCustomer);
        }
    }
}