using System.Collections.Generic;
using System.Linq;
using WorkshopDemoApp.Infrastructure.Metadata;

namespace WorkshopDemoApp.Infrastructure.Services
{
    public class UserInformationFormBuilder : IFormBuilder
    {
        public IEnumerable<AbstractInputMetadata> Metadata { get; }

        public UserInformationFormBuilder()
        {
            Metadata = new AbstractInputMetadata[]
            {
                new StringInputMetadata("first-name", "First Name"),
                new StringInputMetadata("last-name", "Last Name"),
                new IntegerInputMetadata("age", "Age"),
                new DecimalInputMetadata("weight", "Weight"),
                new PhoneNumberInputMetadata("phone-number", "Phone Number") 
            };
        }

        public T GetMetadata<T>(string inputId) where T : AbstractInputMetadata
        {
            return (T)Metadata.SingleOrDefault(x => x.Id == inputId);
        }
    }
}