using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WorkshopDemoApp.Infrastructure.Persistence
{
    public interface IFormRepository
    {
        IEnumerable<IDictionary<string, InputValue>> Get(Type formType);
        Task AddAsync(Type formType, IDictionary<string, InputValue> data);
        Task SaveChangesAsync();
    }
}