using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
	public class Company
	{
		[Column("Company Id")]
		public Guid Id { get; set; }

		[Required(ErrorMessage ="Company name is required")]
		[MaxLength(60,ErrorMessage = "Maximum length for the name is 60")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Company address is required")]
		[MaxLength(60, ErrorMessage = "Maximum length for the address is 60")]
		public string Address { get; set; }
		public string Country { get; set; }
		public ICollection<Employee> Employees { get; set; }
	}
}
