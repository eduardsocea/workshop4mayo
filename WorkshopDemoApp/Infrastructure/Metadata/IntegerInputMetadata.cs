using System;
using WorkshopDemoApp.Pages.Inputs;

namespace WorkshopDemoApp.Infrastructure.Metadata
{
    public class IntegerInputMetadata : AbstractInputMetadata
    {
        public IntegerInputMetadata(string id, string label) : base(id, label, typeof(IntegerInput), typeof(int))
        {
        }
        
        public override object Deserialize(string input)
        {
            return int.Parse(input);
        }

        public override string Serialize(object value)
        {
            return value.ToString();
        }
    }
}