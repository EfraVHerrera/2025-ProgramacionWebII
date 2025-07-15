using ApiServicio.Models;

namespace ApiServicio.Service.Contracts
{
    public interface IRolService
    {
        Task<List<Rol>> GetList();
    }
}
