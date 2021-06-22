using Serilog;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApi.Common;

namespace WebApi.Core
{
    public class ClientService : IClientService
    {
        private readonly IClientRepositoryService _clientRepository;
        private readonly ILogger _logger = Log.ForContext<ClientService>();
        public ClientService(IClientRepositoryService clientRepository)
        {
            _clientRepository = clientRepository;
        }

        /// <summary>
        /// Получить данные клиента по id
        /// </summary>
        public async Task<ClientInfo> GetClientInfo(int id)
        {
            try
            {
                //Логика
                //Обращение к БД
                return await _clientRepository.GetClientInfo(id);
            }
            catch(Exception ex)
            {
                throw new WebApiServiceException($"Ошибка {nameof(GetClientInfo)}", ex, _logger);
            }
        }
        /// <summary>
        /// Создать клиента
        /// </summary>
        public async Task<int> CreateClient(ClientInfoJson client)
        {
            try
            {
                //Логика (преобразование данных)
                var dtoClass = client.ToDtoClass();
                //Обращение к БДD
                return await _clientRepository.CreateClient(dtoClass);
            }
            catch(Exception ex)
            {
                throw new WebApiServiceException($"Ошибка {nameof(CreateClient)}", ex, _logger);
            }
        }
        /// <summary>
        /// Удалить клиента
        /// </summary>
        public async Task<int> DeleteClient(int id)
        {
            try
            {
                return await _clientRepository.DeleteClient(id);
            }
            catch(Exception ex)
            {
                throw new WebApiServiceException($"Ошибка {nameof(DeleteClient)}", ex, _logger);
            }
        }
    }
}
