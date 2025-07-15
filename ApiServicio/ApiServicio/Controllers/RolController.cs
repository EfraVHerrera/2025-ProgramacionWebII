using ApiServicio.Models;
using ApiServicio.Service.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace ApiServicio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RolController
    {
        private readonly  IRolService rolService;
        public RolController(IRolService rolService)
        {
            this.rolService = rolService;
        }
        [HttpGet]
        public async Task<List<Rol>> GetList()
        {
            return await this.rolService.GetList();
        }
    }
}
