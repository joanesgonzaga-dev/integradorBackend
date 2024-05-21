using IntegradorBackend.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IntegradorBackend.Services
{
    public interface ILocatarioService
    {
        Task<List<Locatario>> GetLocatariosAll();

    }
}
