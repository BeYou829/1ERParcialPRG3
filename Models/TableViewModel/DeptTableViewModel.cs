using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Web;

namespace _1ERParcialPRG3.Models.TableViewModel
{
	public class DeptTableViewModel
	{
		public int _Id { get; set; }
		[Required]
		[Display(Name = "Nombre Departamento")]
		public string _DeptName { get; set; }
		[Display(Name = "Estado Departamento")]
		public int _ActualStatus { get; set; }
    }
}