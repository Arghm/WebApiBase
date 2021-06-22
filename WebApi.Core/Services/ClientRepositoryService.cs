using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApi.Common;

namespace WebApi.Core
{
    public class ClientRepositoryService : ConnectionFactory, IClientRepositoryService
    {
        public ClientRepositoryService(DataBaseConfig config) : base(config) { }

        /// <summary>
        /// Записать в бд нового клиента
        /// </summary>
        public Task<int> CreateClient(ClientInfo client)
        {
            using (var conn = GetDbConnection())
            {

            }
            return Task.Run(() => 42);
        }

        /// <summary>
        /// Удалить клиента из БД
        /// </summary>
        public Task<int> DeleteClient(int id)
        {
            using (var conn = GetDbConnection())
            {

            }
            return Task.Run(() => 1);
        }

        /// <summary>
        /// Получить данные клиента из БД
        /// </summary>
        public Task<ClientInfo> GetClientInfo(int id)
        {
            using (var conn = GetDbConnection())
            {

            }
            return Task.Run(() => new ClientInfo() 
            { 
                ClientId = 42,
                LastName = "Тестов",
                FirstName = "Пример",
                MiddleName = "Экспериментович"
            });
        }
    }
}
