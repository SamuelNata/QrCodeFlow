using System;

namespace Qrcode.Flow.Model.Entities
{
    public class FlowTask
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string ShouldExecuteJSScript { get; set; }
        string BeforeRunJSScript { get; set; }
        string RunJSScript { get; set; }
        string AfterRunJSScript { get; set; }
    }
}
