using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using WorkshopDemoApp.Infrastructure.Metadata;

namespace WorkshopDemoApp.Infrastructure.Services
{
    public interface IFormRenderer
    {
        IDictionary<string, InputValue> Model { get; }
        RenderFragment Render(AbstractInputMetadata metadata);
    }
}