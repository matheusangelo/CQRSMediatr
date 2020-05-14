using System;

namespace Mediatr.Commands
{
    public class CreateCustomerResult
    {
        public CreateCustomerResult(Guid id, string name, string email, DateTime date)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Date = date;

        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
    }
}