using Bunit;
using Microsoft.Extensions.DependencyInjection;
using TestingMaterialExtendedIcons.Pages;

namespace TestTestingMaterialExtendedIcons
{
	[Collection("TestingMaterialExtendedIcons")]
	public class TestPage_2
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			var componentUnderTest = ctx.RenderComponent<Page_2>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
