using System.Collections.Generic;
using WorkshopDemoApp.Infrastructure.Metadata;

namespace WorkshopDemoApp.Infrastructure.Services
{
    public interface IFormBuilder
    {
        IEnumerable<AbstractInputMetadata> Metadata { get; }
        T GetMetadata<T>(string inputId)
            where T : AbstractInputMetadata;
    }
}