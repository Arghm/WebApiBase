using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Core
{
    /// <summary>
    /// Сервис клиентских данных
    /// </summary>
    public interface IClientService
    {
        /// <summary>
        /// Получить данные клиента по id
        /// </summary>
        Task<ClientInfo> GetClientInfo(int id);
        /// <summary>
        /// Создать клиента
        /// </summary>
        Task<int> CreateClient(ClientInfoJson client);
        /// <summary>
        /// Удалить клиента
        /// </summary>
        Task<int> DeleteClient(int id);
    }
}
