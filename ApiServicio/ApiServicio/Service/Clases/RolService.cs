using ApiServicio.Business.Contracts;
using ApiServicio.Models;
using ApiServicio.Service.Contracts;

namespace ApiServicio.Service.Clases
{
    public class RolService:IRolService
    {
        private readonly  IRolRepository _repository;
        public RolService(IRolRepository repository)
        {
            _repository = repository;
        }
        public Task<List<Rol>> GetList() 
        { 
            return _repository.GetList(); 
        }
    }
}
