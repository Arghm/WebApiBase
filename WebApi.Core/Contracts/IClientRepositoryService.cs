using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Core
{
    /// <summary>
    /// Сервис взаимодействия с БД
    /// </summary>
    public interface IClientRepositoryService
    {
        /// <summary>
        /// Записать в бд нового клиента
        /// </summary>
        Task<int> CreateClient(ClientInfo client);

        /// <summary>
        /// Удалить клиента из БД
        /// </summary>
        Task<int> DeleteClient(int id);

        /// <summary>
        /// Получить данные клиента из БД
        /// </summary>
        Task<ClientInfo> GetClientInfo(int id);
    }
}
