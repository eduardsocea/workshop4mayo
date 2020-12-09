using System;
using WorkshopDemoApp.Pages.Inputs;

namespace WorkshopDemoApp.Infrastructure.Metadata
{
    public class StringInputMetadata : AbstractInputMetadata
    {
        public StringInputMetadata(string id, string label) : base(id, label, typeof(StringInput), typeof(string))
        {
        }

        public override object Deserialize(string input)
        {
            return input;
        }

        public override string Serialize(object value)
        {
            return value.ToString();
        }
    }
}