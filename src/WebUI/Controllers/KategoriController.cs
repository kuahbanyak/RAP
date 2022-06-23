using CleanArchitecture.Application.Kategoris.Commands.CreateKategoriCommand;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebUI.Controllers;

    public class KategoriController : ApiControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<Guid>> Create(CreateKategoriCommand command)
        {
            return await Mediator.Send(command);
        }
    }