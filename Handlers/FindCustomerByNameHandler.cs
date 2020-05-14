using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Mediatr.Commands;
using Mediatr.Entities;
using Mediatr.Queries;
using MediatR;

namespace Mediatr.Handlers
{
    public class FindCustomerByNameHandler : IRequestHandler<FindCustomerByName, FindCustomerByNameResult>
    {
        private readonly List<Customer> _customers;

        private readonly IMapper _mapper;
        public FindCustomerByNameHandler(IMapper mapper)
        {
            _mapper = mapper;
            _customers = new List<Customer>();
        }

        public Task<FindCustomerByNameResult> Handle(FindCustomerByName request, CancellationToken cancellationToken)
        {
            var customer = _mapper.Map<Customer>(new Customer
            {
                Name = "Matheus",
                Email = "matheusangelo@hotmail.com"
            }
            );

            _customers.Add(customer);


            var result = _customers.AsQueryable()
                                   .Where(x => x.Name == request.Name)
                                   .FirstOrDefault();

            return Task.FromResult(new FindCustomerByNameResult(result.Id, result.Name, result.Email, DateTime.Now));

        }
    }
}