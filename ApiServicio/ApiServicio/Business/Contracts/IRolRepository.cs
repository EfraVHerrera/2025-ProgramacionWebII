using ApiServicio.Models;

namespace ApiServicio.Business.Contracts
{
    public interface IRolRepository
    {
        Task<List<Rol>> GetList();
    }
}
