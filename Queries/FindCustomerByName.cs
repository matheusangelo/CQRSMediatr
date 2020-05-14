using System;
using MediatR;

namespace Mediatr.Queries
{
    public class FindCustomerByName : IRequest<FindCustomerByNameResult>
    {
        public string Name { get; set; }
    }
}