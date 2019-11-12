using App.Aplication.Client;
using App.Aplication.Clients;
using App.Database;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.UI.Controllers
{
    [Route("[Controller]")]
    public class UserController : Controller
    {
        private ApplicationDbContext dbContext;

        public UserController(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        [HttpGet("client")]
        public IActionResult GetClients() => Ok(new GetClients(dbContext).Do());

        [HttpGet("client/{id}")]
        public IActionResult GetClient(int id) => Ok(new GetClient(dbContext).Do(id));

        [HttpPost("client")]
        public IActionResult CreateClients(ClientViewModel viewModel) => Ok(new CreateClient(dbContext).Do(viewModel));

        [HttpDelete("client/{id}")]
        public IActionResult DeleteClient(int id) => Ok(new DeleteClient(dbContext).Do(id));
        [HttpPut("client")]
        public IActionResult UpdateClient(ClientViewModel viewModel) => Ok(new UpdateClient(dbContext).Do(viewModel));

    }
}
