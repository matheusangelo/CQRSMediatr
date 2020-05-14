using System;
using MediatR;

namespace Mediatr.Commands
{
    public class CreateCustomerCommand : IRequest<CreateCustomerResult>
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}