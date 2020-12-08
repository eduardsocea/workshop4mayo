using System.Collections.Generic;

namespace WorkshopDemoApp.Infrastructure.Services
{
    public interface IFormRenderer
    {
        IDictionary<string, InputValue> Model { get; }
        // RenderFragment Render(AbstractInputMetadata metadata);
    }
}