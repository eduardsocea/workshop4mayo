namespace WorkshopDemoApp.Infrastructure.ValueObjects
{
    public class PhoneNumber
    {
        public string Prefix { get; set; }
        
        public string Suffix { get; set; }

        public PhoneNumber() { }
        
        public PhoneNumber(string prefix, string suffix)
        {
            Prefix = prefix;
            Suffix = suffix;
        }

        public override string ToString()
        {
            return $"{Prefix}-{Suffix}";
        }
    }
}