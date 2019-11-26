using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOD_PaymentService.Context;
using MOD_PaymentService.Models;
using MOD_PaymentService.Repository;


namespace MOD_PaymentService.Repository
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly PaymentContext _context;
        public PaymentRepository(PaymentContext context)
        {
            _context = context;

        }

        public void Add(Payment item)
        {
            try
            {
                _context.Payment.Add(item);
                _context.SaveChanges();
            }
            catch (Exception)
            { }
        }

        public List<Payment> GetAll()
        {
            return _context.Payment.ToList();
        }

        public Payment GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
