using ECommerce.CarrinhoService.Adapter.RedisCaching.Context;
using Newtonsoft.Json;
using StackExchange.Redis;

namespace ECommerce.CarrinhoService.Adapter.RedisCaching.Repositories.Base
{
    public class BaseCachingRespository
    {
        private IDatabase _data;

        public BaseCachingRespository()
        {
            Init();
        }

        private void Init()
        {
            _data = Connection.ConnectionMultiplexer.GetDatabase();
        }

        public async Task<T?> GetDataAsync<T>(string key)
        {
            var value = await _data.StringGetAsync(key);

            if (!string.IsNullOrEmpty(value))
                return JsonConvert.DeserializeObject<T>(value);

            return default;
        }

        public async Task<bool> SetData<T>(string key, T value)
        {
            var isSet = await _data.StringSetAsync(key, JsonConvert.SerializeObject(value));

            return isSet;
        }

        public  async Task<bool> KeyExistsAsync(string key)
            => await _data.KeyExistsAsync(key);
    }
}
