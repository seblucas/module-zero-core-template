using Abp.Application.Services;
using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpCompanyName.AbpProjectName.Test
{
	public class AnotherAppService : ApplicationService
	{
		private readonly ILogger _logger;
		private readonly TestAppService _testAppService;

		public AnotherAppService(TestAppService testAppService)
		{
			_logger = NullLogger.Instance;
			_testAppService = testAppService;
		}

		public virtual int CallCreateThroughInjection()
		{
			_testAppService.Create(new TestCreateDto { Label = "Test" });
			_logger.Info("It actually does not go there as the validator is really called");
			return 1;
		}
	}
}
