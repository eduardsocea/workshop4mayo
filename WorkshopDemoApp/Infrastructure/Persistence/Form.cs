using System;

namespace WorkshopDemoApp.Infrastructure.Persistence
{
    public class Form
    {
        public Guid Id { get; private set; }
        public string FormTypeFullName { get; private set; }
        public string Data { get; private set; }

        public Form(Guid id, string formTypeFullName, string data)
        {
            Id = id;
            Data = data;
            FormTypeFullName = formTypeFullName;
        }
    }
}