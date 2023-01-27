using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mime;

namespace DemoAPI.Demo {
	public class DemoController : ControllerBase {

		private readonly IDemoService service;

		public DemoController(IDemoService service) {
			this.service = service;
		}

		[Route("demo", Name = "Demo")]
		[HttpGet]
		[Produces(MediaTypeNames.Application.Json)]
		[ProducesResponseType(typeof(DemoModel), (int)HttpStatusCode.OK)]
		public async Task<ActionResult<DemoModel>> Demo() {
			var model = await this.service.GetDefaultDemoModel();
			return Ok(model);
		}
	}
}
