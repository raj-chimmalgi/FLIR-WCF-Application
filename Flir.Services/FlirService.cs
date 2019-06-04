﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Permissions;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flir.Data;
using Flir.Entities;


namespace Flir.FlirServices
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class FlirService : IFlirService, IDisposable
    {
        readonly FlirDbContext _context = new FlirDbContext();

        public void Dispose()
        {
            _context.Dispose();
        }

        public List<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }

        [PrincipalPermission(SecurityAction.Demand, Role = "BUILTIN\\Administrators")]
        public List<Product> GetProducts()
        {
            var principle = Thread.CurrentPrincipal;
            if(!principle.IsInRole("BUILTIN\\Administrators"))
                throw new SecurityAccessDeniedException();
            return _context.Products.ToList();
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public void SubmitOrder(Order order)
        {
            _context.Orders.Add(order);
            order.OrderItems.ForEach(oi => _context.OrderItems.Add(oi));
            _context.SaveChanges();
        }
    }
}
