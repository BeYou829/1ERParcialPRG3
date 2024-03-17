using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1ERParcialPRG3.Models.TableViewModel
{
	public class OrderTableViewModel
	{
		public int _OrderID { get; set; }
		public string _CustomerID { get; set; }
		public Nullable<int> _EmployeeID { get; set; }
		public Nullable<System.DateTime> _OrderDate { get; set; }
		public Nullable<System.DateTime> _RequiredDate { get; set; }
		public Nullable<System.DateTime> _ShippedDate { get; set; }
		public Nullable<int> _ShipVia { get; set; }
		public Nullable<decimal> _Freight { get; set; }
		public string _ShipName { get; set; }
		public string _ShipAddress { get; set; }
		public string _ShipCity { get; set; }
		public string _ShipRegion { get; set; }
		public string _ShipPostalCode { get; set; }
		public string _ShipCountry { get; set; }
	}
}