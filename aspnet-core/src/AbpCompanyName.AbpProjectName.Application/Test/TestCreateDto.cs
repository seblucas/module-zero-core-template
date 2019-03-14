using Abp.Runtime.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpCompanyName.AbpProjectName.Test
{
	public class TestCreateDto : ICustomValidate
	{
		public string Label { get; set; }

		public void AddValidationErrors(CustomValidationContext context)
		{
			context.Results.Add(new ValidationResult("Error"));
		}
	}
}
