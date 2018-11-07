using System.Collections.Generic;

namespace AspNetWebServicesLib.DAL
{
    internal class Client
    {
        internal IEnumerable<DTO.Client> Get()
        {
            return new List<DTO.Client>()
            {
                new DTO.Client() { Id = 1, Name = "Client A", DataBaseName = "Data Base A", WebServerName = "Web Server A" },
                new DTO.Client() { Id = 2, Name = "Client B", DataBaseName = "Data Base B", WebServerName = "Web Server B" },
                new DTO.Client() { Id = 3, Name = "Client C", DataBaseName = "Data Base C", WebServerName = "Web Server C" },
                new DTO.Client() { Id = 4, Name = "Client D", DataBaseName = "Data Base D", WebServerName = "Web Server D" },
                new DTO.Client() { Id = 5, Name = "Client E", DataBaseName = "Data Base E", WebServerName = "Web Server E" },
                new DTO.Client() { Id = 6, Name = "Client F", DataBaseName = "Data Base F", WebServerName = "Web Server F" },
                new DTO.Client() { Id = 7, Name = "Client G", DataBaseName = "Data Base G", WebServerName = "Web Server G" },
                new DTO.Client() { Id = 8, Name = "Client H", DataBaseName = "Data Base H", WebServerName = "Web Server H" },
                new DTO.Client() { Id = 9, Name = "Client I", DataBaseName = "Data Base I", WebServerName = "Web Server I" },
                new DTO.Client() { Id = 10, Name = "Client J", DataBaseName = "Data Base J", WebServerName = "Web Server J" },
                new DTO.Client() { Id = 11, Name = "Client K", DataBaseName = "Data Base K", WebServerName = "Web Server K" },
                new DTO.Client() { Id = 12, Name = "Client L", DataBaseName = "Data Base L", WebServerName = "Web Server L" },
                new DTO.Client() { Id = 13, Name = "Client M", DataBaseName = "Data Base M", WebServerName = "Web Server M" },
                new DTO.Client() { Id = 14, Name = "Client N", DataBaseName = "Data Base N", WebServerName = "Web Server N" },
                new DTO.Client() { Id = 15, Name = "Client O", DataBaseName = "Data Base O", WebServerName = "Web Server O" },
                new DTO.Client() { Id = 16, Name = "Client P", DataBaseName = "Data Base P", WebServerName = "Web Server P" },
                new DTO.Client() { Id = 17, Name = "Client Q", DataBaseName = "Data Base Q", WebServerName = "Web Server Q" },
                new DTO.Client() { Id = 18, Name = "Client R", DataBaseName = "Data Base R", WebServerName = "Web Server R" },
                new DTO.Client() { Id = 19, Name = "Client S", DataBaseName = "Data Base S", WebServerName = "Web Server S" },
                new DTO.Client() { Id = 20, Name = "Client T", DataBaseName = "Data Base T", WebServerName = "Web Server T" }
            };
        }
    }
}
