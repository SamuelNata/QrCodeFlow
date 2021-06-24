using Qrcode.Flow.Model.Entities;
using Qrcode.Flow.Repository.Implementation;
using Qrcode.Flow.Repository.Interface;
using Qrcode.Flow.Service.Interface;

namespace Qrcode.Flow.Service.Implementation
{
    public class FlowTaskService : IFlowTaskService
    {
        private readonly IFlowTaskRepository _repository;

        public FlowTaskService(IFlowTaskRepository repository)
        {
            _repository = repository;
        }


        public void Create(FlowTask task)
        {
            _repository.Create(task);
        }
    }
}