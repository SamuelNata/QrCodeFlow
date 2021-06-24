using MongoDB.Driver;
using Qrcode.Flow.Model.Entities;
using Qrcode.Flow.Repository.Base;
using Qrcode.Flow.Repository.Interface;

namespace Qrcode.Flow.Repository.Implementation
{
    public class FlowTaskRepository : BaseMongoRepository<FlowTask>, IFlowTaskRepository
    {
        public FlowTaskRepository(IMongoClient mongoClient): base(mongoClient) { }

        protected override string GetCollectionName()
        {
            return "FlowTask";
        }

        protected override string GetDbName()
        {
            return "DefaultMongoDb";
        }
    }
}