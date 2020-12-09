using System;
using WorkshopDemoApp.Pages.Inputs;

namespace WorkshopDemoApp.Infrastructure.Metadata
{
    public class DecimalInputMetadata : AbstractInputMetadata
    {
        public string Format { get; set; }
        
        public DecimalInputMetadata(string id, string label, string format = "0.##") : base(id, label, typeof(DecimalInput), typeof(decimal))
        {
            Format = format;
        }
        
        public override object Deserialize(string input)
        {
            return decimal.Parse(input);
        }

        public override string Serialize(object value)
        {
            return ((decimal)value).ToString(Format);
        }
    }
}