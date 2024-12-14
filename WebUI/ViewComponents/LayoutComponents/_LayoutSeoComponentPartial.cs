using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.LayoutComponents
{
	public class _LayoutSeoComponentPartial:ViewComponent
	{
		private readonly ISeoService _seoService;

		public _LayoutSeoComponentPartial(ISeoService seoService)
		{
			_seoService = seoService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var value = await _seoService.GetByLayoutSeo();
			return View(value);
		}
	}
}
