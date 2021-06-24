using System;

namespace Qrcode.Flow.Repository.Base
{
    public interface IBaseRepository<T>
    {
        void Create(T item);
    }
}
