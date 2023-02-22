using Bunit;
using Microsoft.Extensions.DependencyInjection;
using untitled_app.Pages;

namespace Testuntitled_app
{
	public class TestMasterView
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbButtonModule),
				typeof(IgbRippleModule));
			var componentUnderTest = ctx.RenderComponent<MasterView>();
			Assert.NotNull(componentUnderTest);
		}
	}
}