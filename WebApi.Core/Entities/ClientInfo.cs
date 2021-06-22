using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Core
{
    /// <summary>
    /// Данные клиента
    /// </summary>
    public class ClientInfo
    {
        public int ClientId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
    }
}
