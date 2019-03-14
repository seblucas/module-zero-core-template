using Abp.Application.Services;
using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpCompanyName.AbpProjectName.Test
{
	public class TestAppService : ApplicationService
	{
		private readonly ILogger _logger;

		public TestAppService()
		{
			_logger = NullLogger.Instance;
		}

		public virtual void Create(TestCreateDto input)
		{
			_logger.Info("Should never go there");
		}

		public virtual int CallCreateInside()
		{
			Create(new TestCreateDto { Label = "Test" });
			_logger.Info("Should also not go there as the custom validator forbids it");
			return 1;
		}
	}
}
