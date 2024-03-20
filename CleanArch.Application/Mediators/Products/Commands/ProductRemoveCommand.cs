using CleanArch.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Mediators.Products.Commands
{
    public class ProductRemoveCommand : IRequest<Product>
    {
        public int Id { get; set; } 
        public ProductRemoveCommand(int id) 
        {
            Id = id;
        }
    }
}
