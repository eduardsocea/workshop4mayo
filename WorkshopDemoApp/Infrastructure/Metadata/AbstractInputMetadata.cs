using System;

namespace WorkshopDemoApp.Infrastructure.Metadata
{
    public abstract class AbstractInputMetadata
    {
        public string Id { get; set; }
        public string Label { get; set; }
        public Type InputType { get; set; }
        public Type ValueType { get; set; }

        protected AbstractInputMetadata(string id, string label, Type inputType, Type valueType)
        {
            Label = label;
            Id = id;
            InputType = inputType;
            ValueType = valueType;
        }
        
        public abstract object Deserialize(string input);
        public abstract string Serialize(object value);
    }
}