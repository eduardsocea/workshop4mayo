using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WorkshopDemoApp.Infrastructure.Persistence
{
    public class FormRepository : IFormRepository
    {
        private readonly WorkshopDbContext _dbContext;

        public FormRepository(WorkshopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<IDictionary<string, InputValue>> Get(Type type)
        {
           return _dbContext.Form.Where(x => x.FormTypeFullName == type.FullName).Select(x => JsonConvert.DeserializeObject<IDictionary<string, InputValue>>(x.Data));
        }

        public async Task AddAsync(Type formType, IDictionary<string, InputValue> data)
        {
            var serializedData = JsonConvert.SerializeObject(data);
            await _dbContext.Form.AddAsync(new Form(Guid.NewGuid(), formType.FullName, serializedData));
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}