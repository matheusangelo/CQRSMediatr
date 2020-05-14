using System;

namespace Mediatr.Queries
{
    public class FindCustomerByNameResult
    {
        public FindCustomerByNameResult(Guid id, string name, string email, DateTime date)
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