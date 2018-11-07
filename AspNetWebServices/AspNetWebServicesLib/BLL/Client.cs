using System.Collections.Generic;

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
    }
}
