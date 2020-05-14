using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Mediatr.Commands;
using Mediatr.Entities;
using MediatR;

namespace Mediatr.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand, CreateCustomerResult>
    {
        private readonly IMapper _mapper;
        public CreateCustomerHandler(IMapper mapper)
        {
            _mapper = mapper;
        }
        public Task<CreateCustomerResult> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var result = _mapper.Map<Customer>(request);

            return Task.FromResult(new CreateCustomerResult(result.Id, result.Name, result.Email, DateTime.Now));
        }
    }
}