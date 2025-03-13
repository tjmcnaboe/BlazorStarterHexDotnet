namespace Foundation.DataObjectClient
{
    public abstract class HttpApiServiceWrapper<T, Tkey> where T : class
    {
        public IHttpObjectService<T, Tkey> _api;

        public HttpApiServiceWrapper(IHttpObjectService<T, Tkey> api)
        {
            _api = api;
        }

        public async Task<bool> Delete(Tkey Id)
        {
            return await _api.Delete(Id);
        }

        public async Task<T> Get(Tkey id)
        {
            return await _api.Get(id);
        }

        public async Task<List<T>> GetAll()
        {
            var res = await _api.GetAll();
            return res;
        }

        public async Task<T> Insert(T entity)
        {
            return await _api.Insert(entity);
        }

        public async Task<T> Update(T entityToUpdate)
        {
            return await _api.Update(entityToUpdate);
        }
    }
}
