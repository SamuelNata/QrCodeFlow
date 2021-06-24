using System;
using MongoDB.Driver;

namespace Qrcode.Flow.Repository.Base
{
    public abstract class BaseMongoRepository<T> : IBaseRepository<T>
    {
        protected readonly IMongoCollection<T> Collection;

        public BaseMongoRepository(IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(GetDbName());
            Collection = database.GetCollection<T>(GetCollectionName());
        }

        protected abstract string GetDbName();
        protected abstract string GetCollectionName();

        public void Create(T item)
        {
            Collection.InsertOne(item);
        }

    }
}
