using Cqrs.Domain.Comands.CreatePerson;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cqrs.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase        
    {
        private readonly CreatePersonCommandHandler _createPersonCommandHandler;
        public PeopleController( CreatePersonCommandHandler createPersonCommandHandler)
        {
            _createPersonCommandHandler = createPersonCommandHandler;
        }

        [HttpPost(Name = "Insert Person")]
        public async Task<Guid> InsertPeopleAsync(CreatePersonCommand createPersonComand, CancellationToken cancellationToken)
        {
            return await _createPersonCommandHandler.HandleAsync(createPersonComand, cancellationToken);
        }
    }
}
