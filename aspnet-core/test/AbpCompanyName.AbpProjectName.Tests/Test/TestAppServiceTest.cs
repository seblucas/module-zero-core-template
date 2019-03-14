using Abp.Runtime.Validation;
using AbpCompanyName.AbpProjectName.Test;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;

namespace AbpCompanyName.AbpProjectName.Tests.Test
{
	public class TestAppServiceTest : AbpProjectNameTestBase
	{
		private readonly TestAppService _app;

		public TestAppServiceTest()
		{
			_app = Resolve<TestAppService>();
		}

		[Fact]
		public void Create_Test()
		{
			Exception ex = Assert.Throws<AbpValidationException>(() =>
			{
				_app.Create(
					new TestCreateDto
					{
						Label = "Test"
					});
			});

		}

		[Fact]
		public void CallCreateInside_Test()
		{
			int result = _app.CallCreateInside();
			result.ShouldBe(1);
		}
	}
}
