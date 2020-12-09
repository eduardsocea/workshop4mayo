using System;
using Newtonsoft.Json;
using WorkshopDemoApp.Infrastructure.ValueObjects;
using WorkshopDemoApp.Pages.Inputs;

namespace WorkshopDemoApp.Infrastructure.Metadata
{
    public class PhoneNumberInputMetadata : AbstractInputMetadata
    {
        public PhoneNumberInputMetadata(string id, string label) : base(id, label, typeof(PhoneNumberInput), typeof(PhoneNumber))
        {
        }
        
        public override object Deserialize(string input)
        {
            return JsonConvert.DeserializeObject(input, this.ValueType);
        }

        public override string Serialize(object value)
        {
            return JsonConvert.SerializeObject(value);
        }
    }
}