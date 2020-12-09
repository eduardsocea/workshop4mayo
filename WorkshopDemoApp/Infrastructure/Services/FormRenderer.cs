using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;
using WorkshopDemoApp.Infrastructure.Metadata;

namespace WorkshopDemoApp.Infrastructure.Services
{
    public class FormRenderer : IFormRenderer
    {
        public IDictionary<string, InputValue> Model { get; }

        public FormRenderer(IFormBuilder formBuilder)
        {
            Model = formBuilder.Metadata.ToDictionary(x => x.Id, x => new InputValue());
        }

        public RenderFragment Render(AbstractInputMetadata metadata) => builder =>
        {
            builder.OpenComponent(0, metadata.InputType);
            builder.AddAttribute(1, nameof(AbstractInputComponent.Metadata), metadata);
            builder.AddAttribute(2, nameof(AbstractInputComponent.Value), Model[metadata.Id].Value);
            builder.AddAttribute(3, nameof(AbstractInputComponent.ValueChanged), EventCallback.Factory.Create<string>(this, ev => Model[metadata.Id].Value = ev));
            builder.CloseComponent();
        };
    }
}