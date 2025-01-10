using Bunit;
using Microsoft.Extensions.DependencyInjection;
using TestingMaterialExtendedIcons.Pages;

namespace TestTestingMaterialExtendedIcons
{
	[Collection("TestingMaterialExtendedIcons")]
	public class TestPage_1
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbIconButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbButtonModule));
			var componentUnderTest = ctx.RenderComponent<Page_1>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
