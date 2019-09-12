using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace lifetimes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
		private readonly RandomNumberGenerator _generator;
		private readonly Repository _repository;

		public ValuesController(RandomNumberGenerator generator, Repository repository)
		{
			_generator = generator;
			_repository = repository;
		}

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { $"RandomNumberGenerator sınıfının ürettiği değer: {_generator.RandomNumber}", $"Repository sınıfının aldığı değer: {_repository.RandomNumber}" };
        }
    }
}
