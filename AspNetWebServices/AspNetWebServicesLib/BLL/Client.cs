using System.Collections.Generic;
using System.Linq;

namespace AspNetWebServicesLib.BLL
{
    internal class Client
    {
        internal IEnumerable<DTO.Client> Get()
        {
            IEnumerable<DTO.Client> clients = null;
#if DEBUG
            clients = new DAL.ClientMock().Get();
#else
            clients = new DAL.Client().Get();
#endif
            return clients;
        }

        internal DTO.Client GetClientByName(string name)
        {
#if DEBUG
            return new DAL.Client().Get().ToList().Where(c => c.Name == name).FirstOrDefault();
#else
            return new DAL.ClientMock().Get().ToList().Where(c => c.Name == name).FirstOrDefault();
#endif
        }
    }
}
