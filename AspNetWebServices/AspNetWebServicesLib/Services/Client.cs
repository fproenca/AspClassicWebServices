﻿using System.Collections.Generic;

namespace AspNetWebServicesLib.Services
{
    public class Client
    {
        public IEnumerable<DTO.Client> Get()
        {
            return new BLL.Client().Get();
        }
    }
}
