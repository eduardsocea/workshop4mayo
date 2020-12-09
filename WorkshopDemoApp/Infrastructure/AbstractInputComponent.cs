using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using WorkshopDemoApp.Infrastructure.Metadata;

namespace WorkshopDemoApp.Infrastructure
{
    public abstract class AbstractInputComponent : ComponentBase
    {
        [Parameter]
        public AbstractInputMetadata Metadata { get; set; }
        [Parameter]
        public string Value { get; set; }
        [Parameter]
        public EventCallback<string> ValueChanged { get; set; }

        public virtual async Task OnValueChange(ChangeEventArgs e)
        {
            this.Value = Metadata.Serialize(e.Value.ToString());
            await ValueChanged.InvokeAsync(this.Value);
        }
    }
}