using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Core
{
    public class ClientInfoJson: JsonBase<ClientInfo>
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        public override ClientInfo ToDtoClass()
        {
            ClientInfo clInfo = new ClientInfo();
            clInfo.LastName = ToTitleCase(LastName);
            clInfo.FirstName = ToTitleCase(FirstName);
            clInfo.MiddleName = ToTitleCase(MiddleName);
            return clInfo;
        }
    }
}
