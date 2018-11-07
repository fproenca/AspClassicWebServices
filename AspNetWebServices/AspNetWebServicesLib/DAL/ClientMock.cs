using System.Collections.Generic;

namespace AspNetWebServicesLib.DAL
{
    internal class ClientMock
    {
        internal IEnumerable<DTO.Client> Get()
        {
            return new List<DTO.Client>()
            {
                new DTO.Client() { Id = 1, Name = "Client A Mock", DataBaseName = "Data Base A", WebServerName = "Web Server A" },
                new DTO.Client() { Id = 2, Name = "Client B Mock", DataBaseName = "Data Base B", WebServerName = "Web Server B" },
                new DTO.Client() { Id = 3, Name = "Client C Mock", DataBaseName = "Data Base C", WebServerName = "Web Server C" },
                new DTO.Client() { Id = 4, Name = "Client D Mock", DataBaseName = "Data Base D", WebServerName = "Web Server D" },
                new DTO.Client() { Id = 5, Name = "Client E Mock", DataBaseName = "Data Base E", WebServerName = "Web Server E" },
                new DTO.Client() { Id = 6, Name = "Client F Mock", DataBaseName = "Data Base F", WebServerName = "Web Server F" },
                new DTO.Client() { Id = 7, Name = "Client G Mock", DataBaseName = "Data Base G", WebServerName = "Web Server G" },
                new DTO.Client() { Id = 8, Name = "Client H Mock", DataBaseName = "Data Base H", WebServerName = "Web Server H" },
                new DTO.Client() { Id = 9, Name = "Client I Mock", DataBaseName = "Data Base I", WebServerName = "Web Server I" },
                new DTO.Client() { Id = 10, Name = "Client J Mock", DataBaseName = "Data Base J", WebServerName = "Web Server J" },
                new DTO.Client() { Id = 11, Name = "Client K Mock", DataBaseName = "Data Base K", WebServerName = "Web Server K" },
                new DTO.Client() { Id = 12, Name = "Client L Mock", DataBaseName = "Data Base L", WebServerName = "Web Server L" },
                new DTO.Client() { Id = 13, Name = "Client M Mock", DataBaseName = "Data Base M", WebServerName = "Web Server M" },
                new DTO.Client() { Id = 14, Name = "Client N Mock", DataBaseName = "Data Base N", WebServerName = "Web Server N" },
                new DTO.Client() { Id = 15, Name = "Client O Mock", DataBaseName = "Data Base O", WebServerName = "Web Server O" },
                new DTO.Client() { Id = 16, Name = "Client P Mock", DataBaseName = "Data Base P", WebServerName = "Web Server P" },
                new DTO.Client() { Id = 17, Name = "Client Q Mock", DataBaseName = "Data Base Q", WebServerName = "Web Server Q" },
                new DTO.Client() { Id = 18, Name = "Client R Mock", DataBaseName = "Data Base R", WebServerName = "Web Server R" },
                new DTO.Client() { Id = 19, Name = "Client S Mock", DataBaseName = "Data Base S", WebServerName = "Web Server S" },
                new DTO.Client() { Id = 20, Name = "Client T Mock", DataBaseName = "Data Base T", WebServerName = "Web Server T" }
            };
        }
    }
}
